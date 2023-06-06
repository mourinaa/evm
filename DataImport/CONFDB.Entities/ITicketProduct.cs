﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'TicketProduct' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITicketProduct 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "TicketProduct"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// Name : 
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// Description : 
		/// </summary>
		System.String  Description  { get; set; }
		
		/// <summary>
		/// DisplayOrder : 
		/// </summary>
		System.Int32  DisplayOrder  { get; set; }
		
		/// <summary>
		/// Deleted : 
		/// </summary>
		System.Boolean?  Deleted  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _ticketTicketProductId
		/// </summary>	
		TList<Ticket> TicketCollection {  get;  set;}	

		#endregion Data Properties

	}
}


