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
	/// Represents the DataRepository.SalesPersonProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SalesPersonDataSourceDesigner))]
	public class SalesPersonDataSource : ProviderDataSource<SalesPerson, SalesPersonKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SalesPersonDataSource class.
		/// </summary>
		public SalesPersonDataSource() : base(new SalesPersonService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SalesPersonDataSourceView used by the SalesPersonDataSource.
		/// </summary>
		protected SalesPersonDataSourceView SalesPersonView
		{
			get { return ( View as SalesPersonDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SalesPersonDataSource control invokes to retrieve data.
		/// </summary>
		public SalesPersonSelectMethod SelectMethod
		{
			get
			{
				SalesPersonSelectMethod selectMethod = SalesPersonSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SalesPersonSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SalesPersonDataSourceView class that is to be
		/// used by the SalesPersonDataSource.
		/// </summary>
		/// <returns>An instance of the SalesPersonDataSourceView class.</returns>
		protected override BaseDataSourceView<SalesPerson, SalesPersonKey> GetNewDataSourceView()
		{
			return new SalesPersonDataSourceView(this, DefaultViewName);
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
	/// Supports the SalesPersonDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SalesPersonDataSourceView : ProviderDataSourceView<SalesPerson, SalesPersonKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SalesPersonDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SalesPersonDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SalesPersonDataSourceView(SalesPersonDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SalesPersonDataSource SalesPersonOwner
		{
			get { return Owner as SalesPersonDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SalesPersonSelectMethod SelectMethod
		{
			get { return SalesPersonOwner.SelectMethod; }
			set { SalesPersonOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SalesPersonService SalesPersonProvider
		{
			get { return Provider as SalesPersonService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SalesPerson> GetSelectData(out int count)
		{
			Hashtable values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SalesPerson> results = null;
			SalesPerson item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _salesManagerId_nullable;
			System.String _wholesalerId;

			switch ( SelectMethod )
			{
				case SalesPersonSelectMethod.Get:
					SalesPersonKey entityKey  = new SalesPersonKey();
					entityKey.Load(values);
					item = SalesPersonProvider.Get(entityKey);
					results = new TList<SalesPerson>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SalesPersonSelectMethod.GetAll:
                    results = SalesPersonProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SalesPersonSelectMethod.GetPaged:
					results = SalesPersonProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SalesPersonSelectMethod.Find:
					if ( FilterParameters != null )
						results = SalesPersonProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SalesPersonProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SalesPersonSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SalesPersonProvider.GetById(_id);
					results = new TList<SalesPerson>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case SalesPersonSelectMethod.GetBySalesManagerId:
					_salesManagerId_nullable = (System.Int32?) EntityUtil.ChangeType(values["SalesManagerId"], typeof(System.Int32?));
					results = SalesPersonProvider.GetBySalesManagerId(_salesManagerId_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case SalesPersonSelectMethod.GetByWholesalerId:
					_wholesalerId = ( values["WholesalerId"] != null ) ? (System.String) EntityUtil.ChangeType(values["WholesalerId"], typeof(System.String)) : string.Empty;
					results = SalesPersonProvider.GetByWholesalerId(_wholesalerId, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == SalesPersonSelectMethod.Get || SelectMethod == SalesPersonSelectMethod.GetById )
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
				SalesPerson entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SalesPersonProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SalesPerson> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SalesPersonProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SalesPersonDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SalesPersonDataSource class.
	/// </summary>
	public class SalesPersonDataSourceDesigner : ProviderDataSourceDesigner<SalesPerson, SalesPersonKey>
	{
		/// <summary>
		/// Initializes a new instance of the SalesPersonDataSourceDesigner class.
		/// </summary>
		public SalesPersonDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SalesPersonSelectMethod SelectMethod
		{
			get { return ((SalesPersonDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SalesPersonDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SalesPersonDataSourceActionList

	/// <summary>
	/// Supports the SalesPersonDataSourceDesigner class.
	/// </summary>
	internal class SalesPersonDataSourceActionList : DesignerActionList
	{
		private SalesPersonDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SalesPersonDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SalesPersonDataSourceActionList(SalesPersonDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SalesPersonSelectMethod SelectMethod
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

	#endregion SalesPersonDataSourceActionList
	
	#endregion SalesPersonDataSourceDesigner
	
	#region SalesPersonSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SalesPersonDataSource.SelectMethod property.
	/// </summary>
	public enum SalesPersonSelectMethod
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
		/// Represents the GetBySalesManagerId method.
		/// </summary>
		GetBySalesManagerId,
		/// <summary>
		/// Represents the GetByWholesalerId method.
		/// </summary>
		GetByWholesalerId
	}
	
	#endregion SalesPersonSelectMethod

	#region SalesPersonFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SalesPerson"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SalesPersonFilter : SqlFilter<SalesPersonColumn>
	{
	}
	
	#endregion SalesPersonFilter

	#region SalesPersonExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SalesPerson"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SalesPersonExpressionBuilder : SqlExpressionBuilder<SalesPersonColumn>
	{
	}
	
	#endregion SalesPersonExpressionBuilder	

	#region SalesPersonProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SalesPersonChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SalesPerson"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SalesPersonProperty : ChildEntityProperty<SalesPersonChildEntityTypes>
	{
	}
	
	#endregion SalesPersonProperty
}

