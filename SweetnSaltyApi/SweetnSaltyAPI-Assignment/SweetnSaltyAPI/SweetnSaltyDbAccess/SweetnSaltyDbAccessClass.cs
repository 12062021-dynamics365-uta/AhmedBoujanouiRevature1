using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        private readonly string str = ""; /*connection string here.*/
        private readonly SqlConnection _con;

        //constructor
        public SweetnSaltyDbAccessClass()
        {
            this._con = new SqlConnection(this.str);
            _con.Open();
        }

        public async Task<SqlDataReader> PostFlavor(string flavorname)
        {
            string sqlQuery = $"INSERT INTO Flavor VALUES (@flavorname) ";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, this._con))
            {
                cmd.Parameters.AddWithValue("@flavorname", flavorname);

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrieveFlavor = "SELECT TOP 1 * FROM Flavor ORDER BY FlavorId DESC;";
                    using (SqlCommand cmd1 = new SqlCommand(retrieveFlavor, this._con))
                    {

                        SqlDataReader dr = await cmd1.ExecuteReaderAsync();
                        return dr;
                    }
                }
                catch (DbException ex)// TODO do something with this exception
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.PostFlavor{ex}");
                    return null;
                }
            }
        }


    }
}
