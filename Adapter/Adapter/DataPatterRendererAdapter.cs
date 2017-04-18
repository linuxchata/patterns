using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Adapter
{
    public class DataPatterRendererAdapter : IDataPatterRendererAdapter
    {
        private DataRenderer dataRenderer;

        public string PatternsList(IEnumerable<Pattern> patterns)
        {
            this.dataRenderer = new DataRenderer(new ParrentCollectionAdapter(patterns));

            var write = new StringWriter();
            this.dataRenderer.Render(write);

            return write.ToString();
        }

        private class ParrentCollectionAdapter : IDbDataAdapter
        {
            private readonly IEnumerable<Pattern> patterns;

            public ParrentCollectionAdapter(IEnumerable<Pattern> patterns)
            {
                this.patterns = patterns;
            }

            public int Fill(DataSet dataSet)
            {
                var dataTable = new DataTable();

                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));

                foreach (var item in this.patterns)
                {
                    var row = dataTable.NewRow();
                    row[0] = item.Id;
                    row[1] = item.Name;

                    dataTable.Rows.Add(row);
                }

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
}
