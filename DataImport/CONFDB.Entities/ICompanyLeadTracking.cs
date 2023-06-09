﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'CompanyLeadTracking' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICompanyLeadTracking 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "CompanyLeadTracking"</remarks>
		System.Int32 Id { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalId { get; set; }
			
		
		
		/// <summary>
		/// CompanyInfoID : 
		/// </summary>
		System.Int32  CompanyInfoId  { get; set; }
		
		/// <summary>
		/// ProjectedRevenue : 
		/// </summary>
		System.Decimal?  ProjectedRevenue  { get; set; }
		
		/// <summary>
		/// LeadProductID : 
		/// </summary>
		System.Int32  LeadProductId  { get; set; }
		
		/// <summary>
		/// LeadSourceID : 
		/// </summary>
		System.Int32  LeadSourceId  { get; set; }
		
		/// <summary>
		/// LeadStageID : 
		/// </summary>
		System.Int32  LeadStageId  { get; set; }
		
		/// <summary>
		/// ExpectedCloseDate : 
		/// </summary>
		System.DateTime  ExpectedCloseDate  { get; set; }
		
		/// <summary>
		/// CreatedDate : 
		/// </summary>
		System.DateTime  CreatedDate  { get; set; }
		
		/// <summary>
		/// ModifiedBy : 
		/// </summary>
		System.String  ModifiedBy  { get; set; }
		
		/// <summary>
		/// LeadPeriodID : 
		/// </summary>
		System.Int32  LeadPeriodId  { get; set; }
		
		/// <summary>
		/// LeadChurnReasonID : 
		/// </summary>
		System.Int32  LeadChurnReasonId  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _companyLeadTrackingNotesCompanyLeadTrackingId
		/// </summary>	
		TList<CompanyLeadTrackingNotes> CompanyLeadTrackingNotesCollection {  get;  set;}	

		#endregion Data Properties

	}
}


