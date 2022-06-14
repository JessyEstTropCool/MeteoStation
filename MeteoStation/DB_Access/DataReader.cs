using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace MeteoStation.DB_Access
{
	class DataReader 
	{
		internal static void Read(DataGridView Grid, string DB_Table)
		{
			DataTable Table = new DataTable();

			DataColumn ID = new DataColumn();
			DataColumn Name = new DataColumn();
			DataColumn Password = new DataColumn();
			DataColumn Access = new DataColumn();

			Table.Columns.Add(ID);
			Table.Columns.Add(Name);
			Table.Columns.Add(Password);
			Table.Columns.Add(Access);

			OleDbCommand SelectCommand = new OleDbCommand("SELECT * from " + DB_Table + ";", Tools.connexion);

			try
			{
				Tools.connexion.Open();

				OleDbDataReader DBReader = SelectCommand.ExecuteReader();

				if (DBReader.HasRows)
				{
					while (DBReader.Read())
					{
						Table.Rows.Add(new object[] { DBReader[0], DBReader[1], DBReader[2], DBReader[3] });
					}
				}

				DBReader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}

			Grid.DataSource = Table;
		}
	}
}
