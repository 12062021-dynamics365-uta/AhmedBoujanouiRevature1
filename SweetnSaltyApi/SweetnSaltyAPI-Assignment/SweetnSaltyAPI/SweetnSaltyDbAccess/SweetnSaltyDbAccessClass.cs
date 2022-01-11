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

        public async Task<SqlDataReader> PostPerson(string fname, string lname, string flavorname)
        {
            string sqlQuery = $"INSERT INTO Person VALUES (@fname, @lname, @flavorname) ";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, this._con))
            {
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@flavorname", flavorname);


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

        public async Task<SqlDataReader> GetPerson(int PersonId, string fname, string lname)
        {
            string sqlQuery3 = $"SELECT * from Person WHERE Fname = 'Ahmed'; ";

            using (SqlCommand cmd3 = new SqlCommand(sqlQuery3, this._con))
            {
                //cmd3.Parameters.extract("@fname", fname);
                //cmd3.Parameters.AddWithValue("@lname", lname);
                //cmd.Parameters.AddWithValue("@flavorname", flavorname);


                try
                {
                    await cmd3.ExecuteNonQueryAsync();
                    string retrievePerson3 = $"SELECT * from Person WHERE Fname = 'Ahmed';";
                    using (SqlCommand cmd2 = new SqlCommand(retrievePerson3, this._con))
                    {

                        SqlDataReader dr3 = await cmd3.ExecuteReaderAsync();
                        return dr3;
                    }
                }
                catch (DbException ex)// TODO do something with this exception
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.PostPerson{ex}");
                    return null;
                }
            }
        }


    }
}
