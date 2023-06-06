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

public partial class ExtensionTypeCategoryEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "ExtensionTypeCategoryEdit.aspx?{0}", ExtensionTypeCategoryDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "ExtensionTypeCategoryEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "ExtensionTypeCategory.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewExtensionType_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewExtensionType.SelectedDataKey.Values[0]);
		Response.Redirect("ExtensionTypeEdit.aspx?" + urlParams, true);		
	}	
}


