﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'AreaCodeNXX' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAreaCodeNxx 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "AreaCodeNXX"</remarks>
		System.Int32 Id { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalId { get; set; }
			
		
		
		/// <summary>
		/// AreaCode : 
		/// </summary>
		System.String  AreaCode  { get; set; }
		
		/// <summary>
		/// Location1 : 
		/// </summary>
		System.String  Location1  { get; set; }
		
		/// <summary>
		/// Location2 : 
		/// </summary>
		System.String  Location2  { get; set; }
		
		/// <summary>
		/// ISOCountryCode : 
		/// </summary>
		System.String  IsoCountryCode  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


