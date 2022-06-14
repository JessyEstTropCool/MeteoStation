using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation.DB_Access
{
    internal class Tools
    {
		internal static OleDbDataAdapter Adapter = new OleDbDataAdapter();

		internal static OleDbConnection connexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
																			+
																		@"Data Source=..\..\..\UserAccess.accdb;Cache Authentication=True");
		internal static void Config()
		{
			string Insert_CommandText = "INSERT into Users(UserName,UserPassword,Access_Id) values(@UserName,@UserPassword,@Access_Id);";
			string Delete_CommandText = "DELETE FROM Users WHERE UserName = @UserName;";
			string Select_CommandText = "SELECT * from Users ORDER BY UserKey_Id;";
			string Update_CommandText = "UPDATE Users SET UserPassword = @UserPassword, Access_Id = @Access_Id WHERE UserName = @UserName;";

			OleDbCommand Insert_Command = new OleDbCommand(Insert_CommandText, connexion);
			OleDbCommand Delete_Command = new OleDbCommand(Delete_CommandText, connexion);
			OleDbCommand Select_Command = new OleDbCommand(Select_CommandText, connexion);
			OleDbCommand Update_Command = new OleDbCommand(Update_CommandText, connexion);

			Adapter.SelectCommand = Select_Command;
			Adapter.InsertCommand = Insert_Command;
			Adapter.DeleteCommand = Delete_Command;
			Adapter.UpdateCommand = Update_Command;

			Adapter.TableMappings.Add("Users", "UserTable");
			Adapter.TableMappings.Add("Access", "AccessTable");

			Adapter.InsertCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
			Adapter.InsertCommand.Parameters.Add("@UserPassword", OleDbType.VarChar, 40, "UserPassword");
			Adapter.InsertCommand.Parameters.Add("@Access_Id", OleDbType.Numeric, 100, "Access_Id");
			Adapter.DeleteCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
		}
	}
}
