﻿
#region Imports...
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CONFDB.Web.UI;
#endregion

public partial class BridgeTypeEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "BridgeTypeEdit.aspx?{0}", BridgeTypeDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "BridgeTypeEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "BridgeType.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewBridge_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewBridge.SelectedDataKey.Values[0]);
		Response.Redirect("BridgeEdit.aspx?" + urlParams, true);		
	}	
}


