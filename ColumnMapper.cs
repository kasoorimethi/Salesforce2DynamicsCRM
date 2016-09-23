using System.Collections.Generic;
using System.Data;

namespace Salesforce2DynamicsCRM
{
    abstract class ColumnMapper
    {
        public abstract void Map(DataRow source, DataRow destination);
    }


    class AccountMapper : ColumnMapper
    {
        private static Dictionary<string, string> NameMapping = new Dictionary<string, string>()
        {
            { "AccountNumber", "AccountNumber" },
            { "AnnualRevenue", "Revenue" },
            { "BillingCity", "Address1_City" },
            { "BillingCountry", "Address1_Country" },
            { "BillingLatitude", "Address1_Latitude" },
            { "BillingLongitude", "Address1_Longitude" },
            { "BillingPostalCode", "Address1_PostalCode" },
            { "BillingState", "Address1_County" },
            { "BillingStreet", "Address1_Line1" },
            { "Description", "Description" },
            { "Fax", "Fax" },
            { "Name", "Name" },
            { "NumberOfEmployees", "NumberOfEmployees" },
            { "Phone", "Telephone1" },
            { "ShippingCity", "Address2_City" },
            { "ShippingCountry", "Address2_Country" },
            { "ShippingLatitude", "Address2_Latitude" },
            { "ShippingLongitude", "Address2_Longitude" },
            { "ShippingPostalCode", "Address2_PostalCode" },
            { "ShippingState", "Address2_County" },
            { "ShippingStreet", "Address2_Line1" },
            { "TickerSymbol", "TickerSymbol" },
            { "Website", "WebSiteURL" },
            { "Sic", "SIC" },
        };


        public override void Map(DataRow source, DataRow destination)
        {
            foreach (var entry in NameMapping)
            {
                destination[entry.Value] = source[entry.Key];
            }
        }
    }


    static class ColumnMapperRegistry
    {
        private static Dictionary<string, ColumnMapper> columnMapperMap = new Dictionary<string, ColumnMapper>();


        static ColumnMapperRegistry()
        {
            columnMapperMap["Account"] = new AccountMapper();
        }

        public static ColumnMapper GetMapper(string name)
        {
            return columnMapperMap[name];
        }
    }
}
