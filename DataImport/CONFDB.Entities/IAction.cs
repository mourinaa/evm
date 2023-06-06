﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'Action' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAction 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Action"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// DateTimeStamp : 
		/// </summary>
		System.DateTime?  DateTimeStamp  { get; set; }
		
		/// <summary>
		/// ActionTypeID : 
		/// </summary>
		System.Int32  ActionTypeId  { get; set; }
		
		/// <summary>
		/// ActionFrom : 
		/// </summary>
		System.String  ActionFrom  { get; set; }
		
		/// <summary>
		/// ExtraInfo : 
		/// </summary>
		System.String  ExtraInfo  { get; set; }
		
		/// <summary>
		/// ProcessedFlag : 
		/// </summary>
		System.String  ProcessedFlag  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


