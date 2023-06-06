﻿
/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file TicketPriority.cs instead.
*/

#region using directives

using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;

#endregion

namespace CONFDB.Entities
{
	///<summary>
	/// An object representation of the 'TicketPriority' table. [No description found the database]	
	///</summary>
	[Serializable, DataObject]
	[CLSCompliant(true)]
	public abstract partial class TicketPriorityBase : EntityBase, CONFDB.Entities.ITicketPriority, IEntityId<TicketPriorityKey>, System.IComparable, System.ICloneable, IEditableObject, IComponent, INotifyPropertyChanged
	{		
		#region Variable Declarations
		
		/// <summary>
		///  Hold the inner data of the entity.
		/// </summary>
		private TicketPriorityEntityData entityData;
		
		/// <summary>
		/// 	Hold the original data of the entity, as loaded from the repository.
		/// </summary>
		private TicketPriorityEntityData _originalData;
		
		/// <summary>
		/// 	Hold a backup of the inner data of the entity.
		/// </summary>
		private TicketPriorityEntityData backupData; 
		
		/// <summary>
		/// 	Key used if Tracking is Enabled for the <see cref="EntityLocator" />.
		/// </summary>
		private string entityTrackingKey;
		
		/// <summary>
		/// 	Hold the parent TList&lt;entity&gt; in which this entity maybe contained.
		/// </summary>
		/// <remark>Mostly used for databinding</remark>
		[NonSerialized]
		private TList<TicketPriority> parentCollection;
		
		private bool inTxn = false;
		
		/// <summary>
		/// Occurs when a value is being changed for the specified column.
		/// </summary>	
		[field:NonSerialized]
		public event TicketPriorityEventHandler ColumnChanging;		
		
		/// <summary>
		/// Occurs after a value has been changed for the specified column.
		/// </summary>
		[field:NonSerialized]
		public event TicketPriorityEventHandler ColumnChanged;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="TicketPriorityBase"/> instance.
		///</summary>
		public TicketPriorityBase()
		{
			this.entityData = new TicketPriorityEntityData();
			this.backupData = null;
		}		
		
