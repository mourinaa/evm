﻿#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using CONFDB.Entities;
using CONFDB.Data;

#endregion

namespace CONFDB.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="PromptSetProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PromptSetProviderBase : PromptSetProviderBaseCore
	{
	} // end class
} // end namespace
