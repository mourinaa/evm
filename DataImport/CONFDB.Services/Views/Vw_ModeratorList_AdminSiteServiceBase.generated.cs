﻿
/*
	File generated by NetTiers templates [www.NetTiers.com]
	Important: Do not modify this file. Edit the file Vw_ModeratorList_AdminSite.cs instead.
*/

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Security;
using System.Data;

using CONFDB.Entities;
using CONFDB.Entities.Validation;
using Entities = CONFDB.Entities;
using CONFDB.Data;
using CONFDB.Data.Bases;


using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion 

namespace CONFDB.Services
{		
	
	///<summary>
	/// An object representation of the 'vw_ModeratorList_AdminSite' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the Vw_ModeratorList_AdminSite.cs file instead.
	/// All custom implementations should be done in the <see cref="Vw_ModeratorList_AdminSite"/> class.
	/// </remarks>
	[DataObject]
	public partial class Vw_ModeratorList_AdminSiteServiceBase : ServiceViewBase<Vw_ModeratorList_AdminSite>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="Vw_ModeratorList_AdminSite"/> instance .
		///</summary>
		public Vw_ModeratorList_AdminSiteServiceBase() : base()
		{
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="Vw_ModeratorList_AdminSite"/> instance.
		///</summary>
		///<param name="_userId"></param>
		///<param name="_companyName"></param>
		///<param name="_adminName"></param>
		///<param name="_webLoginName"></param>
		///<param name="_webLoginPassword"></param>
		///<param name="_moderatorName"></param>
		///<param name="_email"></param>
		///<param name="_address1"></param>
		///<param name="_address2"></param>
		///<param name="_city"></param>
		///<param name="_country"></param>
		///<param name="_region"></param>
		///<param name="_postalCode"></param>
		///<param name="_telephone"></param>
		///<param name="_roleId"></param>
		///<param name="_charityId"></param>
		///<param name="_charityName"></param>
		///<param name="_salesPerson"></param>
		///<param name="_salesPersonId"></param>
		///<param name="_wholesalerId"></param>
		///<param name="_customerId"></param>
		///<param name="_accountManagerId"></param>
		///<param name="_accountManager"></param>
		///<param name="_dateProvisioned"></param>
		public static Vw_ModeratorList_AdminSite CreateVw_ModeratorList_AdminSite(System.Int32 _userId, System.String _companyName, System.String _adminName, System.String _webLoginName, System.String _webLoginPassword, System.String _moderatorName, System.String _email, System.String _address1, System.String _address2, System.String _city, System.String _country, System.String _region, System.String _postalCode, System.String _telephone, System.Int32? _roleId, System.Int32? _charityId, System.String _charityName, System.String _salesPerson, System.Int32 _salesPersonId, System.String _wholesalerId, System.Int32 _customerId, System.Int32 _accountManagerId, System.String _accountManager, System.DateTime _dateProvisioned)
		{
			Vw_ModeratorList_AdminSite newEntityVw_ModeratorList_AdminSite = new Vw_ModeratorList_AdminSite();
			newEntityVw_ModeratorList_AdminSite.UserId  = _userId;
			newEntityVw_ModeratorList_AdminSite.CompanyName  = _companyName;
			newEntityVw_ModeratorList_AdminSite.AdminName  = _adminName;
			newEntityVw_ModeratorList_AdminSite.WebLoginName  = _webLoginName;
			newEntityVw_ModeratorList_AdminSite.WebLoginPassword  = _webLoginPassword;
			newEntityVw_ModeratorList_AdminSite.ModeratorName  = _moderatorName;
			newEntityVw_ModeratorList_AdminSite.Email  = _email;
			newEntityVw_ModeratorList_AdminSite.Address1  = _address1;
			newEntityVw_ModeratorList_AdminSite.Address2  = _address2;
			newEntityVw_ModeratorList_AdminSite.City  = _city;
			newEntityVw_ModeratorList_AdminSite.Country  = _country;
			newEntityVw_ModeratorList_AdminSite.Region  = _region;
			newEntityVw_ModeratorList_AdminSite.PostalCode  = _postalCode;
			newEntityVw_ModeratorList_AdminSite.Telephone  = _telephone;
			newEntityVw_ModeratorList_AdminSite.RoleId  = _roleId;
			newEntityVw_ModeratorList_AdminSite.CharityId  = _charityId;
			newEntityVw_ModeratorList_AdminSite.CharityName  = _charityName;
			newEntityVw_ModeratorList_AdminSite.SalesPerson  = _salesPerson;
			newEntityVw_ModeratorList_AdminSite.SalesPersonId  = _salesPersonId;
			newEntityVw_ModeratorList_AdminSite.WholesalerId  = _wholesalerId;
			newEntityVw_ModeratorList_AdminSite.CustomerId  = _customerId;
			newEntityVw_ModeratorList_AdminSite.AccountManagerId  = _accountManagerId;
			newEntityVw_ModeratorList_AdminSite.AccountManager  = _accountManager;
			newEntityVw_ModeratorList_AdminSite.DateProvisioned  = _dateProvisioned;
			return newEntityVw_ModeratorList_AdminSite;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<Vw_ModeratorList_AdminSite> securityContext = new SecurityContext<Vw_ModeratorList_AdminSite>();
		private static readonly string layerExceptionPolicy = "NoneExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		private static readonly int defaultMaxRecords = 10000;
		#endregion 
		
		#region Data Access Methods
			
		#region Get 
		/// <summary>
		/// Attempts to do a parameterized version of a simple whereclause. 
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection of Entity objects.</returns>
		public override VList<Vw_ModeratorList_AdminSite> Get(string whereClause, string orderBy)
		{
			int totalCount = -1;
			return Get(whereClause, orderBy, 0, defaultMaxRecords, out totalCount);
		}

		/// <summary>
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter to get total records for query</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection TList{Vw_ModeratorList_AdminSite} of <c>Vw_ModeratorList_AdminSite</c> objects.</returns>
		public override VList<Vw_ModeratorList_AdminSite> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");
								
			// get this data
			VList<Vw_ModeratorList_AdminSite> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.Vw_ModeratorList_AdminSiteProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
				//if borrowed tran, leave open for next call
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;
		}
		
		#endregion Get Methods
		
		#region GetAll
		/// <summary>
		/// Get a complete collection of <see cref="Vw_ModeratorList_AdminSite" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<Vw_ModeratorList_AdminSite> GetAll() 
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}

       
		/// <summary>
		/// Get a set portion of a complete list of <see cref="Vw_ModeratorList_AdminSite" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{Vw_ModeratorList_AdminSite}"/> </returns>
		public override VList<Vw_ModeratorList_AdminSite> GetAll(int start, int pageLength, out int totalCount) 
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");
			