		///<summary>
		/// Creates a new <see cref="TicketPriorityBase"/> instance.
		///</summary>
		///<param name="_id"></param>
		///<param name="_name"></param>
		///<param name="_description"></param>
		///<param name="_displayOrder"></param>
		///<param name="_deleted"></param>
		public TicketPriorityBase(System.Int32 _id, System.String _name, System.String _description, 
			System.Int32 _displayOrder, System.Boolean? _deleted)
		{
			this.entityData = new TicketPriorityEntityData();
			this.backupData = null;

			this.Id = _id;
			this.Name = _name;
			this.Description = _description;
			this.DisplayOrder = _displayOrder;
			this.Deleted = _deleted;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="TicketPriority"/> instance.
		///</summary>
		///<param name="_id"></param>
		///<param name="_name"></param>
		///<param name="_description"></param>
		///<param name="_displayOrder"></param>
		///<param name="_deleted"></param>
		public static TicketPriority CreateTicketPriority(System.Int32 _id, System.String _name, System.String _description, 
			System.Int32 _displayOrder, System.Boolean? _deleted)
		{
			TicketPriority newTicketPriority = new TicketPriority();
			newTicketPriority.Id = _id;
			newTicketPriority.Name = _name;
			newTicketPriority.Description = _description;
			newTicketPriority.DisplayOrder = _displayOrder;
			newTicketPriority.Deleted = _deleted;
			return newTicketPriority;
		}
				
		#endregion Constructors
			
		#region Properties	
		
		#region Data Properties		
		/// <summary>
		/// 	Gets or sets the Id property. 
		///		
		/// </summary>
		/// <value>This type is int.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(true, false, false)]
		public virtual System.Int32 Id
		{
			get
			{
				return this.entityData.Id; 
			}
			
			set
			{
				if (this.entityData.Id == value)
					return;
					
				OnColumnChanging(TicketPriorityColumn.Id, this.entityData.Id);
				this.entityData.Id = value;
				this.EntityId.Id = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(TicketPriorityColumn.Id, this.entityData.Id);
				OnPropertyChanged("Id");
			}
		}
		
		/// <summary>
		/// 	Get the original value of the ID property.
		///		
		/// </summary>
		/// <remarks>This is the original value of the ID property.</remarks>
		/// <value>This type is int</value>
		[BrowsableAttribute(false)/*, XmlIgnoreAttribute()*/]
		public  virtual System.Int32 OriginalId
		{
			get { return this.entityData.OriginalId; }
			set { this.entityData.OriginalId = value; }
		}
		
		/// <summary>
		/// 	Gets or sets the Name property. 
		///		
		/// </summary>
		/// <value>This type is varchar.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		/// <exception cref="ArgumentNullException">If you attempt to set to null.</exception>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false, 30)]
		public virtual System.String Name
		{
			get
			{
				return this.entityData.Name; 
			}
			
			set
			{
				if (this.entityData.Name == value)
					return;
					
				OnColumnChanging(TicketPriorityColumn.Name, this.entityData.Name);
				this.entityData.Name = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(TicketPriorityColumn.Name, this.entityData.Name);
				OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the Description property. 
		///		
		/// </summary>
		/// <value>This type is varchar.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true, 200)]
		public virtual System.String Description
		{
			get
			{
				return this.entityData.Description; 
			}
			
			set
			{
				if (this.entityData.Description == value)
					return;
					
				OnColumnChanging(TicketPriorityColumn.Description, this.entityData.Description);
				this.entityData.Description = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(TicketPriorityColumn.Description, this.entityData.Description);
				OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the DisplayOrder property. 
		///		
		/// </summary>
		/// <value>This type is int.</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, false)]
		public virtual System.Int32 DisplayOrder
		{
			get
			{
				return this.entityData.DisplayOrder; 
			}
			
			set
			{
				if (this.entityData.DisplayOrder == value)
					return;
					
				OnColumnChanging(TicketPriorityColumn.DisplayOrder, this.entityData.DisplayOrder);
				this.entityData.DisplayOrder = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(TicketPriorityColumn.DisplayOrder, this.entityData.DisplayOrder);
				OnPropertyChanged("DisplayOrder");
			}
		}
		
		/// <summary>
		/// 	Gets or sets the Deleted property. 
		///		
		/// </summary>
		/// <value>This type is bit.</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return false. It is up to the developer
		/// to check the value of IsDeletedNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		[DataObjectField(false, false, true)]
		public virtual System.Boolean? Deleted
		{
			get
			{
				return this.entityData.Deleted; 
			}
			
			set
			{
				if (this.entityData.Deleted == value)
					return;
					
				OnColumnChanging(TicketPriorityColumn.Deleted, this.entityData.Deleted);
				this.entityData.Deleted = value;
				if (this.EntityState == EntityState.Unchanged)
					this.EntityState = EntityState.Changed;
				OnColumnChanged(TicketPriorityColumn.Deleted, this.entityData.Deleted);
				OnPropertyChanged("Deleted");
			}
		}
		
		#endregion Data Properties		

		#region Source Foreign Key Property
				
		#endregion
		
		#region Children Collections
	
		/// <summary>
		///	Holds a collection of Ticket objects
		///	which are related to this object through the relation FK_Ticket_TicketPriority
		/// </summary>	
		[System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
		public virtual TList<Ticket> TicketCollection
		{
			get { return entityData.TicketCollection; }
			set { entityData.TicketCollection = value; }	
		}
		#endregion Children Collections
		
		#endregion
		
		#region Validation
		
		/// <summary>
		/// Assigns validation rules to this object based on model definition.
		/// </summary>
		/// <remarks>This method overrides the base class to add schema related validation.</remarks>
		protected override void AddValidationRules()
		{
			//Validation rules based on database schema.
			ValidationRules.AddRule(
				Validation.CommonRules.NotNull,
				new Validation.ValidationRuleArgs("Name", "Name"));
			ValidationRules.AddRule(
				Validation.CommonRules.StringMaxLength, 
				new Validation.CommonRules.MaxLengthRuleArgs("Name", "Name", 30));
			ValidationRules.AddRule(
				Validation.CommonRules.StringMaxLength, 
				new Validation.CommonRules.MaxLengthRuleArgs("Description", "Description", 200));
		}
   		#endregion
		
		#region Table Meta Data
		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string TableName
		{
			get { return "TicketPriority"; }
		}
		
		/// <summary>
		///		The name of the underlying database table's columns.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public override string[] TableColumns
		{
			get
			{
				return new string[] {"ID", "Name", "Description", "DisplayOrder", "Deleted"};
			}
		}
		#endregion 
		
		#region IEditableObject
		
		#region  CancelAddNew Event
		/// <summary>
        /// The delegate for the CancelAddNew event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public delegate void CancelAddNewEventHandler(object sender, EventArgs e);
    
    	/// <summary>
		/// The CancelAddNew event.
		/// </summary>
		[field:NonSerialized]
		public event CancelAddNewEventHandler CancelAddNew ;

		/// <summary>
        /// Called when [cancel add new].
        /// </summary>
        public void OnCancelAddNew()
        {    
			if (!SuppressEntityEvents)
			{
	            CancelAddNewEventHandler handler = CancelAddNew ;
            	if (handler != null)
	            {    
    	            handler(this, EventArgs.Empty) ;
        	    }
	        }
        }
		#endregion 
		
		/// <summary>
		/// Begins an edit on an object.
		/// </summary>
		void IEditableObject.BeginEdit() 
	    {
	        //Console.WriteLine("Start BeginEdit");
	        if (!inTxn) 
	        {
	            this.backupData = this.entityData.Clone() as TicketPriorityEntityData;
	            inTxn = true;
	            //Console.WriteLine("BeginEdit");
	        }
	        //Console.WriteLine("End BeginEdit");
	    }
	
		/// <summary>
		/// Discards changes since the last <c>BeginEdit</c> call.
		/// </summary>
	    void IEditableObject.CancelEdit() 
	    {
	        //Console.WriteLine("Start CancelEdit");
	        if (this.inTxn) 
	        {
	            this.entityData = this.backupData;
	            this.backupData = null;
				this.inTxn = false;

				if (this.bindingIsNew)
	        	//if (this.EntityState == EntityState.Added)
	        	{
					if (this.parentCollection != null)
						this.parentCollection.Remove( (TicketPriority) this ) ;
				}	            
	        }
	        //Console.WriteLine("End CancelEdit");
	    }
	
		/// <summary>
		/// Pushes changes since the last <c>BeginEdit</c> or <c>IBindingList.AddNew</c> call into the underlying object.
		/// </summary>
	    void IEditableObject.EndEdit() 
	    {
	        //Console.WriteLine("Start EndEdit" + this.custData.id + this.custData.lastName);
	        if (this.inTxn) 
	        {
	            this.backupData = null;
				if (this.IsDirty) 
				{
					if (this.bindingIsNew) {
						this.EntityState = EntityState.Added;
						this.bindingIsNew = false ;
					}
					else
						if (this.EntityState == EntityState.Unchanged) 
							this.EntityState = EntityState.Changed ;
				}

				this.bindingIsNew = false ;
	            this.inTxn = false;	            
	        }
	        //Console.WriteLine("End EndEdit");
	    }
	    
	    /// <summary>
        /// Gets or sets the parent collection of this current entity, if available.
        /// </summary>
        /// <value>The parent collection.</value>
	    [XmlIgnore]
		[Browsable(false)]
	    public override object ParentCollection
	    {
	        get 
	        {
	            return this.parentCollection;
	        }
	        set 
	        {
	            this.parentCollection = value as TList<TicketPriority>;
	        }
	    }
	    
	    /// <summary>
        /// Called when the entity is changed.
        /// </summary>
	    private void OnEntityChanged() 
	    {
	        if (!SuppressEntityEvents && !inTxn && this.parentCollection != null) 
	        {
	            this.parentCollection.EntityChanged(this as TicketPriority);
	        }
	    }


		#endregion
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed TicketPriority Entity 
		///</summary>
		public virtual TicketPriority Copy()
		{
			//shallow copy entity
			TicketPriority copy = new TicketPriority();
			copy.SuppressEntityEvents = true;
			copy.Id = this.Id;
			copy.OriginalId = this.OriginalId;
			copy.Name = this.Name;
			copy.Description = this.Description;
			copy.DisplayOrder = this.DisplayOrder;
			copy.Deleted = this.Deleted;
			
		
			//deep copy nested objects
			copy.TicketCollection = (TList<Ticket>) MakeCopyOf(this.TicketCollection); 
			copy.EntityState = this.EntityState;
			copy.SuppressEntityEvents = false;
			return copy;
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Shallow Copy of this entity.
		///</summary>
		public object Clone()
		{
			return this.Copy();
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x == null)
				return null;
				
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		
		///<summary>
		///  Returns a Typed TicketPriority Entity which is a deep copy of the current entity.
		///</summary>
		public virtual TicketPriority DeepCopy()
		{
			return EntityHelper.Clone<TicketPriority>(this as TicketPriority);	
		}
		#endregion
		
		#region Methods	
			
		///<summary>
		/// Revert all changes and restore original values.
		///</summary>
		public override void CancelChanges()
		{
			IEditableObject obj = (IEditableObject) this;
			obj.CancelEdit();

			this.entityData = null;
			if (this._originalData != null)
			{
				this.entityData = this._originalData.Clone() as TicketPriorityEntityData;
			}
		}	
		
		/// <summary>
		/// Accepts the changes made to this object.
		/// </summary>
		/// <remarks>
		/// After calling this method, properties: IsDirty, IsNew are false. IsDeleted flag remains unchanged as it is handled by the parent List.
		/// </remarks>
		public override void AcceptChanges()
		{
			base.AcceptChanges();

			// we keep of the original version of the data
			this._originalData = null;
			this._originalData = this.entityData.Clone() as TicketPriorityEntityData;
		}
		
		#region Comparision with original data
		
		/// <summary>
		/// Determines whether the property value has changed from the original data.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <returns>
		/// 	<c>true</c> if the property value has changed; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPropertyChanged(TicketPriorityColumn column)
		{
			switch(column)
			{
					case TicketPriorityColumn.Id:
					return entityData.Id != _originalData.Id;
					case TicketPriorityColumn.Name:
					return entityData.Name != _originalData.Name;
					case TicketPriorityColumn.Description:
					return entityData.Description != _originalData.Description;
					case TicketPriorityColumn.DisplayOrder:
					return entityData.DisplayOrder != _originalData.DisplayOrder;
					case TicketPriorityColumn.Deleted:
					return entityData.Deleted != _originalData.Deleted;
			
				default:
					return false;
			}
		}
		
		/// <summary>
		/// Determines whether the data has changed from original.
		/// </summary>
		/// <returns>
		/// 	<c>true</c> if [has data changed]; otherwise, <c>false</c>.
		/// </returns>
		public bool HasDataChanged()
		{
			bool result = false;
			result = result || entityData.Id != _originalData.Id;
			result = result || entityData.Name != _originalData.Name;
			result = result || entityData.Description != _originalData.Description;
			result = result || entityData.DisplayOrder != _originalData.DisplayOrder;
			result = result || entityData.Deleted != _originalData.Deleted;
			return result;
}	
		
		#endregion

        ///<summary>
        /// Returns a value indicating whether this instance is equal to a specified object.
        ///</summary>
        ///<param name="Object1">An object to compare to this instance.</param>
        ///<returns>true if Object1 is a <see cref="TicketPriorityBase"/> and has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object Object1)
        {
			if (Object1 is TicketPriorityBase)
				return Equals(this, (TicketPriorityBase)Object1);
			else
				return false;
        }

        /// <summary>
		/// Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures like a hash table.
        /// Provides a hash function that is appropriate for <see cref="TicketPriorityBase"/> class 
        /// and that ensures a better distribution in the hash table
        /// </summary>
        /// <returns>number (hash code) that corresponds to the value of an object</returns>
        public override int GetHashCode()
        {
			return this.Id.GetHashCode() ^ 
					this.Name.GetHashCode() ^ 
					((this.Description == null) ? string.Empty : this.Description.ToString()).GetHashCode() ^ 
					this.DisplayOrder.GetHashCode() ^ 
					((this.Deleted == null) ? string.Empty : this.Deleted.ToString()).GetHashCode();
        }
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="TicketPriorityBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(TicketPriorityBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="TicketPriorityBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="TicketPriorityBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="TicketPriorityBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(TicketPriorityBase Object1, TicketPriorityBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;
				
			bool equal = true;
			if (Object1.Id != Object2.Id)
				equal = false;
			if (Object1.Name != Object2.Name)
				equal = false;
			if ( Object1.Description != null && Object2.Description != null )
			{
				if (Object1.Description != Object2.Description)
					equal = false;
			}
			else if (Object1.Description == null ^ Object2.Description == null )
			{
				equal = false;
			}
			if (Object1.DisplayOrder != Object2.DisplayOrder)
				equal = false;
			if ( Object1.Deleted != null && Object2.Deleted != null )
			{
				if (Object1.Deleted != Object2.Deleted)
					equal = false;
			}
			else if (Object1.Deleted == null ^ Object2.Deleted == null )
			{
				equal = false;
			}
					
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
			//return this. GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]) .CompareTo(((TicketPriorityBase)obj).GetPropertyName(SourceTable.PrimaryKey.MemberColumns[0]));
		}
		
		/*
		// static method to get a Comparer object
        public static TicketPriorityComparer GetComparer()
        {
            return new TicketPriorityComparer();
        }
        */

        // Comparer delegates back to TicketPriority
        // Employee uses the integer's default
        // CompareTo method
        /*
        public int CompareTo(Item rhs)
        {
            return this.Id.CompareTo(rhs.Id);
        }
        */

/*
        // Special implementation to be called by custom comparer
        public int CompareTo(TicketPriority rhs, TicketPriorityColumn which)
        {
            switch (which)
            {
            	
            	
            	case TicketPriorityColumn.Id:
            		return this.Id.CompareTo(rhs.Id);
            		
            		                 
            	
            	
            	case TicketPriorityColumn.Name:
            		return this.Name.CompareTo(rhs.Name);
            		
            		                 
            	
            	
            	case TicketPriorityColumn.Description:
            		return this.Description.CompareTo(rhs.Description);
            		
            		                 
            	
            	
            	case TicketPriorityColumn.DisplayOrder:
            		return this.DisplayOrder.CompareTo(rhs.DisplayOrder);
            		
            		                 
            	
            	
            	case TicketPriorityColumn.Deleted:
            		return this.Deleted.Value.CompareTo(rhs.Deleted.Value);
            		
            		                 
            }
            return 0;
        }
        */
	
		#endregion
		
		#region IComponent Members
		
		private ISite _site = null;

		/// <summary>
		/// Gets or Sets the site where this data is located.
		/// </summary>
		[XmlIgnore]
		[SoapIgnore]
		[Browsable(false)]
		public ISite Site
		{
			get{ return this._site; }
			set{ this._site = value; }
		}

		#endregion

		#region IDisposable Members
		
		/// <summary>
		/// Notify those that care when we dispose.
		/// </summary>
		[field:NonSerialized]
		public event System.EventHandler Disposed;

		/// <summary>
		/// Clean up. Nothing here though.
		/// </summary>
		public virtual void Dispose()
		{
			this.parentCollection = null;
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Clean up.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				EventHandler handler = Disposed;
				if (handler != null)
					handler(this, EventArgs.Empty);
			}
		}
		
		#endregion
				
		#region IEntityKey<TicketPriorityKey> Members
		
		// member variable for the EntityId property
		private TicketPriorityKey _entityId;

		/// <summary>
		/// Gets or sets the EntityId property.
		/// </summary>
		[XmlIgnore]
		public virtual TicketPriorityKey EntityId
		{
			get
			{
				if ( _entityId == null )
				{
					_entityId = new TicketPriorityKey(this);
				}

				return _entityId;
			}
			set
			{
				if ( value != null )
				{
					value.Entity = this;
				}
				
				_entityId = value;
			}
		}
		
		#endregion
		
		#region EntityState
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false) , XmlIgnoreAttribute()]
		public override EntityState EntityState 
		{ 
			get{ return entityData.EntityState;	 } 
			set{ entityData.EntityState = value; } 
		}
		#endregion 
		
		#region EntityTrackingKey
		///<summary>
		/// Provides the tracking key for the <see cref="EntityLocator"/>
		///</summary>
		[XmlIgnore]
		public override string EntityTrackingKey
		{
			get
			{
				if(entityTrackingKey == null)
					entityTrackingKey = new System.Text.StringBuilder("TicketPriority")
					.Append("|").Append( this.Id.ToString()).ToString();
				return entityTrackingKey;
			}
			set
		    {
		        if (value != null)
                    entityTrackingKey = value;
		    }
		}
		#endregion 
		
		#region ToString Method
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{6}{5}- Id: {0}{5}- Name: {1}{5}- Description: {2}{5}- DisplayOrder: {3}{5}- Deleted: {4}{5}", 
				this.Id,
				this.Name,
				(this.Description == null) ? string.Empty : this.Description.ToString(),
				this.DisplayOrder,
				(this.Deleted == null) ? string.Empty : this.Deleted.ToString(),
				System.Environment.NewLine, 
				this.GetType());
		}
		
		#endregion ToString Method
		
		#region Inner data class
		
	/// <summary>
	///		The data structure representation of the 'TicketPriority' table.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Serializable]
	internal protected class TicketPriorityEntityData : ICloneable
	{
		#region Variable Declarations
		private EntityState currentEntityState = EntityState.Added;
		
		#region Primary key(s)
			/// <summary>			
			/// ID : 
			/// </summary>
			/// <remarks>Member of the primary key of the underlying table "TicketPriority"</remarks>
			public System.Int32 Id;
				
			/// <summary>
			/// keep a copy of the original so it can be used for editable primary keys.
			/// </summary>
			public System.Int32 OriginalId;
			
		#endregion
		
		#region Non Primary key(s)
		
		
		/// <summary>
		/// Name : 
		/// </summary>
		public System.String		  Name = string.Empty;
		
		/// <summary>
		/// Description : 
		/// </summary>
		public System.String		  Description = null;
		
		/// <summary>
		/// DisplayOrder : 
		/// </summary>
		public System.Int32		  DisplayOrder = (int)0;
		
		/// <summary>
		/// Deleted : 
		/// </summary>
		public System.Boolean?		  Deleted = null;
		#endregion
			
		#region Source Foreign Key Property
				
		#endregion
		#endregion Variable Declarations
	
		#region Data Properties

		#region TicketCollection
		
		private TList<Ticket> _ticketTicketPriorityId;
		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _ticketTicketPriorityId
		/// </summary>	
		public TList<Ticket> TicketCollection
		{
			get
			{
				if (_ticketTicketPriorityId == null)
				{
				_ticketTicketPriorityId = new TList<Ticket>();
				}
	
				return _ticketTicketPriorityId;
			}
			set { _ticketTicketPriorityId = value; }
		}
		
		#endregion

		#endregion Data Properties
		
		#region Clone Method

		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		public Object Clone()
		{
			TicketPriorityEntityData _tmp = new TicketPriorityEntityData();
						
			_tmp.Id = this.Id;
			_tmp.OriginalId = this.OriginalId;
			
			_tmp.Name = this.Name;
			_tmp.Description = this.Description;
			_tmp.DisplayOrder = this.DisplayOrder;
			_tmp.Deleted = this.Deleted;
			
			#region Source Parent Composite Entities
			#endregion
		
			#region Child Collections
			//deep copy nested objects
			if (this._ticketTicketPriorityId != null)
				_tmp.TicketCollection = (TList<Ticket>) MakeCopyOf(this.TicketCollection); 
			#endregion Child Collections
			
			//EntityState
			_tmp.EntityState = this.EntityState;
			
			return _tmp;
		}
		
		#endregion Clone Method
		
		/// <summary>
		///		Indicates state of object
		/// </summary>
		/// <remarks>0=Unchanged, 1=Added, 2=Changed</remarks>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public EntityState	EntityState
		{
			get { return currentEntityState;  }
			set { currentEntityState = value; }
		}
	
	}//End struct



		#endregion
		
				
		
		#region Events trigger
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="TicketPriorityColumn"/> which has raised the event.</param>
		public void OnColumnChanging(TicketPriorityColumn column)
		{
			OnColumnChanging(column, null);
			return;
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="TicketPriorityColumn"/> which has raised the event.</param>
		public void OnColumnChanged(TicketPriorityColumn column)
		{
			OnColumnChanged(column, null);
			return;
		} 
		
		
		/// <summary>
		/// Raises the <see cref="ColumnChanging" /> event.
		/// </summary>
		/// <param name="column">The <see cref="TicketPriorityColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public void OnColumnChanging(TicketPriorityColumn column, object value)
		{
			if(IsEntityTracked && EntityState != EntityState.Added && !EntityManager.TrackChangedEntities)
				EntityManager.StopTracking(entityTrackingKey);
				
			if (!SuppressEntityEvents)
			{
				TicketPriorityEventHandler handler = ColumnChanging;
				if(handler != null)
				{
					handler(this, new TicketPriorityEventArgs(column, value));
				}
			}
		}
		
		/// <summary>
		/// Raises the <see cref="ColumnChanged" /> event.
		/// </summary>
		/// <param name="column">The <see cref="TicketPriorityColumn"/> which has raised the event.</param>
		/// <param name="value">The changed value.</param>
		public void OnColumnChanged(TicketPriorityColumn column, object value)
		{
			if (!SuppressEntityEvents)
			{
				TicketPriorityEventHandler handler = ColumnChanged;
				if(handler != null)
				{
					handler(this, new TicketPriorityEventArgs(column, value));
				}
			
				// warn the parent list that i have changed
				OnEntityChanged();
			}
		} 
		#endregion
			
	} // End Class
	
	
	#region TicketPriorityEventArgs class
	/// <summary>
	/// Provides data for the ColumnChanging and ColumnChanged events.
	/// </summary>
	/// <remarks>
	/// The ColumnChanging and ColumnChanged events occur when a change is made to the value 
	/// of a property of a <see cref="TicketPriority"/> object.
	/// </remarks>
	public class TicketPriorityEventArgs : System.EventArgs
	{
		private TicketPriorityColumn column;
		private object value;
		
		///<summary>
		/// Initalizes a new Instance of the TicketPriorityEventArgs class.
		///</summary>
		public TicketPriorityEventArgs(TicketPriorityColumn column)
		{
			this.column = column;
		}
		
		///<summary>
		/// Initalizes a new Instance of the TicketPriorityEventArgs class.
		///</summary>
		public TicketPriorityEventArgs(TicketPriorityColumn column, object value)
		{
			this.column = column;
			this.value = value;
		}
		
		///<summary>
		/// The TicketPriorityColumn that was modified, which has raised the event.
		///</summary>
		///<value cref="TicketPriorityColumn" />
		public TicketPriorityColumn Column { get { return this.column; } }
		
		/// <summary>
        /// Gets the current value of the column.
        /// </summary>
        /// <value>The current value of the column.</value>
		public object Value{ get { return this.value; } }

	}
	#endregion
	
	///<summary>
	/// Define a delegate for all TicketPriority related events.
	///</summary>
	public delegate void TicketPriorityEventHandler(object sender, TicketPriorityEventArgs e);
	
	#region TicketPriorityComparer
		
	/// <summary>
	///	Strongly Typed IComparer
	/// </summary>
	public class TicketPriorityComparer : System.Collections.Generic.IComparer<TicketPriority>
	{
		TicketPriorityColumn whichComparison;
		
		/// <summary>
        /// Initializes a new instance of the <see cref="T:TicketPriorityComparer"/> class.
        /// </summary>
		public TicketPriorityComparer()
        {            
        }               
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:TicketPriorityComparer"/> class.
        /// </summary>
        /// <param name="column">The column to sort on.</param>
        public TicketPriorityComparer(TicketPriorityColumn column)
        {
            this.whichComparison = column;
        }

		/// <summary>
        /// Determines whether the specified <c cref="TicketPriority"/> instances are considered equal.
        /// </summary>
        /// <param name="a">The first <c cref="TicketPriority"/> to compare.</param>
        /// <param name="b">The second <c>TicketPriority</c> to compare.</param>
        /// <returns>true if objA is the same instance as objB or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
        public bool Equals(TicketPriority a, TicketPriority b)
        {
            return this.Compare(a, b) == 0;
        }

		/// <summary>
        /// Gets the hash code of the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public int GetHashCode(TicketPriority entity)
        {
            return entity.GetHashCode();
        }

        /// <summary>
        /// Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(TicketPriority a, TicketPriority b)
        {
        	EntityPropertyComparer entityPropertyComparer = new EntityPropertyComparer(this.whichComparison.ToString());
        	return entityPropertyComparer.Compare(a, b);
        }

		/// <summary>
        /// Gets or sets the column that will be used for comparison.
        /// </summary>
        /// <value>The comparison column.</value>
        public TicketPriorityColumn WhichComparison
        {
            get { return this.whichComparison; }
            set { this.whichComparison = value; }
        }
	}
	
	#endregion
	
	#region TicketPriorityKey Class

	/// <summary>
	/// Wraps the unique identifier values for the <see cref="TicketPriority"/> object.
	/// </summary>
	[Serializable]
	[CLSCompliant(true)]
	public class TicketPriorityKey : EntityKeyBase
	{
		#region Constructors
		
		/// <summary>
		/// Initializes a new instance of the TicketPriorityKey class.
		/// </summary>
		public TicketPriorityKey()
		{
		}
		
		/// <summary>
		/// Initializes a new instance of the TicketPriorityKey class.
		/// </summary>
		public TicketPriorityKey(TicketPriorityBase entity)
		{
			this.Entity = entity;

			#region Init Properties

			if ( entity != null )
			{
				this.Id = entity.Id;
			}

			#endregion
		}
		
		/// <summary>
		/// Initializes a new instance of the TicketPriorityKey class.
		/// </summary>
		public TicketPriorityKey(System.Int32 _id)
		{
			#region Init Properties

			this.Id = _id;

			#endregion
		}
		
		#endregion Constructors

		#region Properties
		
		// member variable for the Entity property
		private TicketPriorityBase _entity;
		
		/// <summary>
		/// Gets or sets the Entity property.
		/// </summary>
		public TicketPriorityBase Entity
		{
			get { return _entity; }
			set { _entity = value; }
		}
		
		// member variable for the Id property
		private System.Int32 _id;
		
		/// <summary>
		/// Gets or sets the Id property.
		/// </summary>
		public System.Int32 Id
		{
			get { return _id; }
			set
			{
				if ( this.Entity != null )
					this.Entity.Id = value;
				
				_id = value;
			}
		}
		
		#endregion

		#region Methods
		
		/// <summary>
		/// Reads values from the supplied <see cref="IDictionary"/> object into
		/// properties of the current object.
		/// </summary>
		/// <param name="values">An <see cref="IDictionary"/> instance that contains
		/// the key/value pairs to be used as property values.</param>
		public override void Load(IDictionary values)
		{
			#region Init Properties

			if ( values != null )
			{
				Id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
			}

			#endregion
		}

		/// <summary>
		/// Creates a new <see cref="IDictionary"/> object and populates it
		/// with the property values of the current object.
		/// </summary>
		/// <returns>A collection of name/value pairs.</returns>
		public override IDictionary ToDictionary()
		{
			IDictionary values = new Hashtable();

			#region Init Dictionary

			values.Add("Id", Id);

			#endregion Init Dictionary

			return values;
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return String.Format("Id: {0}{1}",
								Id,
								System.Environment.NewLine);
		}

		#endregion Methods
	}
	
	#endregion	

	#region TicketPriorityColumn Enum
	
	/// <summary>
	/// Enumerate the TicketPriority columns.
	/// </summary>
	[Serializable]
	public enum TicketPriorityColumn : int
	{
		/// <summary>
		/// Id : 
		/// </summary>
		[EnumTextValue("ID")]
		[ColumnEnum("ID", typeof(System.Int32), System.Data.DbType.Int32, true, false, false)]
		Id = 1,
		/// <summary>
		/// Name : 
		/// </summary>
		[EnumTextValue("Name")]
		[ColumnEnum("Name", typeof(System.String), System.Data.DbType.AnsiString, false, false, false, 30)]
		Name = 2,
		/// <summary>
		/// Description : 
		/// </summary>
		[EnumTextValue("Description")]
		[ColumnEnum("Description", typeof(System.String), System.Data.DbType.AnsiString, false, false, true, 200)]
		Description = 3,
		/// <summary>
		/// DisplayOrder : 
		/// </summary>
		[EnumTextValue("DisplayOrder")]
		[ColumnEnum("DisplayOrder", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		DisplayOrder = 4,
		/// <summary>
		/// Deleted : 
		/// </summary>
		[EnumTextValue("Deleted")]
		[ColumnEnum("Deleted", typeof(System.Boolean), System.Data.DbType.Boolean, false, false, true)]
		Deleted = 5
	}//End enum

	#endregion TicketPriorityColumn Enum

} // end namespace
