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
	/// An component type implementation of the 'Vertical' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class VerticalService : CONFDB.Services.VerticalServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the VerticalService class.
		/// </summary>
		public VerticalService() : base()
		{
		}
		
	}//End Class


} // end namespace
