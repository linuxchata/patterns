using System.Data;

namespace Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class StubAdapter : IDbDataAdapter
    {
        public int Fill(DataSet dataSet)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Name", typeof(string)));

            var row = dataTable.NewRow();
            row[0] = 1;
            row[1] = "Adapter";

            dataTable.Rows.Add(row);
            dataSet.Tables.Add(dataTable);
            dataSet.AcceptChanges();

            return dataTable.Rows.Count;
        }

        public IDbCommand DeleteCommand
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public IDbCommand InsertCommand
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public IDbCommand SelectCommand
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public IDbCommand UpdateCommand
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new System.NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new System.NotImplementedException();
        }

        public MissingMappingAction MissingMappingAction
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public MissingSchemaAction MissingSchemaAction
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public ITableMappingCollection TableMappings
        {
            get { throw new System.NotImplementedException(); }
        }

        public int Update(DataSet dataSet)
        {
            throw new System.NotImplementedException();
        }
    }
}
