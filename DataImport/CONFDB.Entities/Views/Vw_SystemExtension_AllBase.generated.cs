﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file Vw_SystemExtension_All.cs instead.
*/
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#endregion

namespace CONFDB.Entities
{
	///<summary>
	/// An object representation of the 'vw_SystemExtension_All' view. [No description found in the database]	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("Vw_SystemExtension_AllBase")]
	public abstract partial class Vw_SystemExtension_AllBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// CustomerID : 
		/// </summary>
		private System.Int32		  _customerId = (int)0;
		
		/// <summary>
		/// SystemExtensionID : 
		/// </summary>
		private System.Int32		  _systemExtensionId = (int)0;
		
		/// <summary>
		/// ExtensionTypeID : 
		/// </summary>
		private System.Int32		  _extensionTypeId = (int)0;
		
		/// <summary>
		/// ExtensionTypeLabel : 
		/// </summary>
		private System.String		  _extensionTypeLabel = string.Empty;
		
		/// <summary>
		/// CustomerCanView : 
		/// </summary>
		private System.Boolean		  _customerCanView = false;
		
		/// <summary>
		/// ModeratorCanView : 
		/// </summary>
		private System.Boolean		  _moderatorCanView = false;
		
		/// <summary>
		/// CustomerCanEdit : 
		/// </summary>
		private System.Boolean		  _customerCanEdit = false;
		
		/// <summary>
		/// ModeratorCanEdit : 
		/// </summary>
		private System.Boolean		  _moderatorCanEdit = false;
		
		/// <summary>
		/// TableID : 
		/// </summary>
		private System.Int32		  _tableId = (int)0;
		
		/// <summary>
		/// ReferenceValue : 
		/// </summary>
		private System.String		  _referenceValue = string.Empty;
		
		/// <summary>
		/// Name : 
		/// </summary>
		private System.String		  _name = string.Empty;
		
		/// <summary>
		/// DisplayName : 
		/// </summary>
		private System.String		  _displayName = string.Empty;
		
		/// <summary>
		/// CategoryName : 
		/// </summary>
		private System.String		  _categoryName = string.Empty;
		
		/// <summary>
		/// ExtensionTypeCategoryID : 
		/// </summary>
		private System.Int32		  _extensionTypeCategoryId = (int)0;
		
		/// <summary>
		/// SystemExtensionLabelID : 
		/// </summary>
		private System.Int32		  _systemExtensionLabelId = (int)0;
		
		/// <summary>
		/// Object that contains data to associate with this object
		/// </summary>
		private object _tag;
		
