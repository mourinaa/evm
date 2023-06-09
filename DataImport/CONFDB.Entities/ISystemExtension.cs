﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'SystemExtension' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISystemExtension 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SystemExtension"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// TableID : 
		/// </summary>
		System.Int32  TableId  { get; set; }
		
		/// <summary>
		/// ReferenceValue : 
		/// </summary>
		System.String  ReferenceValue  { get; set; }
		
		/// <summary>
		/// SystemExtensionLabelID : 
		/// </summary>
		System.Int32  SystemExtensionLabelId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


