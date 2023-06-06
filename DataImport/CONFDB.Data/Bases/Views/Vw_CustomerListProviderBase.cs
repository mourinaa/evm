﻿#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CONFDB.Entities;
using CONFDB.Data;

#endregion

namespace CONFDB.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="Vw_CustomerListProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class Vw_CustomerListProviderBase : Vw_CustomerListProviderBaseCore
	{
	} // end class
} // end namespace
