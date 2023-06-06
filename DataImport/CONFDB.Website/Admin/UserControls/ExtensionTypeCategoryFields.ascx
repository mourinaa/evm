﻿<%@ Control Language="C#" ClassName="ExtensionTypeCategoryFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataId" runat="server" Text="Id:" AssociatedControlID="dataId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataId" Text='<%# Bind("Id") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataId" runat="server" Display="Dynamic" ControlToValidate="dataId" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataId" runat="server" Display="Dynamic" ControlToValidate="dataId" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCategoryName" runat="server" Text="Category Name:" AssociatedControlID="dataCategoryName" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCategoryName" Text='<%# Bind("CategoryName") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataCategoryName" runat="server" Display="Dynamic" ControlToValidate="dataCategoryName" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


