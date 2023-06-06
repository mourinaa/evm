﻿using System;
using System.ComponentModel;

namespace CONFDB.Entities
{
	/// <summary>
	///		The data structure representation of the 'InvoiceCharges' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IInvoiceCharges 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "InvoiceCharges"</remarks>
		System.Int32 Id { get; set; }
				
		
		
		/// <summary>
		/// StartDate : 
		/// </summary>
		System.DateTime  StartDate  { get; set; }
		
		/// <summary>
		/// EndDate : 
		/// </summary>
		System.DateTime  EndDate  { get; set; }
		
		/// <summary>
		/// WholesalerID : 
		/// </summary>
		System.String  WholesalerId  { get; set; }
		
		/// <summary>
		/// CustomerID : 
		/// </summary>
		System.Int32  CustomerId  { get; set; }
		
		/// <summary>
		/// ModeratorID : 
		/// </summary>
		System.Int32?  ModeratorId  { get; set; }
		
		/// <summary>
		/// PriCustomerNumber : 
		/// </summary>
		System.String  PriCustomerNumber  { get; set; }
		
		/// <summary>
		/// SecCustomerNumber : 
		/// </summary>
		System.String  SecCustomerNumber  { get; set; }
		
		/// <summary>
		/// CustomerTransactionTypeID : 
		/// </summary>
		System.Int32  CustomerTransactionTypeId  { get; set; }
		
		/// <summary>
		/// TransactionDescription : 
		/// </summary>
		System.String  TransactionDescription  { get; set; }
		
		/// <summary>
		/// TransactionDate : 
		/// </summary>
		System.DateTime  TransactionDate  { get; set; }
		
		/// <summary>
		/// TransactionAmount : 
		/// </summary>
		System.Decimal?  TransactionAmount  { get; set; }
		
		/// <summary>
		/// LocalTaxRate : 
		/// </summary>
		System.Decimal?  LocalTaxRate  { get; set; }
		
		/// <summary>
		/// FederalTaxRate : 
		/// </summary>
		System.Decimal?  FederalTaxRate  { get; set; }
		
		/// <summary>
		/// LocalTaxAmount : Used to store the taxes for the given transaction. It could be zero since some services or customers are tax exempt.
		/// </summary>
		System.Decimal?  LocalTaxAmount  { get; set; }
		
		/// <summary>
		/// FederalTaxAmount : Used to store the taxes for the given transaction. It could be zero since some services or customers are tax exempt.
		/// </summary>
		System.Decimal?  FederalTaxAmount  { get; set; }
		
		/// <summary>
		/// TransactionTotal : The total amount of the transaction including taxes.
		/// </summary>
		System.Decimal?  TransactionTotal  { get; set; }
		
		/// <summary>
		/// Wholesaler_ProductID : Optional: But should be specified for Charges. Used to link transactions to a specific Product for reporting purpose, or can be used to select specific ProductRateID's for miscellaneous charges and the quantity.
		/// </summary>
		System.Int32?  Wholesaler_ProductId  { get; set; }
		
		/// <summary>
		/// ProductRateID : Optional: Used to type transactions very specifically to a Product Rate. Gives more gandular reporting.
		/// </summary>
		System.Int32?  ProductRateId  { get; set; }
		
		/// <summary>
		/// Quantity : Optional: Only used if ProductRateID is set. Used to store the number of items for the specific charge.
		/// </summary>
		System.Int32?  Quantity  { get; set; }
		
		/// <summary>
		/// SellRate : Optional: Used when ProductRateID is set and stores the price of the item as the time of purchase. Avoids issues if rates or charges change in the future.
		/// </summary>
		System.Decimal?  SellRate  { get; set; }
		
		/// <summary>
		/// BuyRate : Used to track WS costs
		/// </summary>
		System.Decimal?  BuyRate  { get; set; }
		
		/// <summary>
		/// WSTransactionAmount : Used to track WS costs
		/// </summary>
		System.Decimal?  WsTransactionAmount  { get; set; }
		
		/// <summary>
		/// ReferenceNumber : Optional: Used to store reference numbers that are meanful to customers or external systems or could be used to link transaction to a Call based on this. eg. Law Firms ref numbers, Check Numbers, etc.
		/// </summary>
		System.String  ReferenceNumber  { get; set; }
		
		/// <summary>
		/// UniqueConferenceID : Optional: Used to link the transaction to a specific conference.
		/// </summary>
		System.String  UniqueConferenceId  { get; set; }
		
		/// <summary>
		/// ElapsedTimeSeconds : Used to store the number of seconds for Conferencing Services when posted to Customer Transactions. This makes it easier for the Invoices to report the number of number of minutes used for the given items eg. teleconferencing, web, LD etc.
		/// </summary>
		System.Int32?  ElapsedTimeSeconds  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


