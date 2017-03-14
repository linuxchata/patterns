using System.Data;
using System.IO;

namespace Adapter
{
    public class DataRenderer
    {
        private readonly IDbDataAdapter adapter;

        public DataRenderer(IDbDataAdapter adapter)
        {
            this.adapter = adapter;
        }

        public void Render(TextWriter writer)
        {
            var dataSet = new DataSet();

            this.adapter.Fill(dataSet);

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    writer.Write(column.ColumnName.PadRight(6) + " ");
                }

                writer.WriteLine();

                foreach (DataRow row in table.Rows)
                {
                    for (var i = 0; i < table.Columns.Count; i++)
                    {
                        writer.Write(row[i].ToString().PadRight(6) + " ");
                    }

                    writer.WriteLine();
                }

                writer.WriteLine();
            }
        }
    }
}
