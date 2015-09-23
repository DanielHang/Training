using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace GalacticDVDFormsApplication
{
	class SqlDbConnect
	{
		private SqlConnection _con;
		public SqlCommand Cmd;
		private SqlDataAdapter _da;
		private DataTable _dt;

		public SqlDbConnect() {
			_con = new SqlConnection(@"Data Source=TALSMONKEY\SQLEXPRESS;Initial Catalog=GalacticRentals;Integrated Security=True");
			_con.Open();
		}

		public void SqlQuery(string queryText)
		{
			Cmd = new SqlCommand(queryText, _con);
		}

		public DataTable QueryEx()
		{
			_da = new SqlDataAdapter(Cmd);
			_dt = new DataTable();
			_da.Fill(_dt);
			return _dt;
		}

		public void NonQueryEx()
		{
			Cmd.ExecuteNonQuery();
		}
	}
}
