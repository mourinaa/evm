﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'AdminSiteNotes' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAdminSiteNotes 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "AdminSiteNotes"</remarks>
		System.Int32 Id { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalId { get; set; }
			
		
		
		/// <summary>
		/// CustomerID : 
		/// </summary>
		System.Int32  CustomerId  { get; set; }
		
		/// <summary>
		/// UserID : Link to Moderator
		/// </summary>
		System.Int32?  UserId  { get; set; }
		
		/// <summary>
		/// ModeratorID : LInk to Conference which is Moderator table
		/// </summary>
		System.Int32?  ModeratorId  { get; set; }
		
		/// <summary>
		/// Notes : 
		/// </summary>
		System.String  Notes  { get; set; }
		
		/// <summary>
		/// ModifiedBy : 
		/// </summary>
		System.String  ModifiedBy  { get; set; }
		
		/// <summary>
		/// CreatedDate : 
		/// </summary>
		System.DateTime  CreatedDate  { get; set; }
		
		/// <summary>
		/// WholesalerID : 
		/// </summary>
		System.String  WholesalerId  { get; set; }
		
		/// <summary>
		/// Deleted : 
		/// </summary>
		System.Boolean  Deleted  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _adminSiteNotesHistoryAdminSiteNotesId
		/// </summary>	
		TList<AdminSiteNotesHistory> AdminSiteNotesHistoryCollection {  get;  set;}	

		#endregion Data Properties

	}
}


