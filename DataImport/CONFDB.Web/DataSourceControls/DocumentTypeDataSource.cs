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
	/// Represents the DataRepository.DocumentTypeProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DocumentTypeDataSourceDesigner))]
	public class DocumentTypeDataSource : ProviderDataSource<DocumentType, DocumentTypeKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DocumentTypeDataSource class.
		/// </summary>
		public DocumentTypeDataSource() : base(new DocumentTypeService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DocumentTypeDataSourceView used by the DocumentTypeDataSource.
		/// </summary>
		protected DocumentTypeDataSourceView DocumentTypeView
		{
			get { return ( View as DocumentTypeDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DocumentTypeDataSource control invokes to retrieve data.
		/// </summary>
		public DocumentTypeSelectMethod SelectMethod
		{
			get
			{
				DocumentTypeSelectMethod selectMethod = DocumentTypeSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DocumentTypeSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DocumentTypeDataSourceView class that is to be
		/// used by the DocumentTypeDataSource.
		/// </summary>
		/// <returns>An instance of the DocumentTypeDataSourceView class.</returns>
		protected override BaseDataSourceView<DocumentType, DocumentTypeKey> GetNewDataSourceView()
		{
			return new DocumentTypeDataSourceView(this, DefaultViewName);
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
	/// Supports the DocumentTypeDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DocumentTypeDataSourceView : ProviderDataSourceView<DocumentType, DocumentTypeKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DocumentTypeDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DocumentTypeDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DocumentTypeDataSourceView(DocumentTypeDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DocumentTypeDataSource DocumentTypeOwner
		{
			get { return Owner as DocumentTypeDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DocumentTypeSelectMethod SelectMethod
		{
			get { return DocumentTypeOwner.SelectMethod; }
			set { DocumentTypeOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DocumentTypeService DocumentTypeProvider
		{
			get { return Provider as DocumentTypeService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DocumentType> GetSelectData(out int count)
		{
			Hashtable values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DocumentType> results = null;
			DocumentType item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DocumentTypeSelectMethod.Get:
					DocumentTypeKey entityKey  = new DocumentTypeKey();
					entityKey.Load(values);
					item = DocumentTypeProvider.Get(entityKey);
					results = new TList<DocumentType>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DocumentTypeSelectMethod.GetAll:
                    results = DocumentTypeProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DocumentTypeSelectMethod.GetPaged:
					results = DocumentTypeProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DocumentTypeSelectMethod.Find:
					if ( FilterParameters != null )
						results = DocumentTypeProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DocumentTypeProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DocumentTypeSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DocumentTypeProvider.GetById(_id);
					results = new TList<DocumentType>();
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
			if ( SelectMethod == DocumentTypeSelectMethod.Get || SelectMethod == DocumentTypeSelectMethod.GetById )
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
				DocumentType entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DocumentTypeProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DocumentType> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DocumentTypeProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DocumentTypeDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DocumentTypeDataSource class.
	/// </summary>
	public class DocumentTypeDataSourceDesigner : ProviderDataSourceDesigner<DocumentType, DocumentTypeKey>
	{
		/// <summary>
		/// Initializes a new instance of the DocumentTypeDataSourceDesigner class.
		/// </summary>
		public DocumentTypeDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DocumentTypeSelectMethod SelectMethod
		{
			get { return ((DocumentTypeDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DocumentTypeDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DocumentTypeDataSourceActionList

	/// <summary>
	/// Supports the DocumentTypeDataSourceDesigner class.
	/// </summary>
	internal class DocumentTypeDataSourceActionList : DesignerActionList
	{
		private DocumentTypeDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DocumentTypeDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DocumentTypeDataSourceActionList(DocumentTypeDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DocumentTypeSelectMethod SelectMethod
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

	#endregion DocumentTypeDataSourceActionList
	
	#endregion DocumentTypeDataSourceDesigner
	
	#region DocumentTypeSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DocumentTypeDataSource.SelectMethod property.
	/// </summary>
	public enum DocumentTypeSelectMethod
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
	
	#endregion DocumentTypeSelectMethod

	#region DocumentTypeFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DocumentType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DocumentTypeFilter : SqlFilter<DocumentTypeColumn>
	{
	}
	
	#endregion DocumentTypeFilter

	#region DocumentTypeExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DocumentType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DocumentTypeExpressionBuilder : SqlExpressionBuilder<DocumentTypeColumn>
	{
	}
	
	#endregion DocumentTypeExpressionBuilder	

	#region DocumentTypeProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DocumentTypeChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DocumentType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DocumentTypeProperty : ChildEntityProperty<DocumentTypeChildEntityTypes>
	{
	}
	
	#endregion DocumentTypeProperty
}

