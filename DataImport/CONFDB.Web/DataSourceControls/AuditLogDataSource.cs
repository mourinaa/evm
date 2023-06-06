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
	/// Represents the DataRepository.AuditLogProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(AuditLogDataSourceDesigner))]
	public class AuditLogDataSource : ProviderDataSource<AuditLog, AuditLogKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AuditLogDataSource class.
		/// </summary>
		public AuditLogDataSource() : base(new AuditLogService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the AuditLogDataSourceView used by the AuditLogDataSource.
		/// </summary>
		protected AuditLogDataSourceView AuditLogView
		{
			get { return ( View as AuditLogDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the AuditLogDataSource control invokes to retrieve data.
		/// </summary>
		public AuditLogSelectMethod SelectMethod
		{
			get
			{
				AuditLogSelectMethod selectMethod = AuditLogSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (AuditLogSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the AuditLogDataSourceView class that is to be
		/// used by the AuditLogDataSource.
		/// </summary>
		/// <returns>An instance of the AuditLogDataSourceView class.</returns>
		protected override BaseDataSourceView<AuditLog, AuditLogKey> GetNewDataSourceView()
		{
			return new AuditLogDataSourceView(this, DefaultViewName);
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
	/// Supports the AuditLogDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class AuditLogDataSourceView : ProviderDataSourceView<AuditLog, AuditLogKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AuditLogDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the AuditLogDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public AuditLogDataSourceView(AuditLogDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal AuditLogDataSource AuditLogOwner
		{
			get { return Owner as AuditLogDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal AuditLogSelectMethod SelectMethod
		{
			get { return AuditLogOwner.SelectMethod; }
			set { AuditLogOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal AuditLogService AuditLogProvider
		{
			get { return Provider as AuditLogService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<AuditLog> GetSelectData(out int count)
		{
			Hashtable values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<AuditLog> results = null;
			AuditLog item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case AuditLogSelectMethod.Get:
					AuditLogKey entityKey  = new AuditLogKey();
					entityKey.Load(values);
					item = AuditLogProvider.Get(entityKey);
					results = new TList<AuditLog>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case AuditLogSelectMethod.GetAll:
                    results = AuditLogProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case AuditLogSelectMethod.GetPaged:
					results = AuditLogProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case AuditLogSelectMethod.Find:
					if ( FilterParameters != null )
						results = AuditLogProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = AuditLogProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case AuditLogSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = AuditLogProvider.GetById(_id);
					results = new TList<AuditLog>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == AuditLogSelectMethod.Get || SelectMethod == AuditLogSelectMethod.GetById )
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
				AuditLog entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					AuditLogProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<AuditLog> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			AuditLogProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region AuditLogDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the AuditLogDataSource class.
	/// </summary>
	public class AuditLogDataSourceDesigner : ProviderDataSourceDesigner<AuditLog, AuditLogKey>
	{
		/// <summary>
		/// Initializes a new instance of the AuditLogDataSourceDesigner class.
		/// </summary>
		public AuditLogDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public AuditLogSelectMethod SelectMethod
		{
			get { return ((AuditLogDataSource) DataSource).SelectMethod; }
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
				actions.Add(new AuditLogDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region AuditLogDataSourceActionList

	/// <summary>
	/// Supports the AuditLogDataSourceDesigner class.
	/// </summary>
	internal class AuditLogDataSourceActionList : DesignerActionList
	{
		private AuditLogDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the AuditLogDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public AuditLogDataSourceActionList(AuditLogDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public AuditLogSelectMethod SelectMethod
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

	#endregion AuditLogDataSourceActionList
	
	#endregion AuditLogDataSourceDesigner
	
	#region AuditLogSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the AuditLogDataSource.SelectMethod property.
	/// </summary>
	public enum AuditLogSelectMethod
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
		GetById
	}
	
	#endregion AuditLogSelectMethod

	#region AuditLogFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AuditLog"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AuditLogFilter : SqlFilter<AuditLogColumn>
	{
	}
	
	#endregion AuditLogFilter

	#region AuditLogExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AuditLog"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AuditLogExpressionBuilder : SqlExpressionBuilder<AuditLogColumn>
	{
	}
	
	#endregion AuditLogExpressionBuilder	

	#region AuditLogProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;AuditLogChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="AuditLog"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AuditLogProperty : ChildEntityProperty<AuditLogChildEntityTypes>
	{
	}
	
	#endregion AuditLogProperty
}

