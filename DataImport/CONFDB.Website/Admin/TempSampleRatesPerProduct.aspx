﻿
<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="TempSampleRatesPerProduct.aspx.cs" Inherits="TempSampleRatesPerProduct" Title="TempSampleRatesPerProduct List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Temp Sample Rates Per Product List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<asp:UpdatePanel ID="UpdatePanel1" runat="server">
	<ContentTemplate>
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="TempSampleRatesPerProductDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_TempSampleRatesPerProduct.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DateInterval" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Date Interval" SortExpression="[DateInterval]"  />
				<asp:BoundField DataField="NumberOfPorts" HeaderText="Number Of Ports" SortExpression="[NumberOfPorts]"  />
				<asp:BoundField DataField="AccessType" HeaderText="Access Type" SortExpression="[AccessType]"  />
				<asp:BoundField DataField="WholesalerId" HeaderText="Wholesaler Id" SortExpression="[WholesalerID]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No TempSampleRatesPerProduct Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnTempSampleRatesPerProduct" OnClientClick="javascript:location.href='TempSampleRatesPerProductEdit.aspx'; return false;" Text="Add New"></asp:Button>
	</ContentTemplate>
	</asp:UpdatePanel>	
		<data:TempSampleRatesPerProductDataSource ID="TempSampleRatesPerProductDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
		>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:TempSampleRatesPerProductDataSource>
	    		
</asp:Content>



