﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'UTIL' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IUtil 
	{
		/// <summary>			
		/// ID : NOT A REAL TABLE. Just Used to Gen. UTIL SP's that can be called from NTier Objects.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "UTIL"</remarks>
		System.Int32 Id { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalId { get; set; }
			
		
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


