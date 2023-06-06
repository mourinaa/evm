﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'ConferencingSummary' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IConferencingSummary 
	{
		/// <summary>			
		/// BilledDate : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ConferencingSummary"</remarks>
		System.DateTime BilledDate { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.DateTime OriginalBilledDate { get; set; }
			
		/// <summary>			
		/// ProductID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ConferencingSummary"</remarks>
		System.Int32 ProductId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalProductId { get; set; }
			
		/// <summary>			
		/// Currency : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ConferencingSummary"</remarks>
		System.String Currency { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalCurrency { get; set; }
			
		
		
		/// <summary>
		/// LocalSeconds : 
		/// </summary>
		System.Int32  LocalSeconds  { get; set; }
		
		/// <summary>
		/// LDSeconds : 
		/// </summary>
		System.Int32  LdSeconds  { get; set; }
		
		/// <summary>
		/// TotalBridge : 
		/// </summary>
		System.Decimal?  TotalBridge  { get; set; }
		
		/// <summary>
		/// TotalLD : 
		/// </summary>
		System.Decimal?  TotalLd  { get; set; }
		
		/// <summary>
		/// TotalMiscellaneous : 
		/// </summary>
		System.Decimal?  TotalMiscellaneous  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

