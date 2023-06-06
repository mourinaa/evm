﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'Customer_Feature' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICustomer_Feature 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Customer_Feature"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// CustomerID : 
		/// </summary>
		System.Int32  CustomerId  { get; set; }
		
		/// <summary>
		/// FeatureID : 
		/// </summary>
		System.Int32  FeatureId  { get; set; }
		
		/// <summary>
		/// FeatureOptionID : 
		/// </summary>
		System.Int32  FeatureOptionId  { get; set; }
		
		/// <summary>
		/// Enabled : 
		/// </summary>
		System.Boolean  Enabled  { get; set; }
		
		/// <summary>
		/// FeatureOptionValue : 
		/// </summary>
		System.String  FeatureOptionValue  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


