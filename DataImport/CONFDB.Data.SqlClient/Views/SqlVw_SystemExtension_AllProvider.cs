﻿#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using CONFDB.Entities;
using CONFDB.Data;

#endregion

namespace CONFDB.Data.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="Vw_SystemExtension_All"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlVw_SystemExtension_AllProvider: SqlVw_SystemExtension_AllProviderBase
	{		
		/// <summary>
		/// Creates a new <see cref="SqlVw_SystemExtension_AllProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlVw_SystemExtension_AllProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
	}
}