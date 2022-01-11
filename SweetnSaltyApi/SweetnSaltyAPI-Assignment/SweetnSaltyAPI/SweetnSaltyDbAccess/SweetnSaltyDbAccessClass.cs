using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        private readonly string str = ("data source = DESKTOP-KOB9I12\\SQLEXPRESS01; initial catalog = SweetnSalty; integrated security = true"); /*connection string here.*/
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

        public async Task<SqlDataReader> PostPerson(string fname, string lname)
        {
            string sqlQuery = $"INSERT INTO Person VALUES (@fname, @lname) ";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, this._con))
            {
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrievePerson = "SELECT TOP 1 * FROM Person ORDER BY PersonId DESC;";
                    using (SqlCommand cmd1 = new SqlCommand(retrievePerson, this._con))
                    {

                        SqlDataReader dr1 = await cmd1.ExecuteReaderAsync();
                        return dr1;
                    }
                }
                catch (DbException ex)// TODO do something with this exception
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.PostPerson{ex}");
                    return null;
                }
            }
        }

        public Task<SqlDataReader> PostPerson(string fname, string lname, string flavorname)
        {
            throw new NotImplementedException();
        }
    }
}
