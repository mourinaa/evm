using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Configuration;
/// <summary>
/// Summary description for CallSummaryForCustomer2
/// </summary>
public class CallSummaryForCustomer2 : DevExpress.XtraReports.UI.XtraReport
{
 
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private dsCallSummaryForCustomer dsCallSummaryForCustomer1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell14;
    private PageFooterBand PageFooter;
    private XRPageInfo xrPageInfo2;
    private XRPageInfo xrPageInfo1;
    private PageHeaderBand PageHeader;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell13;
    private XRControlStyle Title;
    private XRControlStyle FieldCaption;
    private XRControlStyle PageInfo;
    private XRControlStyle DataField;
    private ReportHeaderBand reportHeaderBand1;
    private XRLabel xrLabel1;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

    private int customerID;
    public int CustomerID
    {
        get { return customerID; }
        set { customerID = value; }
    }

    private DateTime startTime;
    public DateTime StartTime
    {
        get { return startTime; }
        set { startTime = value; }
    }

    private DateTime endTime;
    public DateTime EndTime
    {
        get { return endTime; }
        set { endTime = value; }
    }

    private string refNumber;

    public string RefNumber
    {
        get { return refNumber; }
        set { refNumber = value; }
    }

    private string meetingName;
    public string MeetingName
    {
        get { return meetingName; }
        set { meetingName = value; }
    }

    private int selectUserID;
    private DataSetCDRDetailsForCustomerTableAdapters.p_RatedCDR_GetCallDetailsForCustomerTableAdapter p_RatedCDR_GetCallDetailsForCustomerTableAdapter1;
    private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
    private System.Data.SqlClient.SqlConnection sqlConnection1;
    private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;

    public int SelectedUserID
    {
        get { return selectUserID; }
        set { selectUserID = value; }
    }

    private int departmentID;

    public int DepartmentID
    {
        get { return departmentID; }
        set { departmentID = value; }
    }

	public CallSummaryForCustomer2()
	{
	}

