﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'CommissionCustomer' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICommissionCustomer 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CommissionCustomer"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// WholesalerID : 
		/// </summary>
		System.String  WholesalerId  { get; set; }
		
		/// <summary>
		/// CustomerID : 
		/// </summary>
		System.Int32  CustomerId  { get; set; }
		
		/// <summary>
		/// SalesPersonID : 
		/// </summary>
		System.Int32?  SalesPersonId  { get; set; }
		
		/// <summary>
		/// InvoiceCount : 
		/// </summary>
		System.Int32?  InvoiceCount  { get; set; }
		
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


