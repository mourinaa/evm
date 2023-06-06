﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'TempTotalDollarsSpent' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITempTotalDollarsSpent 
	{
		/// <summary>			
		/// ID123 : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "TempTotalDollarsSpent"</remarks>
		System.Int32 Id123 { get; set; }
				
		
		
		/// <summary>
		/// PriCustomerNumber : 
		/// </summary>
		System.String  PriCustomerNumber  { get; set; }
		
		/// <summary>
		/// SecCustomerNumber : 
		/// </summary>
		System.String  SecCustomerNumber  { get; set; }
		
		/// <summary>
		/// TotalDollarsSpent : 
		/// </summary>
		System.Decimal?  TotalDollarsSpent  { get; set; }
		
		/// <summary>
		/// LastTimeUsed : 
		/// </summary>
		System.DateTime  LastTimeUsed  { get; set; }
		
		/// <summary>
		/// CreatedDate : 
		/// </summary>
		System.DateTime  CreatedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