    public int BindData()
    {
        //
        // TODO: Add constructor logic here
        //
        InitializeComponent();

        this.sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["CONFDBConnectionString"].ToString();

        sqlDataAdapter1.SelectCommand.Parameters["@CustomerID"].Value = CustomerID;
        sqlDataAdapter1.SelectCommand.Parameters["@StartTime"].Value = startTime;
        sqlDataAdapter1.SelectCommand.Parameters["@EndTime"].Value = endTime;
        sqlDataAdapter1.SelectCommand.Parameters["@DepartmentID"].Value = departmentID;
        sqlDataAdapter1.SelectCommand.Parameters["@UserID"].Value = selectUserID;
        sqlDataAdapter1.SelectCommand.Parameters["@ReferenceNumber"].Value = refNumber;
        sqlDataAdapter1.SelectCommand.Parameters["@MeetingName"].Value = meetingName;

        dsCallSummaryForCustomer ds = new dsCallSummaryForCustomer();
        ds.EnforceConstraints = false;
        sqlDataAdapter1.Fill(ds);
        this.DataSource = ds.Tables[0];

        return ds.Tables[0].Rows.Count;

    }


	
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
        string resourceFileName = "CallSummaryForCustomer2.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.dsCallSummaryForCustomer1 = new dsCallSummaryForCustomer();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
        this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
        this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
        this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
        this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
        this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.p_RatedCDR_GetCallDetailsForCustomerTableAdapter1 = new DataSetCDRDetailsForCustomerTableAdapters.p_RatedCDR_GetCallDetailsForCustomerTableAdapter();
        this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
        this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
        this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dsCallSummaryForCustomer1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
        this.Detail.Height = 18;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable2
        // 
        this.xrTable2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
        this.xrTable2.Location = new System.Drawing.Point(6, 0);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.Size = new System.Drawing.Size(637, 18);
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell6,
            this.xrTableCell8,
            this.xrTableCell10,
            this.xrTableCell12,
            this.xrTableCell14});
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Size = new System.Drawing.Size(637, 18);
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.CanGrow = false;
        this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MeetingDate", "{0:dd/MM/yyyy}")});
        this.xrTableCell2.Location = new System.Drawing.Point(0, 0);
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell2.Size = new System.Drawing.Size(69, 18);
        this.xrTableCell2.StyleName = "DataField";
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.CanGrow = false;
        this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ConfStartTime", "{0:HH:mm:ss}")});
        this.xrTableCell4.Location = new System.Drawing.Point(69, 0);
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell4.Size = new System.Drawing.Size(82, 18);
        this.xrTableCell4.StyleName = "DataField";
        this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.CanGrow = false;
        this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ProductTypeDisplayName", "")});
        this.xrTableCell6.Location = new System.Drawing.Point(151, 0);
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell6.Size = new System.Drawing.Size(143, 18);
        this.xrTableCell6.StyleName = "DataField";
        this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.CanGrow = false;
        this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "UserDisplayName", "")});
        this.xrTableCell8.Location = new System.Drawing.Point(294, 0);
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell8.Size = new System.Drawing.Size(98, 18);
        this.xrTableCell8.StyleName = "DataField";
        this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.CanGrow = false;
        this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ModeratorName", "")});
        this.xrTableCell10.Location = new System.Drawing.Point(392, 0);
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell10.Size = new System.Drawing.Size(86, 18);
        this.xrTableCell10.StyleName = "DataField";
        this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.CanGrow = false;
        this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ReferenceNumber", "")});
        this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Underline);
        this.xrTableCell12.Location = new System.Drawing.Point(478, 0);
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell12.Size = new System.Drawing.Size(97, 18);
        this.xrTableCell12.StyleName = "DataField";
        this.xrTableCell12.StylePriority.UseFont = false;
        this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableCell12.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell12_BeforePrint);
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.CanGrow = false;
        this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "RetailTotal", "{0:$0.00}")});
        this.xrTableCell14.Location = new System.Drawing.Point(575, 0);
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell14.Size = new System.Drawing.Size(62, 18);
        this.xrTableCell14.StyleName = "DataField";
        this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        // 
        // dsCallSummaryForCustomer1
        // 
        this.dsCallSummaryForCustomer1.DataSetName = "dsCallSummaryForCustomer";
        this.dsCallSummaryForCustomer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
        this.PageFooter.Height = 29;
        this.PageFooter.Name = "PageFooter";
        this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrPageInfo2
        // 
        this.xrPageInfo2.Format = "Page {0} of {1}";
        this.xrPageInfo2.Location = new System.Drawing.Point(331, 6);
        this.xrPageInfo2.Name = "xrPageInfo2";
        this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrPageInfo2.Size = new System.Drawing.Size(313, 23);
        this.xrPageInfo2.StyleName = "PageInfo";
        this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        // 
        // xrPageInfo1
        // 
        this.xrPageInfo1.Location = new System.Drawing.Point(6, 6);
        this.xrPageInfo1.Name = "xrPageInfo1";
        this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
        this.xrPageInfo1.Size = new System.Drawing.Size(313, 23);
        this.xrPageInfo1.StyleName = "PageInfo";
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.PageHeader.Height = 36;
        this.PageHeader.Name = "PageHeader";
        this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable1
        // 
        this.xrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
        this.xrTable1.Location = new System.Drawing.Point(6, 0);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.Size = new System.Drawing.Size(637, 36);
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell3,
            this.xrTableCell5,
            this.xrTableCell7,
            this.xrTableCell9,
            this.xrTableCell11,
            this.xrTableCell13});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Size = new System.Drawing.Size(637, 36);
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.CanGrow = false;
        this.xrTableCell1.Location = new System.Drawing.Point(0, 0);
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell1.Size = new System.Drawing.Size(69, 36);
        this.xrTableCell1.StyleName = "FieldCaption";
        this.xrTableCell1.Text = "Meeting Date";
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.CanGrow = false;
        this.xrTableCell3.Location = new System.Drawing.Point(69, 0);
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell3.Size = new System.Drawing.Size(82, 36);
        this.xrTableCell3.StyleName = "FieldCaption";
        this.xrTableCell3.Text = "Time Started";
        this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.CanGrow = false;
        this.xrTableCell5.Location = new System.Drawing.Point(151, 0);
        this.xrTableCell5.Multiline = true;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell5.Size = new System.Drawing.Size(143, 36);
        this.xrTableCell5.StyleName = "FieldCaption";
        this.xrTableCell5.Text = "ConferenceType\r\n";
        this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.CanGrow = false;
        this.xrTableCell7.Location = new System.Drawing.Point(294, 0);
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell7.Size = new System.Drawing.Size(98, 36);
        this.xrTableCell7.StyleName = "FieldCaption";
        this.xrTableCell7.Text = "Moderator Name";
        this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.CanGrow = false;
        this.xrTableCell9.Location = new System.Drawing.Point(392, 0);
        this.xrTableCell9.Multiline = true;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell9.Size = new System.Drawing.Size(86, 36);
        this.xrTableCell9.StyleName = "FieldCaption";
        this.xrTableCell9.Text = "ConferenceName";
        this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.CanGrow = false;
        this.xrTableCell11.Location = new System.Drawing.Point(478, 0);
        this.xrTableCell11.Multiline = true;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell11.Size = new System.Drawing.Size(97, 36);
        this.xrTableCell11.StyleName = "FieldCaption";
        this.xrTableCell11.Text = "Cost\r\nCode";
        this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.CanGrow = false;
        this.xrTableCell13.Location = new System.Drawing.Point(575, 0);
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrTableCell13.Size = new System.Drawing.Size(62, 36);
        this.xrTableCell13.StyleName = "FieldCaption";
        this.xrTableCell13.Text = "Cost";
        this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // Title
        // 
        this.Title.BackColor = System.Drawing.Color.White;
        this.Title.BorderColor = System.Drawing.SystemColors.ControlText;
        this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.Title.BorderWidth = 1;
        this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
        this.Title.ForeColor = System.Drawing.Color.Maroon;
        this.Title.Name = "Title";
        // 
        // FieldCaption
        // 
        this.FieldCaption.BackColor = System.Drawing.Color.White;
        this.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText;
        this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
        this.FieldCaption.BorderWidth = 1;
        this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
        this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
        this.FieldCaption.Name = "FieldCaption";
        // 
        // PageInfo
        // 
        this.PageInfo.BackColor = System.Drawing.Color.White;
        this.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText;
        this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.PageInfo.BorderWidth = 1;
        this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.PageInfo.ForeColor = System.Drawing.SystemColors.ControlText;
        this.PageInfo.Name = "PageInfo";
        // 
        // DataField
        // 
        this.DataField.BackColor = System.Drawing.Color.White;
        this.DataField.BorderColor = System.Drawing.SystemColors.ControlText;
        this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.DataField.BorderWidth = 1;
        this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.DataField.ForeColor = System.Drawing.SystemColors.ControlText;
        this.DataField.Name = "DataField";
        // 
        // reportHeaderBand1
        // 
        this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.reportHeaderBand1.Height = 51;
        this.reportHeaderBand1.Name = "reportHeaderBand1";
        // 
        // xrLabel1
        // 
        this.xrLabel1.Location = new System.Drawing.Point(6, 6);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.Size = new System.Drawing.Size(638, 33);
        this.xrLabel1.StyleName = "Title";
        this.xrLabel1.Text = "Summary By Date and Time";
        // 
        // p_RatedCDR_GetCallDetailsForCustomerTableAdapter1
        // 
        this.p_RatedCDR_GetCallDetailsForCustomerTableAdapter1.ClearBeforeFill = true;
        // 
        // sqlSelectCommand1
        // 
        this.sqlSelectCommand1.CommandText = "dbo.p_RatedCDR_GetCallSummaryForCustomer";
        this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
        this.sqlSelectCommand1.Connection = this.sqlConnection1;
        this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@StartTime", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@EndTime", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@DepartmentID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@UserID", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@ReferenceNumber", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@MeetingName", System.Data.SqlDbType.VarChar, 100)});
        // 
        // sqlConnection1
        // 
        this.sqlConnection1.ConnectionString = "Data Source=DEV;Initial Catalog=CONFDB;Integrated Security=True";
        this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
        // 
        // sqlDataAdapter1
        // 
        this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
        this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "p_RatedCDR_GetCallSummaryForCustomer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("UniqueConferenceID", "UniqueConferenceID"),
                        new System.Data.Common.DataColumnMapping("MeetingDate", "MeetingDate"),
                        new System.Data.Common.DataColumnMapping("ConfStartTime", "ConfStartTime"),
                        new System.Data.Common.DataColumnMapping("UserDisplayName", "UserDisplayName"),
                        new System.Data.Common.DataColumnMapping("ModeratorName", "ModeratorName"),
                        new System.Data.Common.DataColumnMapping("ReferenceNumber", "ReferenceNumber"),
                        new System.Data.Common.DataColumnMapping("RetailTotal", "RetailTotal"),
                        new System.Data.Common.DataColumnMapping("ProductTypeDisplayName", "ProductTypeDisplayName")})});
        // 
        // CallSummaryForCustomer2
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageFooter,
            this.PageHeader,
            this.reportHeaderBand1});
        this.DataAdapter = this.sqlDataAdapter1;
        this.DataMember = "p_RatedCDR_GetCallSummaryForCustomer";
        this.DataSource = this.dsCallSummaryForCustomer1;
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
        this.Version = "8.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dsCallSummaryForCustomer1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    private void xrTableCell12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        string curRefNum = xrTableCell12.Text.Trim();

        if (curRefNum == "")
            xrTableCell12.Text = "None";

        //xrTableCell12.NavigateUrl = @"javascript:window.open('changebillingcode.aspx?id=" + this.GetCurrentColumnValue("UniqueConferenceID").ToString()
        //    + @"&refnum=" + curRefNum
        //    + @"','mywindow','toolbar=No,menubar=No,location=No,scrollbars=No,status=No,resizable=No,fullscreen=No,height=200,width=500')";

    }
}