		/// <summary>
		/// Suppresses Entity Events from Firing, 
		/// useful when loading the entities from the database.
		/// </summary>
	    [NonSerialized] 
		private bool suppressEntityEvents = false;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="Vw_SystemExtension_AllBase"/> instance.
		///</summary>
		public Vw_SystemExtension_AllBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="Vw_SystemExtension_AllBase"/> instance.
		///</summary>
		///<param name="_customerId"></param>
		///<param name="_systemExtensionId"></param>
		///<param name="_extensionTypeId"></param>
		///<param name="_extensionTypeLabel"></param>
		///<param name="_customerCanView"></param>
		///<param name="_moderatorCanView"></param>
		///<param name="_customerCanEdit"></param>
		///<param name="_moderatorCanEdit"></param>
		///<param name="_tableId"></param>
		///<param name="_referenceValue"></param>
		///<param name="_name"></param>
		///<param name="_displayName"></param>
		///<param name="_categoryName"></param>
		///<param name="_extensionTypeCategoryId"></param>
		///<param name="_systemExtensionLabelId"></param>
		public Vw_SystemExtension_AllBase(System.Int32 _customerId, System.Int32 _systemExtensionId, System.Int32 _extensionTypeId, System.String _extensionTypeLabel, System.Boolean _customerCanView, System.Boolean _moderatorCanView, System.Boolean _customerCanEdit, System.Boolean _moderatorCanEdit, System.Int32 _tableId, System.String _referenceValue, System.String _name, System.String _displayName, System.String _categoryName, System.Int32 _extensionTypeCategoryId, System.Int32 _systemExtensionLabelId)
		{
			this._customerId = _customerId;
			this._systemExtensionId = _systemExtensionId;
			this._extensionTypeId = _extensionTypeId;
			this._extensionTypeLabel = _extensionTypeLabel;
			this._customerCanView = _customerCanView;
			this._moderatorCanView = _moderatorCanView;
			this._customerCanEdit = _customerCanEdit;
			this._moderatorCanEdit = _moderatorCanEdit;
			this._tableId = _tableId;
			this._referenceValue = _referenceValue;
			this._name = _name;
			this._displayName = _displayName;
			this._categoryName = _categoryName;
			this._extensionTypeCategoryId = _extensionTypeCategoryId;
			this._systemExtensionLabelId = _systemExtensionLabelId;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="Vw_SystemExtension_All"/> instance.
		///</summary>
		///<param name="_customerId"></param>
		///<param name="_systemExtensionId"></param>
		///<param name="_extensionTypeId"></param>
		///<param name="_extensionTypeLabel"></param>
		///<param name="_customerCanView"></param>
		///<param name="_moderatorCanView"></param>
		///<param name="_customerCanEdit"></param>
		///<param name="_moderatorCanEdit"></param>
		///<param name="_tableId"></param>
		///<param name="_referenceValue"></param>
		///<param name="_name"></param>
		///<param name="_displayName"></param>
		///<param name="_categoryName"></param>
		///<param name="_extensionTypeCategoryId"></param>
		///<param name="_systemExtensionLabelId"></param>
		public static Vw_SystemExtension_All CreateVw_SystemExtension_All(System.Int32 _customerId, System.Int32 _systemExtensionId, System.Int32 _extensionTypeId, System.String _extensionTypeLabel, System.Boolean _customerCanView, System.Boolean _moderatorCanView, System.Boolean _customerCanEdit, System.Boolean _moderatorCanEdit, System.Int32 _tableId, System.String _referenceValue, System.String _name, System.String _displayName, System.String _categoryName, System.Int32 _extensionTypeCategoryId, System.Int32 _systemExtensionLabelId)
		{
			Vw_SystemExtension_All newVw_SystemExtension_All = new Vw_SystemExtension_All();
			newVw_SystemExtension_All.CustomerId = _customerId;
			newVw_SystemExtension_All.SystemExtensionId = _systemExtensionId;
			newVw_SystemExtension_All.ExtensionTypeId = _extensionTypeId;
			newVw_SystemExtension_All.ExtensionTypeLabel = _extensionTypeLabel;
			newVw_SystemExtension_All.CustomerCanView = _customerCanView;
			newVw_SystemExtension_All.ModeratorCanView = _moderatorCanView;
			newVw_SystemExtension_All.CustomerCanEdit = _customerCanEdit;
			newVw_SystemExtension_All.ModeratorCanEdit = _moderatorCanEdit;
			newVw_SystemExtension_All.TableId = _tableId;
			newVw_SystemExtension_All.ReferenceValue = _referenceValue;
			newVw_SystemExtension_All.Name = _name;
			newVw_SystemExtension_All.DisplayName = _displayName;
			newVw_SystemExtension_All.CategoryName = _categoryName;
			newVw_SystemExtension_All.ExtensionTypeCategoryId = _extensionTypeCategoryId;
			newVw_SystemExtension_All.SystemExtensionLabelId = _systemExtensionLabelId;
			return newVw_SystemExtension_All;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the CustomerID property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 CustomerId
		{
			get
			{
				return this._customerId; 
			}
			set
			{
				if (_customerId == value)
					return;
					
				this._customerId = value;
				this._isDirty = true;
				
				OnPropertyChanged("CustomerId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SystemExtensionID property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 SystemExtensionId
		{
			get
			{
				return this._systemExtensionId; 
			}
			set
			{
				if (_systemExtensionId == value)
					return;
					
				this._systemExtensionId = value;
				this._isDirty = true;
				
				OnPropertyChanged("SystemExtensionId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ExtensionTypeID property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 ExtensionTypeId
		{
			get
			{
				return this._extensionTypeId; 
			}
			set
			{
				if (_extensionTypeId == value)
					return;
					
				this._extensionTypeId = value;
				this._isDirty = true;
				
				OnPropertyChanged("ExtensionTypeId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ExtensionTypeLabel property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ExtensionTypeLabel
		{
			get
			{
				return this._extensionTypeLabel; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "ExtensionTypeLabel does not allow null values.");
				if (_extensionTypeLabel == value)
					return;
					
				this._extensionTypeLabel = value;
				this._isDirty = true;
				
				OnPropertyChanged("ExtensionTypeLabel");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CustomerCanView property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Boolean CustomerCanView
		{
			get
			{
				return this._customerCanView; 
			}
			set
			{
				if (_customerCanView == value)
					return;
					
				this._customerCanView = value;
				this._isDirty = true;
				
				OnPropertyChanged("CustomerCanView");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ModeratorCanView property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Boolean ModeratorCanView
		{
			get
			{
				return this._moderatorCanView; 
			}
			set
			{
				if (_moderatorCanView == value)
					return;
					
				this._moderatorCanView = value;
				this._isDirty = true;
				
				OnPropertyChanged("ModeratorCanView");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CustomerCanEdit property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Boolean CustomerCanEdit
		{
			get
			{
				return this._customerCanEdit; 
			}
			set
			{
				if (_customerCanEdit == value)
					return;
					
				this._customerCanEdit = value;
				this._isDirty = true;
				
				OnPropertyChanged("CustomerCanEdit");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ModeratorCanEdit property. 
		///		
		/// </summary>
		/// <value>This type is bit</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Boolean ModeratorCanEdit
		{
			get
			{
				return this._moderatorCanEdit; 
			}
			set
			{
				if (_moderatorCanEdit == value)
					return;
					
				this._moderatorCanEdit = value;
				this._isDirty = true;
				
				OnPropertyChanged("ModeratorCanEdit");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the TableID property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 TableId
		{
			get
			{
				return this._tableId; 
			}
			set
			{
				if (_tableId == value)
					return;
					
				this._tableId = value;
				this._isDirty = true;
				
				OnPropertyChanged("TableId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ReferenceValue property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String ReferenceValue
		{
			get
			{
				return this._referenceValue; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "ReferenceValue does not allow null values.");
				if (_referenceValue == value)
					return;
					
				this._referenceValue = value;
				this._isDirty = true;
				
				OnPropertyChanged("ReferenceValue");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Name property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Name
		{
			get
			{
				return this._name; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "Name does not allow null values.");
				if (_name == value)
					return;
					
				this._name = value;
				this._isDirty = true;
				
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the DisplayName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String DisplayName
		{
			get
			{
				return this._displayName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "DisplayName does not allow null values.");
				if (_displayName == value)
					return;
					
				this._displayName = value;
				this._isDirty = true;
				
				OnPropertyChanged("DisplayName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the CategoryName property. 
		///		
		/// </summary>
		/// <value>This type is varchar</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String CategoryName
		{
			get
			{
				return this._categoryName; 
			}
			set
			{
				if ( value == null )
					throw new ArgumentNullException("value", "CategoryName does not allow null values.");
				if (_categoryName == value)
					return;
					
				this._categoryName = value;
				this._isDirty = true;
				
				OnPropertyChanged("CategoryName");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ExtensionTypeCategoryID property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 ExtensionTypeCategoryId
		{
			get
			{
				return this._extensionTypeCategoryId; 
			}
			set
			{
				if (_extensionTypeCategoryId == value)
					return;
					
				this._extensionTypeCategoryId = value;
				this._isDirty = true;
				
				OnPropertyChanged("ExtensionTypeCategoryId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the SystemExtensionLabelID property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 SystemExtensionLabelId
		{
			get
			{
				return this._systemExtensionLabelId; 
			}
			set
			{
				if (_systemExtensionLabelId == value)
					return;
					
				this._systemExtensionLabelId = value;
				this._isDirty = true;
				
				OnPropertyChanged("SystemExtensionLabelId");
			}
		}
		
		
		/// <summary>
		///     Gets or sets the object that contains supplemental data about this object.
		/// </summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag == value)
					return;
		
				this._tag = value;
			}
		}
	
		/// <summary>
		/// Determines whether this entity is to suppress events while set to true.
		/// </summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public bool SuppressEntityEvents
		{	
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}	
		}

		private bool _isDeleted = false;
		/// <summary>
		/// Gets a value indicating if object has been <see cref="MarkToDelete"/>. ReadOnly.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDeleted
		{
			get { return this._isDeleted; }
		}


		private bool _isDirty = false;
		/// <summary>
		///	Gets a value indicating  if the object has been modified from its original state.
		/// </summary>
		///<value>True if object has been modified from its original state; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDirty
		{
			get { return this._isDirty; }
		}
		

		private bool _isNew = true;
		/// <summary>
		///	Gets a value indicating if the object is new.
		/// </summary>
		///<value>True if objectis new; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsNew
		{
			get { return this._isNew; }
			set { this._isNew = value; }
		}

		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public string ViewName
		{
			get { return "vw_SystemExtension_All"; }
		}

		
		#endregion
		
		#region Methods	
		
		/// <summary>
		/// Accepts the changes made to this object by setting each flags to false.
		/// </summary>
		public virtual void AcceptChanges()
		{
			this._isDeleted = false;
			this._isDirty = false;
			this._isNew = false;
			OnPropertyChanged(string.Empty);
		}
		
		
		///<summary>
		///  Revert all changes and restore original values.
		///  Currently not supported.
		///</summary>
		/// <exception cref="NotSupportedException">This method is not currently supported and always throws this exception.</exception>
		public virtual void CancelChanges()
		{
			throw new NotSupportedException("Method currently not Supported.");
		}
		
		///<summary>
		///   Marks entity to be deleted.
		///</summary>
		public virtual void MarkToDelete()
		{
			this._isDeleted = true;
		}
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed Vw_SystemExtension_AllBase Entity 
		///</summary>
		public virtual Vw_SystemExtension_AllBase Copy()
		{
			//shallow copy entity
			Vw_SystemExtension_All copy = new Vw_SystemExtension_All();
				copy.CustomerId = this.CustomerId;
				copy.SystemExtensionId = this.SystemExtensionId;
				copy.ExtensionTypeId = this.ExtensionTypeId;
				copy.ExtensionTypeLabel = this.ExtensionTypeLabel;
				copy.CustomerCanView = this.CustomerCanView;
				copy.ModeratorCanView = this.ModeratorCanView;
				copy.CustomerCanEdit = this.CustomerCanEdit;
				copy.ModeratorCanEdit = this.ModeratorCanEdit;
				copy.TableId = this.TableId;
				copy.ReferenceValue = this.ReferenceValue;
				copy.Name = this.Name;
				copy.DisplayName = this.DisplayName;
				copy.CategoryName = this.CategoryName;
				copy.ExtensionTypeCategoryId = this.ExtensionTypeCategoryId;
				copy.SystemExtensionLabelId = this.SystemExtensionLabelId;
			copy.AcceptChanges();
			return (Vw_SystemExtension_All)copy;
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Deep Copy of this entity.
		///</summary>
		public object Clone(){
			return this.Copy();
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		#endregion
		
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="Vw_SystemExtension_AllBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(Vw_SystemExtension_AllBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="Vw_SystemExtension_AllBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="Vw_SystemExtension_AllBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="Vw_SystemExtension_AllBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(Vw_SystemExtension_AllBase Object1, Vw_SystemExtension_AllBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.CustomerId != Object2.CustomerId)
				equal = false;
			if (Object1.SystemExtensionId != Object2.SystemExtensionId)
				equal = false;
			if (Object1.ExtensionTypeId != Object2.ExtensionTypeId)
				equal = false;
			if (Object1.ExtensionTypeLabel != Object2.ExtensionTypeLabel)
				equal = false;
			if (Object1.CustomerCanView != Object2.CustomerCanView)
				equal = false;
			if (Object1.ModeratorCanView != Object2.ModeratorCanView)
				equal = false;
			if (Object1.CustomerCanEdit != Object2.CustomerCanEdit)
				equal = false;
			if (Object1.ModeratorCanEdit != Object2.ModeratorCanEdit)
				equal = false;
			if (Object1.TableId != Object2.TableId)
				equal = false;
			if (Object1.ReferenceValue != Object2.ReferenceValue)
				equal = false;
			if (Object1.Name != Object2.Name)
				equal = false;
			if (Object1.DisplayName != Object2.DisplayName)
				equal = false;
			if (Object1.CategoryName != Object2.CategoryName)
				equal = false;
			if (Object1.ExtensionTypeCategoryId != Object2.ExtensionTypeCategoryId)
				equal = false;
			if (Object1.SystemExtensionLabelId != Object2.SystemExtensionLabelId)
				equal = false;
			return equal;
		}
		
		#endregion
		
		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}
	
		#endregion
		
		#region INotifyPropertyChanged Members
		
		/// <summary>
      /// Event to indicate that a property has changed.
      /// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{ 
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}
		
		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!SuppressEntityEvents)
			{
				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}
		
		#endregion
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public static object GetPropertyValueByName(Vw_SystemExtension_All entity, string propertyName)
		{
			switch (propertyName)
			{
				case "CustomerId":
					return entity.CustomerId;
				case "SystemExtensionId":
					return entity.SystemExtensionId;
				case "ExtensionTypeId":
					return entity.ExtensionTypeId;
				case "ExtensionTypeLabel":
					return entity.ExtensionTypeLabel;
				case "CustomerCanView":
					return entity.CustomerCanView;
				case "ModeratorCanView":
					return entity.ModeratorCanView;
				case "CustomerCanEdit":
					return entity.CustomerCanEdit;
				case "ModeratorCanEdit":
					return entity.ModeratorCanEdit;
				case "TableId":
					return entity.TableId;
				case "ReferenceValue":
					return entity.ReferenceValue;
				case "Name":
					return entity.Name;
				case "DisplayName":
					return entity.DisplayName;
				case "CategoryName":
					return entity.CategoryName;
				case "ExtensionTypeCategoryId":
					return entity.ExtensionTypeCategoryId;
				case "SystemExtensionLabelId":
					return entity.SystemExtensionLabelId;
			}
			return null;
		}
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public object GetPropertyValueByName(string propertyName)
		{			
			return GetPropertyValueByName(this as Vw_SystemExtension_All, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{16}{15}- CustomerId: {0}{15}- SystemExtensionId: {1}{15}- ExtensionTypeId: {2}{15}- ExtensionTypeLabel: {3}{15}- CustomerCanView: {4}{15}- ModeratorCanView: {5}{15}- CustomerCanEdit: {6}{15}- ModeratorCanEdit: {7}{15}- TableId: {8}{15}- ReferenceValue: {9}{15}- Name: {10}{15}- DisplayName: {11}{15}- CategoryName: {12}{15}- ExtensionTypeCategoryId: {13}{15}- SystemExtensionLabelId: {14}{15}", 
				this.CustomerId,
				this.SystemExtensionId,
				this.ExtensionTypeId,
				this.ExtensionTypeLabel,
				this.CustomerCanView,
				this.ModeratorCanView,
				this.CustomerCanEdit,
				this.ModeratorCanEdit,
				this.TableId,
				this.ReferenceValue,
				this.Name,
				this.DisplayName,
				this.CategoryName,
				this.ExtensionTypeCategoryId,
				this.SystemExtensionLabelId,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the Vw_SystemExtension_All columns.
	/// </summary>
	[Serializable]
	public enum Vw_SystemExtension_AllColumn
	{
		/// <summary>
		/// CustomerID : 
		/// </summary>
		[EnumTextValue("CustomerID")]
		[ColumnEnum("CustomerID", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		CustomerId,
		/// <summary>
		/// SystemExtensionID : 
		/// </summary>
		[EnumTextValue("SystemExtensionID")]
		[ColumnEnum("SystemExtensionID", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		SystemExtensionId,
		/// <summary>
		/// ExtensionTypeID : 
		/// </summary>
		[EnumTextValue("ExtensionTypeID")]
		[ColumnEnum("ExtensionTypeID", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		ExtensionTypeId,
		/// <summary>
		/// ExtensionTypeLabel : 
		/// </summary>
		[EnumTextValue("ExtensionTypeLabel")]
		[ColumnEnum("ExtensionTypeLabel", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 50)]
		ExtensionTypeLabel,
		/// <summary>
		/// CustomerCanView : 
		/// </summary>
		[EnumTextValue("CustomerCanView")]
		[ColumnEnum("CustomerCanView", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, false)]
		CustomerCanView,
		/// <summary>
		/// ModeratorCanView : 
		/// </summary>
		[EnumTextValue("ModeratorCanView")]
		[ColumnEnum("ModeratorCanView", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, false)]
		ModeratorCanView,
		/// <summary>
		/// CustomerCanEdit : 
		/// </summary>
		[EnumTextValue("CustomerCanEdit")]
		[ColumnEnum("CustomerCanEdit", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, false)]
		CustomerCanEdit,
		/// <summary>
		/// ModeratorCanEdit : 
		/// </summary>
		[EnumTextValue("ModeratorCanEdit")]
		[ColumnEnum("ModeratorCanEdit", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, false)]
		ModeratorCanEdit,
		/// <summary>
		/// TableID : 
		/// </summary>
		[EnumTextValue("TableID")]
		[ColumnEnum("TableID", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		TableId,
		/// <summary>
		/// ReferenceValue : 
		/// </summary>
		[EnumTextValue("ReferenceValue")]
		[ColumnEnum("ReferenceValue", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 50)]
		ReferenceValue,
		/// <summary>
		/// Name : 
		/// </summary>
		[EnumTextValue("Name")]
		[ColumnEnum("Name", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 50)]
		Name,
		/// <summary>
		/// DisplayName : 
		/// </summary>
		[EnumTextValue("DisplayName")]
		[ColumnEnum("DisplayName", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 50)]
		DisplayName,
		/// <summary>
		/// CategoryName : 
		/// </summary>
		[EnumTextValue("CategoryName")]
		[ColumnEnum("CategoryName", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 50)]
		CategoryName,
		/// <summary>
		/// ExtensionTypeCategoryID : 
		/// </summary>
		[EnumTextValue("ExtensionTypeCategoryID")]
		[ColumnEnum("ExtensionTypeCategoryID", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		ExtensionTypeCategoryId,
		/// <summary>
		/// SystemExtensionLabelID : 
		/// </summary>
		[EnumTextValue("SystemExtensionLabelID")]
		[ColumnEnum("SystemExtensionLabelID", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		SystemExtensionLabelId
	}//End enum

} // end namespace
