using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness
{
    public class Mapper : IMapper
    {
        public Flavor EntityToFlavor(SqlDataReader dr)
        {
            return new Flavor()
            {
                FlavorId = dr.GetInt32(0),
                FlavorName = dr[1].ToString(),
            };
        }
        public Person EntityToPerson(SqlDataReader dr)
        {
            return new Person()
            {
                PersonId = dr.GetInt32(0),
                Fname = dr[1].ToString(),
                Lname = dr[2].ToString(),
            };

        }
    }
}
