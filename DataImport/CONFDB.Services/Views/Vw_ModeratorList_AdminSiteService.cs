﻿
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using CONFDB.Entities;
using CONFDB.Entities.Validation;

using CONFDB.Data;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace CONFDB.Services
{		
	
	///<summary>
	/// An component type implementation of the 'vw_ModeratorList_AdminSite' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class Vw_ModeratorList_AdminSiteService : CONFDB.Services.Vw_ModeratorList_AdminSiteServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the Vw_ModeratorList_AdminSiteService class.
		/// </summary>
		public Vw_ModeratorList_AdminSiteService() : base()
		{
		}
		
	}//End Class


} // end namespace