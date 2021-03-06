﻿using System;
using System.Data;

namespace Salesforce2DynamicsCRM
{
    class DbWrapper : IDisposable
    {
        private CDataFactory factory;

        private IDbConnection conn = null;


        public DbWrapper(CDataFactory factory, string connectionString)
        {
            this.factory = factory;
            this.conn = factory.CreateConnection(connectionString);
        }

        public void Dispose()
        {
            this.conn.Dispose();
        }

        public DataTable CreateDataTable(string tableName)
        {
            using (var command = this.factory.CreateCommand("SELECT * FROM " + tableName, conn))
            using (var adaptor = this.factory.CreateDataAdapter(command))
            {
                var table = new DataTable(tableName);
                adaptor.Fill(table);

                return table;
            }
        }

        public void Update(DataTable table)
        {
            using (var command = this.factory.CreateCommand("SELECT * FROM " + table.TableName, conn))
            using (var adaptor = this.factory.CreateDataAdapter(command))
            using (var commandBuilder = this.factory.CreateCommandBuilder(adaptor))
            {
                adaptor.InsertCommand = commandBuilder.GetInsertCommand();
                adaptor.UpdateCommand = commandBuilder.GetUpdateCommand();

                adaptor.Update(table);
            }
        }
    }
}
