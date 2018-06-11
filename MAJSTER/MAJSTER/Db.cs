using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MAJSTER
{
	class Db
	{
		SqlConnection con;
		public Db()
		{
			string cs = @"Data Source=KI-B312-13;Initial Catalog=MAJSTERKLEPKA;Integrated Security=True";
			con = new SqlConnection(cs);
			con.Open();
		}

		public string[] KL(string x)
		{
			List<string> K = new List<string>();
			string s = @"select * from  klienci where kontakt > @x"; // + x;
			SqlCommand cmd = new SqlCommand(s, con);
			cmd.Parameters.AddWithValue("@x", x);
			SqlDataReader rd = cmd.ExecuteReader();
			while (rd.Read())
				K.Add(rd["kontakt"].ToString());
			rd.Close();

			return K.ToArray();
		}
		
		//public string[] KAT()
	//	{

		//}

	}
}
