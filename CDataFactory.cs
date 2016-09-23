using System.Data;
using System.Data.CData.DynamicsCRM;
using System.Data.CData.Salesforce;
using System.Data.Common;

namespace Salesforce2DynamicsCRM
{
    abstract class CDataFactory
    {
        public static readonly CDataFactory Salesforce = new CDataFactorySalesforce();

        public static readonly CDataFactory DynamicsCRM = new CDataFactoryDynamicsCRM();


        public abstract IDbConnection CreateConnection(string connectionString);

        public abstract IDbCommand CreateCommand(string commandText, IDbConnection conn);

        public abstract DbDataAdapter CreateDataAdapter(IDbCommand command);

        public abstract DbCommandBuilder CreateCommandBuilder(DbDataAdapter adapter);


        private class CDataFactorySalesforce : CDataFactory
        {
            public override IDbConnection CreateConnection(string connectionString)
            {
                return new SalesforceConnection(connectionString);
            }

            public override IDbCommand CreateCommand(string commandText, IDbConnection conn)
            {
                return new SalesforceCommand(commandText, (SalesforceConnection)conn);
            }

            public override DbDataAdapter CreateDataAdapter(IDbCommand command)
            {
                return new SalesforceDataAdapter((SalesforceCommand)command);
            }

            public override DbCommandBuilder CreateCommandBuilder(DbDataAdapter adapter)
            {
                return new SalesforceCommandBuilder((SalesforceDataAdapter)adapter);
            }
        }


        private class CDataFactoryDynamicsCRM : CDataFactory
        {
            public override IDbConnection CreateConnection(string connectionString)
            {
                return new DynamicsCRMConnection(connectionString);
            }

            public override IDbCommand CreateCommand(string commandText, IDbConnection conn)
            {
                return new DynamicsCRMCommand(commandText, (DynamicsCRMConnection)conn);
            }

            public override DbDataAdapter CreateDataAdapter(IDbCommand command)
            {
                return new DynamicsCRMDataAdapter((DynamicsCRMCommand)command);
            }

            public override DbCommandBuilder CreateCommandBuilder(DbDataAdapter adapter)
            {
                return new DynamicsCRMCommandBuilder((DynamicsCRMDataAdapter)adapter);
            }
        }
    }
}
