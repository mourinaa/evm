﻿#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using CONFDB.Entities;
using CONFDB.Data;

#endregion

namespace CONFDB.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="Customer_FeatureProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class Customer_FeatureProviderBaseCore : EntityProviderBase<CONFDB.Entities.Customer_Feature, CONFDB.Entities.Customer_FeatureKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, CONFDB.Entities.Customer_FeatureKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Customer_Feature_FK key.
		///		Customer_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="_customerId"></param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerId(System.Int32 _customerId)
		{
			int count = -1;
			return GetByCustomerId(_customerId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Customer_Feature_FK key.
		///		Customer_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_customerId"></param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		/// <remarks></remarks>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerId(TransactionManager transactionManager, System.Int32 _customerId)
		{
			int count = -1;
			return GetByCustomerId(transactionManager, _customerId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Customer_Feature_FK key.
		///		Customer_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_customerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerId(TransactionManager transactionManager, System.Int32 _customerId, int start, int pageLength)
		{
			int count = -1;
			return GetByCustomerId(transactionManager, _customerId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Customer_Feature_FK key.
		///		customer_Customer_Feature_Fk Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_customerId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerId(System.Int32 _customerId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCustomerId(null, _customerId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Customer_Feature_FK key.
		///		customer_Customer_Feature_Fk Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_customerId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerId(System.Int32 _customerId, int start, int pageLength,out int count)
		{
			return GetByCustomerId(null, _customerId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Customer_Feature_FK key.
		///		Customer_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_customerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public abstract CONFDB.Entities.TList<Customer_Feature> GetByCustomerId(TransactionManager transactionManager, System.Int32 _customerId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the Feature_Customer_Feature_FK key.
		///		Feature_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="_featureId"></param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureId(System.Int32 _featureId)
		{
			int count = -1;
			return GetByFeatureId(_featureId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Feature_Customer_Feature_FK key.
		///		Feature_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureId"></param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		/// <remarks></remarks>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureId(TransactionManager transactionManager, System.Int32 _featureId)
		{
			int count = -1;
			return GetByFeatureId(transactionManager, _featureId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the Feature_Customer_Feature_FK key.
		///		Feature_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureId(TransactionManager transactionManager, System.Int32 _featureId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeatureId(transactionManager, _featureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Feature_Customer_Feature_FK key.
		///		feature_Customer_Feature_Fk Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_featureId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureId(System.Int32 _featureId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeatureId(null, _featureId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Feature_Customer_Feature_FK key.
		///		feature_Customer_Feature_Fk Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_featureId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureId(System.Int32 _featureId, int start, int pageLength,out int count)
		{
			return GetByFeatureId(null, _featureId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the Feature_Customer_Feature_FK key.
		///		Feature_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public abstract CONFDB.Entities.TList<Customer_Feature> GetByFeatureId(TransactionManager transactionManager, System.Int32 _featureId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FeatureOption_Customer_Feature_FK key.
		///		FeatureOption_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="_featureOptionId"></param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureOptionId(System.Int32 _featureOptionId)
		{
			int count = -1;
			return GetByFeatureOptionId(_featureOptionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FeatureOption_Customer_Feature_FK key.
		///		FeatureOption_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureOptionId"></param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		/// <remarks></remarks>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureOptionId(TransactionManager transactionManager, System.Int32 _featureOptionId)
		{
			int count = -1;
			return GetByFeatureOptionId(transactionManager, _featureOptionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FeatureOption_Customer_Feature_FK key.
		///		FeatureOption_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureOptionId(TransactionManager transactionManager, System.Int32 _featureOptionId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeatureOptionId(transactionManager, _featureOptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FeatureOption_Customer_Feature_FK key.
		///		featureOption_Customer_Feature_Fk Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_featureOptionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureOptionId(System.Int32 _featureOptionId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeatureOptionId(null, _featureOptionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FeatureOption_Customer_Feature_FK key.
		///		featureOption_Customer_Feature_Fk Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_featureOptionId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureOptionId(System.Int32 _featureOptionId, int start, int pageLength,out int count)
		{
			return GetByFeatureOptionId(null, _featureOptionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FeatureOption_Customer_Feature_FK key.
		///		FeatureOption_Customer_Feature_FK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of CONFDB.Entities.Customer_Feature objects.</returns>
		public abstract CONFDB.Entities.TList<Customer_Feature> GetByFeatureOptionId(TransactionManager transactionManager, System.Int32 _featureOptionId, int start, int pageLength, out int count);
		
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override CONFDB.Entities.Customer_Feature Get(TransactionManager transactionManager, CONFDB.Entities.Customer_FeatureKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key Customer_Feature_PK index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.Customer_Feature"/> class.</returns>
		public CONFDB.Entities.Customer_Feature GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Feature_PK index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.Customer_Feature"/> class.</returns>
		public CONFDB.Entities.Customer_Feature GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Feature_PK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.Customer_Feature"/> class.</returns>
		public CONFDB.Entities.Customer_Feature GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Feature_PK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.Customer_Feature"/> class.</returns>
		public CONFDB.Entities.Customer_Feature GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Feature_PK index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.Customer_Feature"/> class.</returns>
		public CONFDB.Entities.Customer_Feature GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the Customer_Feature_PK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.Customer_Feature"/> class.</returns>
		public abstract CONFDB.Entities.Customer_Feature GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_Customer_Feature_All index.
		/// </summary>
		/// <param name="_featureId"></param>
		/// <param name="_customerId"></param>
		/// <param name="_featureOptionId"></param>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureIdCustomerIdFeatureOptionId(System.Int32 _featureId, System.Int32 _customerId, System.Int32 _featureOptionId)
		{
			int count = -1;
			return GetByFeatureIdCustomerIdFeatureOptionId(null,_featureId, _customerId, _featureOptionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_All index.
		/// </summary>
		/// <param name="_featureId"></param>
		/// <param name="_customerId"></param>
		/// <param name="_featureOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureIdCustomerIdFeatureOptionId(System.Int32 _featureId, System.Int32 _customerId, System.Int32 _featureOptionId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeatureIdCustomerIdFeatureOptionId(null, _featureId, _customerId, _featureOptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_All index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureId"></param>
		/// <param name="_customerId"></param>
		/// <param name="_featureOptionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureIdCustomerIdFeatureOptionId(TransactionManager transactionManager, System.Int32 _featureId, System.Int32 _customerId, System.Int32 _featureOptionId)
		{
			int count = -1;
			return GetByFeatureIdCustomerIdFeatureOptionId(transactionManager, _featureId, _customerId, _featureOptionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_All index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureId"></param>
		/// <param name="_customerId"></param>
		/// <param name="_featureOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureIdCustomerIdFeatureOptionId(TransactionManager transactionManager, System.Int32 _featureId, System.Int32 _customerId, System.Int32 _featureOptionId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeatureIdCustomerIdFeatureOptionId(transactionManager, _featureId, _customerId, _featureOptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_All index.
		/// </summary>
		/// <param name="_featureId"></param>
		/// <param name="_customerId"></param>
		/// <param name="_featureOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByFeatureIdCustomerIdFeatureOptionId(System.Int32 _featureId, System.Int32 _customerId, System.Int32 _featureOptionId, int start, int pageLength, out int count)
		{
			return GetByFeatureIdCustomerIdFeatureOptionId(null, _featureId, _customerId, _featureOptionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_All index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_featureId"></param>
		/// <param name="_customerId"></param>
		/// <param name="_featureOptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public abstract CONFDB.Entities.TList<Customer_Feature> GetByFeatureIdCustomerIdFeatureOptionId(TransactionManager transactionManager, System.Int32 _featureId, System.Int32 _customerId, System.Int32 _featureOptionId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_Customer_Feature_CustomerIDFeatureID index.
		/// </summary>
		/// <param name="_customerId"></param>
		/// <param name="_featureId"></param>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerIdFeatureId(System.Int32 _customerId, System.Int32 _featureId)
		{
			int count = -1;
			return GetByCustomerIdFeatureId(null,_customerId, _featureId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_CustomerIDFeatureID index.
		/// </summary>
		/// <param name="_customerId"></param>
		/// <param name="_featureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerIdFeatureId(System.Int32 _customerId, System.Int32 _featureId, int start, int pageLength)
		{
			int count = -1;
			return GetByCustomerIdFeatureId(null, _customerId, _featureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_CustomerIDFeatureID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_customerId"></param>
		/// <param name="_featureId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerIdFeatureId(TransactionManager transactionManager, System.Int32 _customerId, System.Int32 _featureId)
		{
			int count = -1;
			return GetByCustomerIdFeatureId(transactionManager, _customerId, _featureId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_CustomerIDFeatureID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_customerId"></param>
		/// <param name="_featureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerIdFeatureId(TransactionManager transactionManager, System.Int32 _customerId, System.Int32 _featureId, int start, int pageLength)
		{
			int count = -1;
			return GetByCustomerIdFeatureId(transactionManager, _customerId, _featureId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_CustomerIDFeatureID index.
		/// </summary>
		/// <param name="_customerId"></param>
		/// <param name="_featureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public CONFDB.Entities.TList<Customer_Feature> GetByCustomerIdFeatureId(System.Int32 _customerId, System.Int32 _featureId, int start, int pageLength, out int count)
		{
			return GetByCustomerIdFeatureId(null, _customerId, _featureId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Customer_Feature_CustomerIDFeatureID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_customerId"></param>
		/// <param name="_featureId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/> class.</returns>
		public abstract CONFDB.Entities.TList<Customer_Feature> GetByCustomerIdFeatureId(TransactionManager transactionManager, System.Int32 _customerId, System.Int32 _featureId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a CONFDB.Entities.TList&lt;Customer_Feature&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="CONFDB.Entities.TList&lt;Customer_Feature&gt;"/></returns>
		public static CONFDB.Entities.TList<Customer_Feature> Fill(IDataReader reader, CONFDB.Entities.TList<Customer_Feature> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				CONFDB.Entities.Customer_Feature c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Customer_Feature")
					.Append("|").Append((reader.IsDBNull(((int)CONFDB.Entities.Customer_FeatureColumn.Id - 1))?(int)0:(System.Int32)reader[((int)CONFDB.Entities.Customer_FeatureColumn.Id - 1)]).ToString()).ToString();
					c = EntityManager.LocateOrCreate<Customer_Feature>(
					key.ToString(), // EntityTrackingKey
					"Customer_Feature",  //Creational Type
					currentProvider.EntityCreationalFactoryType,  //Factory used to create entity
					currentProvider.EnableEntityTracking); // Track this entity?
				}
				else
				{
					c = new CONFDB.Entities.Customer_Feature();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && (c.EntityState == EntityState.Unchanged || c.EntityState == EntityState.Changed))
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.Id = (System.Int32)reader[((int)Customer_FeatureColumn.Id - 1)];
					c.CustomerId = (System.Int32)reader[((int)Customer_FeatureColumn.CustomerId - 1)];
					c.FeatureId = (System.Int32)reader[((int)Customer_FeatureColumn.FeatureId - 1)];
					c.FeatureOptionId = (System.Int32)reader[((int)Customer_FeatureColumn.FeatureOptionId - 1)];
					c.Enabled = (System.Boolean)reader[((int)Customer_FeatureColumn.Enabled - 1)];
					c.FeatureOptionValue = (reader.IsDBNull(((int)Customer_FeatureColumn.FeatureOptionValue - 1)))?null:(System.String)reader[((int)Customer_FeatureColumn.FeatureOptionValue - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="CONFDB.Entities.Customer_Feature"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="CONFDB.Entities.Customer_Feature"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, CONFDB.Entities.Customer_Feature entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[((int)Customer_FeatureColumn.Id - 1)];
			entity.CustomerId = (System.Int32)reader[((int)Customer_FeatureColumn.CustomerId - 1)];
			entity.FeatureId = (System.Int32)reader[((int)Customer_FeatureColumn.FeatureId - 1)];
			entity.FeatureOptionId = (System.Int32)reader[((int)Customer_FeatureColumn.FeatureOptionId - 1)];
			entity.Enabled = (System.Boolean)reader[((int)Customer_FeatureColumn.Enabled - 1)];
			entity.FeatureOptionValue = (reader.IsDBNull(((int)Customer_FeatureColumn.FeatureOptionValue - 1)))?null:(System.String)reader[((int)Customer_FeatureColumn.FeatureOptionValue - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="CONFDB.Entities.Customer_Feature"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="CONFDB.Entities.Customer_Feature"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, CONFDB.Entities.Customer_Feature entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["ID"];
			entity.CustomerId = (System.Int32)dataRow["CustomerID"];
			entity.FeatureId = (System.Int32)dataRow["FeatureID"];
			entity.FeatureOptionId = (System.Int32)dataRow["FeatureOptionID"];
			entity.Enabled = (System.Boolean)dataRow["Enabled"];
			entity.FeatureOptionValue = Convert.IsDBNull(dataRow["FeatureOptionValue"]) ? null : (System.String)dataRow["FeatureOptionValue"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="CONFDB.Entities.Customer_Feature"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">CONFDB.Entities.Customer_Feature Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		internal override void DeepLoad(TransactionManager transactionManager, CONFDB.Entities.Customer_Feature entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CustomerIdSource	
			if (CanDeepLoad(entity, "Customer|CustomerIdSource", deepLoadType, innerList) 
				&& entity.CustomerIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CustomerId;
				Customer tmpEntity = EntityManager.LocateEntity<Customer>(EntityLocator.ConstructKeyFromPkItems(typeof(Customer), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CustomerIdSource = tmpEntity;
				else
					entity.CustomerIdSource = DataRepository.CustomerProvider.GetById(transactionManager, entity.CustomerId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CustomerIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CustomerIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CustomerProvider.DeepLoad(transactionManager, entity.CustomerIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CustomerIdSource

			#region FeatureIdSource	
			if (CanDeepLoad(entity, "Feature|FeatureIdSource", deepLoadType, innerList) 
				&& entity.FeatureIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeatureId;
				Feature tmpEntity = EntityManager.LocateEntity<Feature>(EntityLocator.ConstructKeyFromPkItems(typeof(Feature), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeatureIdSource = tmpEntity;
				else
					entity.FeatureIdSource = DataRepository.FeatureProvider.GetById(transactionManager, entity.FeatureId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeatureIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeatureIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeatureProvider.DeepLoad(transactionManager, entity.FeatureIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeatureIdSource

			#region FeatureOptionIdSource	
			if (CanDeepLoad(entity, "FeatureOption|FeatureOptionIdSource", deepLoadType, innerList) 
				&& entity.FeatureOptionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeatureOptionId;
				FeatureOption tmpEntity = EntityManager.LocateEntity<FeatureOption>(EntityLocator.ConstructKeyFromPkItems(typeof(FeatureOption), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeatureOptionIdSource = tmpEntity;
				else
					entity.FeatureOptionIdSource = DataRepository.FeatureOptionProvider.GetById(transactionManager, entity.FeatureOptionId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeatureOptionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeatureOptionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeatureOptionProvider.DeepLoad(transactionManager, entity.FeatureOptionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeatureOptionIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the CONFDB.Entities.Customer_Feature object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">CONFDB.Entities.Customer_Feature instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">CONFDB.Entities.Customer_Feature Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		internal override bool DeepSave(TransactionManager transactionManager, CONFDB.Entities.Customer_Feature entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CustomerIdSource
			if (CanDeepSave(entity, "Customer|CustomerIdSource", deepSaveType, innerList) 
				&& entity.CustomerIdSource != null)
			{
				DataRepository.CustomerProvider.Save(transactionManager, entity.CustomerIdSource);
				entity.CustomerId = entity.CustomerIdSource.Id;
			}
			#endregion 
			
			#region FeatureIdSource
			if (CanDeepSave(entity, "Feature|FeatureIdSource", deepSaveType, innerList) 
				&& entity.FeatureIdSource != null)
			{
				DataRepository.FeatureProvider.Save(transactionManager, entity.FeatureIdSource);
				entity.FeatureId = entity.FeatureIdSource.Id;
			}
			#endregion 
			
			#region FeatureOptionIdSource
			if (CanDeepSave(entity, "FeatureOption|FeatureOptionIdSource", deepSaveType, innerList) 
				&& entity.FeatureOptionIdSource != null)
			{
				DataRepository.FeatureOptionProvider.Save(transactionManager, entity.FeatureOptionIdSource);
				entity.FeatureOptionId = entity.FeatureOptionIdSource.Id;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region Customer_FeatureChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>CONFDB.Entities.Customer_Feature</c>
	///</summary>
	public enum Customer_FeatureChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>Customer</c> at CustomerIdSource
		///</summary>
		[ChildEntityType(typeof(Customer))]
		Customer,
			
		///<summary>
		/// Composite Property for <c>Feature</c> at FeatureIdSource
		///</summary>
		[ChildEntityType(typeof(Feature))]
		Feature,
			
		///<summary>
		/// Composite Property for <c>FeatureOption</c> at FeatureOptionIdSource
		///</summary>
		[ChildEntityType(typeof(FeatureOption))]
		FeatureOption,
		}
	
	#endregion Customer_FeatureChildEntityTypes
	
	#region Customer_FeatureFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;Customer_FeatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Customer_Feature"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class Customer_FeatureFilterBuilder : SqlFilterBuilder<Customer_FeatureColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Customer_FeatureFilterBuilder class.
		/// </summary>
		public Customer_FeatureFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the Customer_FeatureFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public Customer_FeatureFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the Customer_FeatureFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public Customer_FeatureFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion Customer_FeatureFilterBuilder
	
	#region Customer_FeatureParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;Customer_FeatureColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Customer_Feature"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class Customer_FeatureParameterBuilder : ParameterizedSqlFilterBuilder<Customer_FeatureColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Customer_FeatureParameterBuilder class.
		/// </summary>
		public Customer_FeatureParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the Customer_FeatureParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public Customer_FeatureParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the Customer_FeatureParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public Customer_FeatureParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion Customer_FeatureParameterBuilder
} // end namespace
