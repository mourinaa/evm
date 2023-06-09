﻿#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using CONFDB.Entities;
using CONFDB.Data;
using CONFDB.Data.Bases;
using CONFDB.Services;
#endregion

namespace CONFDB.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.VerticalProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(VerticalDataSourceDesigner))]
	public class VerticalDataSource : ProviderDataSource<Vertical, VerticalKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VerticalDataSource class.
		/// </summary>
		public VerticalDataSource() : base(new VerticalService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VerticalDataSourceView used by the VerticalDataSource.
		/// </summary>
		protected VerticalDataSourceView VerticalView
		{
			get { return ( View as VerticalDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the VerticalDataSource control invokes to retrieve data.
		/// </summary>
		public VerticalSelectMethod SelectMethod
		{
			get
			{
				VerticalSelectMethod selectMethod = VerticalSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (VerticalSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VerticalDataSourceView class that is to be
		/// used by the VerticalDataSource.
		/// </summary>
		/// <returns>An instance of the VerticalDataSourceView class.</returns>
		protected override BaseDataSourceView<Vertical, VerticalKey> GetNewDataSourceView()
		{
			return new VerticalDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the VerticalDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VerticalDataSourceView : ProviderDataSourceView<Vertical, VerticalKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VerticalDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VerticalDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VerticalDataSourceView(VerticalDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VerticalDataSource VerticalOwner
		{
			get { return Owner as VerticalDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal VerticalSelectMethod SelectMethod
		{
			get { return VerticalOwner.SelectMethod; }
			set { VerticalOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VerticalService VerticalProvider
		{
			get { return Provider as VerticalService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<Vertical> GetSelectData(out int count)
		{
			Hashtable values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<Vertical> results = null;
			Vertical item;
			count = 0;
			
			System.Int32 _id;
			System.String _description_nullable;
			System.String _wholesalerId;

			switch ( SelectMethod )
			{
				case VerticalSelectMethod.Get:
					VerticalKey entityKey  = new VerticalKey();
					entityKey.Load(values);
					item = VerticalProvider.Get(entityKey);
					results = new TList<Vertical>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case VerticalSelectMethod.GetAll:
                    results = VerticalProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case VerticalSelectMethod.GetPaged:
					results = VerticalProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case VerticalSelectMethod.Find:
					if ( FilterParameters != null )
						results = VerticalProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = VerticalProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case VerticalSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = VerticalProvider.GetById(_id);
					results = new TList<Vertical>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case VerticalSelectMethod.GetByDescription:
					_description_nullable = (System.String) EntityUtil.ChangeType(values["Description"], typeof(System.String));
					results = VerticalProvider.GetByDescription(_description_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case VerticalSelectMethod.GetByWholesalerIdDescription:
					_wholesalerId = ( values["WholesalerId"] != null ) ? (System.String) EntityUtil.ChangeType(values["WholesalerId"], typeof(System.String)) : string.Empty;
					_description_nullable = (System.String) EntityUtil.ChangeType(values["Description"], typeof(System.String));
					results = VerticalProvider.GetByWholesalerIdDescription(_wholesalerId, _description_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// FK
				case VerticalSelectMethod.GetByWholesalerId:
					_wholesalerId = ( values["WholesalerId"] != null ) ? (System.String) EntityUtil.ChangeType(values["WholesalerId"], typeof(System.String)) : string.Empty;
					results = VerticalProvider.GetByWholesalerId(_wholesalerId, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == VerticalSelectMethod.Get || SelectMethod == VerticalSelectMethod.GetById )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				Vertical entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					VerticalProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<Vertical> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			VerticalProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region VerticalDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VerticalDataSource class.
	/// </summary>
	public class VerticalDataSourceDesigner : ProviderDataSourceDesigner<Vertical, VerticalKey>
	{
		/// <summary>
		/// Initializes a new instance of the VerticalDataSourceDesigner class.
		/// </summary>
		public VerticalDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public VerticalSelectMethod SelectMethod
		{
			get { return ((VerticalDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new VerticalDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region VerticalDataSourceActionList

	/// <summary>
	/// Supports the VerticalDataSourceDesigner class.
	/// </summary>
	internal class VerticalDataSourceActionList : DesignerActionList
	{
		private VerticalDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the VerticalDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public VerticalDataSourceActionList(VerticalDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public VerticalSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion VerticalDataSourceActionList
	
	#endregion VerticalDataSourceDesigner
	
	#region VerticalSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the VerticalDataSource.SelectMethod property.
	/// </summary>
	public enum VerticalSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByDescription method.
		/// </summary>
		GetByDescription,
		/// <summary>
		/// Represents the GetByWholesalerIdDescription method.
		/// </summary>
		GetByWholesalerIdDescription,
		/// <summary>
		/// Represents the GetByWholesalerId method.
		/// </summary>
		GetByWholesalerId
	}
	
	#endregion VerticalSelectMethod

	#region VerticalFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Vertical"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VerticalFilter : SqlFilter<VerticalColumn>
	{
	}
	
	#endregion VerticalFilter

	#region VerticalExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Vertical"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VerticalExpressionBuilder : SqlExpressionBuilder<VerticalColumn>
	{
	}
	
	#endregion VerticalExpressionBuilder	

	#region VerticalProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;VerticalChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="Vertical"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VerticalProperty : ChildEntityProperty<VerticalChildEntityTypes>
	{
	}
	
	#endregion VerticalProperty
}

