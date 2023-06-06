﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'Customer_DNIS' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICustomer_Dnis 
	{
		/// <summary>			
		/// DNISID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Customer_DNIS"</remarks>
		System.Int32 Dnisid { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalDnisid { get; set; }
			
		/// <summary>			
		/// CustomerID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Customer_DNIS"</remarks>
		System.Int32 CustomerId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalCustomerId { get; set; }
			
		
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