			// get this data
			VList<Vw_ModeratorList_AdminSite> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;					

				//Access repository
				list = dataProvider.Vw_ModeratorList_AdminSiteProvider.GetAll(transactionManager, start, pageLength, out totalCount);	
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;
		}
		#endregion GetAll

		#region GetPaged
		/// <summary>
		/// Gets a page of <see cref="TList{Vw_ModeratorList_AdminSite}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>Vw_ModeratorList_AdminSite</c> objects.</returns>
		public virtual VList<Vw_ModeratorList_AdminSite> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}
		
		/// <summary>
		/// Gets a page of <see cref="TList{Vw_ModeratorList_AdminSite}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>Vw_ModeratorList_AdminSite</c> objects.</returns>
		public virtual VList<Vw_ModeratorList_AdminSite> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{Vw_ModeratorList_AdminSite}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>Vw_ModeratorList_AdminSite</c> objects.</returns>
		public override VList<Vw_ModeratorList_AdminSite> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");
			
			// get this data
			VList<Vw_ModeratorList_AdminSite> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null; 

			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.Vw_ModeratorList_AdminSiteProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);
				
				//if borrowed tran, leave open for next call
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			return list;			
		}
		
		/// <summary>
		/// Gets the number of rows in the DataSource that match the specified whereClause.
		/// This method is only provided as a workaround for the ObjectDataSource's need to 
		/// execute another method to discover the total count instead of using another param, like our out param.  
		/// This method should be avoided if using the ObjectDataSource or another method.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <returns>Returns the number of rows.</returns>
		public int GetTotalItems(string whereClause, out int totalCount)
		{
			GetPaged(whereClause, null, 0, defaultMaxRecords, out totalCount);
			return totalCount;
		}
		#endregion GetPaged	

		#region Find Methods

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <returns>Returns a typed collection of <c>Vw_ModeratorList_AdminSite</c> objects.</returns>
		public virtual VList<Vw_ModeratorList_AdminSite> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>Vw_ModeratorList_AdminSite</c> objects.</returns>
		public virtual VList<Vw_ModeratorList_AdminSite> Find(IFilterParameterCollection parameters, string orderBy)
		{
			int count = 0;
			return Find(parameters, orderBy, 0, defaultMaxRecords, out count);
		}
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of <c>Vw_ModeratorList_AdminSite</c> objects.</returns>
		public override VList<Vw_ModeratorList_AdminSite> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");
								
			// get this data
			TransactionManager transactionManager = null; 
			VList<Vw_ModeratorList_AdminSite> list = null;
			count = -1;
			
			try
            {	
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;
					
				//Access repository
				list = dataProvider.Vw_ModeratorList_AdminSiteProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen) 
					transactionManager.Rollback();
				
				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy)) 
					throw;
			}
			
			return list;
		}
		
		#endregion Find Methods
		
		#region Custom Methods
		#endregion
		
		#endregion Data Access Methods
		
	
	}//End Class
} // end namespace


