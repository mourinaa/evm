using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using CONFDB.Web.UI;
using CONFDB.Entities;
using CONFDB.Services;
using CONFDB.Data;
using CONFDB.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace DataImport
{
    class Program
    {
        static void Main(string[] args)
        {
            string region = "NSW";
            string postalCode = "2000";
            string WholesalerID = "0000000001";
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\EVM\grp-Copy of ZZZRBAll Active1.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Sheets["Copy of ZZZRBAll Active"];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            Excel.Workbook moderator = xlApp.Workbooks.Open(@"C:\EVM\grp-ZZ2_All Res with Service1.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet modSheet = (Microsoft.Office.Interop.Excel.Worksheet)moderator.Sheets["ZZ2_All Res with Service"];
            Excel.Range modRange = modSheet.UsedRange;
            Console.WriteLine(xlRange);
            Console.WriteLine(modRange);
            int modRow = modRange.Rows.Count;
            int modCol = modRange.Columns.Count;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;


            List<getCompany> getCompanyExcel = new List<getCompany>();
            List<getCustomer> getCustomerList = new List<getCustomer>();
            List<getUser> getUserList = new List<getUser>();
            List<getModCode> modList = new List<getModCode>();
            for (int j = 2; j < modRow; j++)
            {
                Excel.Range typeRange = (xlWorksheet.Cells[j, 4] as Excel.Range);
                string type = "";
                if (typeRange.Value2 != null)
                {
                    type = typeRange.Value2.ToString();
                }
                string customer = "Customer";

                Excel.Range companyRange = (xlWorksheet.Cells[j, 7] as Excel.Range);
                string company = "";
                if (companyRange.Value2 != null)
                {
                    company = companyRange.Value2.ToString();
                }

                string trimCompany = company.TrimEnd();
                if (trimCompany.Length > 100)
                {
                    trimCompany = trimCompany.Substring(0, 100);
                }

                Excel.Range fullNameRange = (xlWorksheet.Cells[j, 14] as Excel.Range);
                string fullName = "";
                if (fullNameRange.Value2 != null)
                {
                    fullName = fullNameRange.Value2.ToString();
                }
                Excel.Range phoneNumberRange = (xlWorksheet.Cells[j, 15] as Excel.Range);
                var phoneNumber = "";
                if (phoneNumberRange.Value2 != null)
                {
                    phoneNumber = phoneNumberRange.Value2.ToString();
                }
                Excel.Range address1Range = (xlWorksheet.Cells[j, 16] as Excel.Range);
                string address1 = "";
                if (address1Range.Value2 != null)
                {
                    address1 = address1Range.Value2.ToString();
                }
                Excel.Range address2Range = (xlWorksheet.Cells[j, 17] as Excel.Range);
                string address2 = "";
                if (address2Range.Value2 != null)
                {
                    address2 = address2Range.Value2.ToString();
                }
                Excel.Range cityRange = (xlWorksheet.Cells[j, 21] as Excel.Range);
                string city = "";
                if (cityRange.Value2 != null)
                {
                    city = cityRange.Value2.ToString();
                }
                Excel.Range countryRange = (xlWorksheet.Cells[j, 22] as Excel.Range);
                string country = "";
                if (countryRange.Value2 != null)
                {
                    var countryService = new CountryService();
                    TList<Country> countryList = countryService.GetAll();

                    string countryName = countryRange.Value2.ToString();
                    string whereClause = "select id from country where description like '%" + countryName + "%'";
                    var findCountry = countryList.Find(x => x.Description.Contains(countryName));
                    country = "AU";
                }
                Excel.Range passwordRange = (xlWorksheet.Cells[j, 25] as Excel.Range);
                string password = "";
                if (passwordRange.Value2 != null)
                {
                    password = passwordRange.Value2.ToString();
                }
                Excel.Range usernameRange = (xlWorksheet.Cells[j, 26] as Excel.Range);
                string username = "";
                if (usernameRange.Value2 != null)
                {
                    username = usernameRange.Value2.ToString();
                }
                Excel.Range emailRange = (xlWorksheet.Cells[j, 27] as Excel.Range);
                string email = "";
                if (emailRange.Value2 != null)
                {
                    email = emailRange.Value2.ToString();
                }

                Excel.Range pcnRange = (xlWorksheet.Cells[j, 28] as Excel.Range);
                string pcn = "";
                if (pcnRange.Value2 != null)
                {
                    pcn = pcnRange.Value2.ToString();
                }

                Excel.Range customerNumberRange = (xlWorksheet.Cells[j, 5] as Excel.Range);
                string priCustomerNumber = "";
                if (customerNumberRange.Value2 != null)
                {
                    priCustomerNumber = customerNumberRange.Value2.ToString();
                }
                Excel.Range customerNumberRangeValue = (modSheet.Cells[j, 1] as Excel.Range);
                string customerNumberValue = "";
                if (customerNumberValue != null)
                {
                    customerNumberValue = customerNumberRangeValue.Value2.ToString();
                }

                Excel.Range modCodeRange = (modSheet.Cells[j, 14] as Excel.Range);
                string modCode = "";
                if (modCodeRange.Value2 != null)
                {
                    modCode = modCodeRange.Value2.ToString();
                }
                Excel.Range passCodeRange = (modSheet.Cells[j, 15] as Excel.Range);
                string passCode = "";
                if (passCodeRange.Value2 != null)
                {
                    passCode = passCodeRange.Value2.ToString();
                }

                Excel.Range descriptionRange = (modSheet.Cells[j, 3] as Excel.Range);
                string description = "";
                if (descriptionRange.Value2 != null)
                {
                    description = descriptionRange.Value2.ToString();
                }
                else
                {
                    Excel.Range modDesc = (modSheet.Cells[j, 2] as Excel.Range);
                    description = modDesc.Value2.ToString();
                }

                Excel.Range companyDescRange = (modSheet.Cells[j, 2] as Excel.Range);
                string companyDesc = "";

                if (companyDescRange.Value2 != null)
                {
                    companyDesc = companyDescRange.Value2.ToString();
                }
                string trimCompanyDesc = companyDesc.TrimEnd();
                if (trimCompanyDesc.Length > 100)
                {
                    trimCompanyDesc = trimCompanyDesc.Substring(0, 100);
                }

                Excel.Range partyActionTimerRange = (modSheet.Cells[j, 7] as Excel.Range);
                string partyActionTimer = "";
                if (partyActionTimerRange.Value2 != null)
                {
                    partyActionTimer = partyActionTimerRange.Value2.ToString();
                }

                Excel.Range alertThresholdRange = (modSheet.Cells[j, 8] as Excel.Range);
                string alertThreshold = "";
                if (alertThresholdRange.Value2 != null)
                {
                    alertThreshold = alertThresholdRange.Value2.ToString();
                }

                Excel.Range alertTimerRange = (modSheet.Cells[j, 9] as Excel.Range);
                string alertTimer = "";
                if (alertTimerRange.Value2 != null)
                {
                    alertTimer = alertTimerRange.Value2.ToString();
                }

                Excel.Range alertAllowResetRange = (modSheet.Cells[j, 10] as Excel.Range);
                string alertAllowReset = "";
                if (alertAllowResetRange.Value2 != null)
                {
                    alertAllowReset = alertAllowResetRange.Value2.ToString();
                }

                modList.Add(new getModCode { customerNumber = customerNumberValue, description = description, modCode = modCode, passCode = passCode, companyDesc = trimCompanyDesc, address1 = address1, address2 = address2, city = city, email = email, fullName = fullName, password = password, phoneNumber = phoneNumber, username = username, country = country });

                var checkCompany = getCompanyExcel.Find(x => x.companyName.Contains(company));
                if (checkCompany == null && company != "")
                {
                    getCompanyExcel.Add(new getCompany { companyName = company });
                }
                if (fullName != "")
                {

                    getCustomerList.Add(new getCustomer { companyName = trimCompany, address1 = address1, address2 = address2, city = city, country = country, email = email, fullName = fullName, phoneNumber = phoneNumber, postalCode = postalCode, region = region, password = password, username = username, priCustomerNumber = priCustomerNumber, pcn = pcn });
                    getUserList.Add(new getUser { companyName = trimCompany, displayName = fullName, email = email, password = password, telephone = phoneNumber, username = username });
                }

            }
            //string companyName = companyNameRange.Value2.ToString();
            var companyService = new CompanyService();
            var companyList = companyService.GetAll();
            var csService = new CustomerService();
            var modService = new ModeratorService();



            foreach (getCompany company in getCompanyExcel)
            {
                insertCompany(company.companyName);
            }

            foreach (getCustomer customer in getCustomerList)
            {
                var checkCompanyId = companyList.Find(x => x.Description.Contains(customer.companyName));

                var isExist = csService.GetByCompanyId(checkCompanyId.Id);
                if (isExist.Count == 0)
                {
                    insertCustomer(WholesalerID, customer.fullName, customer.phoneNumber, customer.address1, customer.address2, customer.email, customer.city, customer.country, customer.region, customer.postalCode, checkCompanyId.Id, customer.username, customer.password, customer.pcn);

                }
            }
            foreach (getModCode moderatorList in modList)
            {
                var checkCustomerNumber = getCustomerList.Find(x => x.priCustomerNumber.Equals(moderatorList.customerNumber));
                if (checkCustomerNumber != null)
                {
                    var customerList = csService.GetAll();
                    var checkCompanyId = companyList.Find(x => x.Description.Contains(checkCustomerNumber.companyName));
                    var checkCustomer = customerList.Find(y => y.CompanyId.Equals(checkCompanyId.Id));
                    var customerId = checkCustomer.Id;
                    var currentPriCustomerNumber = checkCustomer.PriCustomerNumber;
                    var allModerator = modService.GetByCustomerId(8);
                    var testCust = "0000" + allModerator.Count;
                    var secCust = "10" + testCust.Substring(testCust.Length - 4);
                    insertModerator(WholesalerID, moderatorList.modCode, moderatorList.passCode, moderatorList.description, checkCustomer.PriCustomerNumber, moderatorList.username, moderatorList.password, moderatorList.email, moderatorList.fullName, moderatorList.phoneNumber, moderatorList.address1, moderatorList.address2, moderatorList.city, moderatorList.country, postalCode, customerId, secCust);
                }
            }

            //var csService = new CustomerService();
            //var companyService = new CompanyService();
            ////company
            //    Excel.Range featureTest = (modSheet.Cells[1, i] as Excel.Range);
            //    var check = modList.Find(x => x.customerNumber.Contains(priCustomerNumber));

            //    var companyID = insertCompany();
            //    var companyList = companyService.GetAll();
            //    var checkCompanyId = companyList.Find(x => x.Description.Contains(check.companyDesc));

            //    var isExist = csService.GetByCompanyId(companyID);
            //    if (isExist.Count == 0)
            //    {
            //        insertCustomer(WholesalerID, priCustomerNumber, fullName, phoneNumber, address1, address2, email, city, country, region, postalCode, companyID, username, password);
            //    }
            //    //moderator
            //    if (check.companyDesc.Contains(checkCompanyId.Description))
            //    {
            //        var customerList = csService.GetAll();
            //        var checkCustomer = customerList.Find(y => y.CompanyId.Equals(checkCompanyId.Id));
            //        var customerId = checkCustomer.Id;
            //        var currentPriCustomerNumber = checkCustomer.PriCustomerNumber;

            //        var description = check.description;
            //        var modCode = check.modCode;
            //        var passCode = check.passCode;

            //        var conferenceID = insertModerator(WholesalerID, modCode, passCode, currentPriCustomerNumber, description, username, password, email, fullName, phoneNumber, address1, address2, city, country, postalCode, customerId);
            //    }
        }

        public class getCompany
        {
            public string companyName { get; set; }
        }

        public class getModCode
        {
            public string customerNumber { get; set; }
            public string description { get; set; }
            public string modCode { get; set; }
            public string passCode { get; set; }
            public string companyDesc { get; set; }
            public string fullName { get; set; }
            public string phoneNumber { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string email { get; set; }
            public string city { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string country { get; set; }
        }

        public class getCustomer
        {
            public string priCustomerNumber { get; set; }
            public string companyName { get; set; }
            public string fullName { get; set; }
            public string phoneNumber { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string email { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string region { get; set; }
            public string postalCode { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string pcn { get; set; }
        }

        public class getUser
        {
            public string companyName { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string displayName { get; set; }
            public string telephone { get; set; }
            public int roleId { get; set; }
            public string email { get; set; }
        }

        public static void insertCompany(string CompanyName)
        {
            string WholesalerID = "0000000001";
            var companyService = new CompanyService();
            var company = new Company();
            var companyList = companyService.GetAll();
            if (CompanyName.Length > 100)
            {
                CompanyName = CompanyName.Substring(0, 100);
            }
            var trimCompany = CompanyName.TrimEnd();
            var checkTrimCompany = companyList.Find(x => x.Description.Equals(trimCompany));
            var checkCompany = companyList.Find(x => x.Description.Equals(CompanyName));
            if (checkTrimCompany == null)
            {
                Console.WriteLine("insert company: " + trimCompany);
                company.WholesalerId = WholesalerID;
                company.Description = trimCompany;
                var companyInsert = companyService.Insert(company);
            }
            else
            {
                Console.WriteLine("company name: " + trimCompany);
            }
        }

        public static int insertCustomer(string WholesalerID, string fullName, string phoneNumber, string address1, string address2, string email,
            string city, string country, string region, string postalCode, int companyID, string username, string password, string pcn)
        {
            var csService = new CustomerService();
            var cust = new Customer();
            int roleId = 3;
            var currencyID = "";
            if (country == "NZ")
            {
                currencyID = "NZD";
            }
            else
            {
                currencyID = "AUD";
            }
            var custList = csService.GetAll();
            var checkCust = custList.Find(x => x.PrimaryContactEmailAddress.Contains(email));
            if (checkCust == null)
            {

                cust.WholesalerId = WholesalerID;
                cust.PriCustomerNumber = pcn;
                cust.PrimaryContactName = fullName;
                cust.PrimaryContactPhoneNumber = phoneNumber;
                cust.PrimaryContactEmailAddress = email;
                cust.PrimaryContactAddress1 = address1;
                cust.PrimaryContactAddress2 = address2;
                cust.PrimaryContactCity = city;
                cust.PrimaryContactCountry = country;
                cust.PrimaryContactRegion = region;
                cust.PrimaryContactPostalCode = postalCode;
                cust.BillingContactName = fullName;
                cust.BillingContactPhoneNumber = phoneNumber;
                cust.BillingContactEmailAddress = email;
                cust.BillingContactAddress1 = address1;
                cust.BillingContactAddress2 = address2;
                cust.BillingContactCity = city;
                cust.BillingContactCountry = country;
                cust.BillingContactRegion = region;
                cust.BillingContactPostalCode = postalCode;
                cust.WebsiteUrl = "www.redbackconferencing.com.au";
                cust.SalesPersonId = 2;
                cust.VerticalId = 0;
                cust.CompanyId = companyID;
                cust.CurrencyId = currencyID;
                cust.BillingPeriodCutoff = 30;
                cust.TaxableId = 0;
                cust.CreatedDate = DateTime.Now;
                cust.LastModified = DateTime.Now;
                var userID = insertUser(username, password, fullName, phoneNumber, roleId, email);
                cust.UserId = userID;
                cust.AccountManagerId = 1;

                csService.Insert(cust);
                insertDNISCust(cust.Id);
                insertFeatureCust(cust.Id);
                Console.WriteLine("Insert Customer: " + fullName);
                return cust.Id;
            }
            else
            {
                Console.WriteLine("Customer: " + fullName);
                return checkCust.Id;
            }
        }
        public static int insertModerator(string WholesalerID, string modCode, string passCode, string description, string priCustomerNumber,
            string username, string password, string email, string fullName, string phoneNumber, string address1, string address2, string city,
            string country, string postalCode, int customerID, string secCustomerNumber)
        {
            var modService = new ModeratorService();
            var conference = new Moderator();

            int roleID = 2;
            var modList = modService.GetAll();
            var checkMod = modList.Find(x => x.Description.Contains(description));
            if (checkMod == null && modCode != passCode)
            {
                conference.WholesalerId = WholesalerID;
                conference.ModeratorCode = modCode;
                conference.PassCode = passCode;
                conference.PriCustomerNumber = priCustomerNumber;
                conference.SecCustomerNumber = secCustomerNumber;
                conference.CustomerId = customerID;
                conference.Description = description;
                conference.DepartmentId = 1;
                conference.CreatedDate = DateTime.Now;
                conference.LastModified = DateTime.Now;
                conference.Enabled = true;
                var userID = insertUser(email, password, fullName, phoneNumber, roleID, email);
                conference.UserId = userID; //moderator user: mod test 1
                var modInsert = modService.Insert(conference);
                insertDNISMod(conference.Id);
                insertFeatureMod(conference.Id);
                Console.WriteLine("insert moderator: " + description);
                return conference.Id;
            }
            else
            {
                Console.WriteLine("moderator: " + description);
                return checkMod.Id;
            }
        }
        public static int insertUser(string username, string password, string displayName, string telephone, int roleId, string email)
        {
            var userService = new UserService();
            var user = new User();
            var userList = userService.GetAll();
            var checkUser = userList.Find(x => x.Username.Contains(username));
            if (checkUser == null)
            {
                user.Username = username;
                user.Password = password;
                user.DisplayName = displayName;
                user.Email = email;
                user.Telephone = telephone;
                user.Enabled = true;
                user.RoleId = roleId;
                user.MustChangePassword = false;
                userService.Insert(user);
                Console.WriteLine("Insert User: " + username);
                return user.UserId;
            }
            else
            {
                Console.WriteLine("User: " + username);
                return checkUser.UserId;
            }
        }

        public static void insertDNISCust(int custID)
        {
            var custDNIS = new Customer_Dnis();
            var custDnisService = new Customer_DnisService();

            custDNIS.CustomerId = custID;
            custDNIS.Dnisid = 9; //Local Re-Direct
            custDnisService.Insert(custDNIS);

            custDNIS.CustomerId = custID;
            custDNIS.Dnisid = 10; //Toll Free Dial In: Redback
            custDnisService.Insert(custDNIS);

            custDNIS.CustomerId = custID;
            custDNIS.Dnisid = 11; //UITF
            custDnisService.Insert(custDNIS);

            custDNIS.CustomerId = custID;
            custDNIS.Dnisid = 12; //Instant Replay
            custDnisService.Insert(custDNIS);

            custDNIS.CustomerId = custID;
            custDNIS.Dnisid = 13; //ITF
            custDnisService.Insert(custDNIS);

            custDNIS.CustomerId = custID;
            custDNIS.Dnisid = 14; //ILS
            custDnisService.Insert(custDNIS);

            custDNIS.CustomerId = custID;
            custDNIS.Dnisid = 20; //Local Dial In: Redback
            custDnisService.Insert(custDNIS);
        }

        public static void insertFeatureCust(int custID)
        {
            //insert feature
            var customer_feature = new Customer_Feature();
            var custFService = new Customer_FeatureService();

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 33; //Conference Mode
            customer_feature.FeatureOptionId = 256;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 34; //record automatically
            customer_feature.FeatureOptionId = 258;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 35; //Entry/Exit Announcement
            customer_feature.FeatureOptionId = 259;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 36; //Announce Number of Participants
            customer_feature.FeatureOptionId = 263;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 37; //Play Music
            customer_feature.FeatureOptionId = 264;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 38; //Conference Security PIN
            customer_feature.FeatureOptionId = 267;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 39; //Wait for Moderator
            customer_feature.FeatureOptionId = 268;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 40; //End Conference When Moderator Exits
            customer_feature.FeatureOptionId = 271;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 41; //Block Dialout
            customer_feature.FeatureOptionId = 176;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 43; //Recording Notifications
            customer_feature.FeatureOptionId = 285;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 44; //Send Recording notifications to Mod
            customer_feature.FeatureOptionId = 287;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 45; //Send Recording notifications to Admin
            customer_feature.FeatureOptionId = 289;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 47; //Parties
            customer_feature.FeatureOptionId = 398;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 48; //Play First Caller Message
            customer_feature.FeatureOptionId = 299;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 49; //Participant Name Record
            customer_feature.FeatureOptionId = 301;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 50; //First Party On Hold
            customer_feature.FeatureOptionId = 303;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 51; //Project Codes
            customer_feature.FeatureOptionId = 305;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 52; //Alert Threshold
            customer_feature.FeatureOptionId = 308;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 53; //Party Action Timer
            customer_feature.FeatureOptionId = 312;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 54; //Party Alert Action
            customer_feature.FeatureOptionId = 313;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 55; //Party Alert Timer
            customer_feature.FeatureOptionId = 315;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 56; //Alert Action Warning Prompt
            customer_feature.FeatureOptionId = 316;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 57; //Allow Party Conf Alert Reset
            customer_feature.FeatureOptionId = 319;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 58; //Play Alert Reset Message
            customer_feature.FeatureOptionId = 321;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 59; //Play Alert Disconnect Message
            customer_feature.FeatureOptionId = 323;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 60; //Password Valid With Count
            customer_feature.FeatureOptionId = 325;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 61; //Leader Recorded Greeting
            customer_feature.FeatureOptionId = 327;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 62; //Total Participant Sitting Count 
            customer_feature.FeatureOptionId = 329;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 63; //Double Passcode Entry
            customer_feature.FeatureOptionId = 331;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 64; //Conference Level Passcode
            customer_feature.FeatureOptionId = 334;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 65; //Auto Breakdown
            customer_feature.FeatureOptionId = 337;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 66; //Allow Auto Breakdown Extend
            customer_feature.FeatureOptionId = 340;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 67; //Play Blast Dial Into Conf Msg
            customer_feature.FeatureOptionId = 342;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 68; //Sub Conferencing
            customer_feature.FeatureOptionId = 344;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 69; //Filter
            customer_feature.FeatureOptionId = 346;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 70; //Vetting Level
            customer_feature.FeatureOptionId = 348;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 71; //Vetting Mode
            customer_feature.FeatureOptionId = 352;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 73; //Multiple Dialout Attempts 
            customer_feature.FeatureOptionId = 354;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 80; //QA Enter Message
            customer_feature.FeatureOptionId = 391;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 81; //QA Exit Message
            customer_feature.FeatureOptionId = 393;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 82; //Conference Type
            customer_feature.FeatureOptionId = 394;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);

            customer_feature.CustomerId = custID;
            customer_feature.FeatureId = 97; //Show Participants List
            customer_feature.FeatureOptionId = 446;
            customer_feature.Enabled = true;
            custFService.Insert(customer_feature);
        }

        public static void insertDNISMod(int modID)
        {
            var DNIS = new Moderator_Dnis();
            var DnisService = new Moderator_DnisService();
            DNIS.ModeratorId = modID;
            DNIS.Dnisid = 9; //Local Re-Direct
            DnisService.Insert(DNIS);

            DNIS.ModeratorId = modID;
            DNIS.Dnisid = 10; //Toll Free Dial In: Redback
            DnisService.Insert(DNIS);

            DNIS.ModeratorId = modID;
            DNIS.Dnisid = 11; //UITF
            DnisService.Insert(DNIS);

            DNIS.ModeratorId = modID;
            DNIS.Dnisid = 12; //Instant Replay
            DnisService.Insert(DNIS);

            DNIS.ModeratorId = modID;
            DNIS.Dnisid = 13; //ITF
            DnisService.Insert(DNIS);

            DNIS.ModeratorId = modID;
            DNIS.Dnisid = 14; //ILS
            DnisService.Insert(DNIS);

            DNIS.ModeratorId = modID;
            DNIS.Dnisid = 20; //Local Dial In: Redback
            DnisService.Insert(DNIS);
        }

        public static void insertFeatureMod(int modID)
        {
            //insert feature
            var moderator_feature = new Moderator_Feature();
            var modFService = new Moderator_FeatureService();

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 33; //Conference Mode
            moderator_feature.FeatureOptionId = 256;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 34; //record automatically
            moderator_feature.FeatureOptionId = 258;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 35; //Entry/Exit Announcement
            moderator_feature.FeatureOptionId = 259;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 36; //Announce Number of Participants
            moderator_feature.FeatureOptionId = 263;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 37; //Play Music
            moderator_feature.FeatureOptionId = 264;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 38; //Conference Security PIN
            moderator_feature.FeatureOptionId = 267;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 39; //Wait for Moderator
            moderator_feature.FeatureOptionId = 268;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 40; //End Conference When Moderator Exits
            moderator_feature.FeatureOptionId = 271;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 41; //Block Dialout
            moderator_feature.FeatureOptionId = 176;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 43; //Recording Notifications
            moderator_feature.FeatureOptionId = 285;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 44; //Send Recording notifications to Mod
            moderator_feature.FeatureOptionId = 287;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 45; //Send Recording notifications to Admin
            moderator_feature.FeatureOptionId = 289;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 47; //Parties
            moderator_feature.FeatureOptionId = 398;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 48; //Play First Caller Message
            moderator_feature.FeatureOptionId = 299;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 49; //Participant Name Record
            moderator_feature.FeatureOptionId = 301;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 50; //First Party On Hold
            moderator_feature.FeatureOptionId = 303;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 51; //Project Codes
            moderator_feature.FeatureOptionId = 305;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 52; //Alert Threshold
            moderator_feature.FeatureOptionId = 308;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 53; //Party Action Timer
            moderator_feature.FeatureOptionId = 312;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 54; //Party Alert Action
            moderator_feature.FeatureOptionId = 313;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 55; //Party Alert Timer
            moderator_feature.FeatureOptionId = 315;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 56; //Alert Action Warning Prompt
            moderator_feature.FeatureOptionId = 316;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 57; //Allow Party Conf Alert Reset
            moderator_feature.FeatureOptionId = 319;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 58; //Play Alert Reset Message
            moderator_feature.FeatureOptionId = 321;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 59; //Play Alert Disconnect Message
            moderator_feature.FeatureOptionId = 323;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 60; //Password Valid With Count
            moderator_feature.FeatureOptionId = 325;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 61; //Leader Recorded Greeting
            moderator_feature.FeatureOptionId = 327;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 62; //Total Participant Sitting Count 
            moderator_feature.FeatureOptionId = 329;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 63; //Double Passcode Entry
            moderator_feature.FeatureOptionId = 331;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 64; //Conference Level Passcode
            moderator_feature.FeatureOptionId = 334;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 65; //Auto Breakdown
            moderator_feature.FeatureOptionId = 337;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 66; //Allow Auto Breakdown Extend
            moderator_feature.FeatureOptionId = 340;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 67; //Play Blast Dial Into Conf Msg
            moderator_feature.FeatureOptionId = 342;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 68; //Sub Conferencing
            moderator_feature.FeatureOptionId = 344;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 69; //Filter
            moderator_feature.FeatureOptionId = 346;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 70; //Vetting Level
            moderator_feature.FeatureOptionId = 348;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 71; //Vetting Mode
            moderator_feature.FeatureOptionId = 352;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 73; //Multiple Dialout Attempts 
            moderator_feature.FeatureOptionId = 354;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 80; //QA Enter Message
            moderator_feature.FeatureOptionId = 391;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 81; //QA Exit Message
            moderator_feature.FeatureOptionId = 393;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 82; //Conference Type
            moderator_feature.FeatureOptionId = 394;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);

            moderator_feature.ModeratorId = modID;
            moderator_feature.FeatureId = 97; //Show Participants List
            moderator_feature.FeatureOptionId = 446;
            moderator_feature.Enabled = true;
            modFService.Insert(moderator_feature);
        }
    }
}
