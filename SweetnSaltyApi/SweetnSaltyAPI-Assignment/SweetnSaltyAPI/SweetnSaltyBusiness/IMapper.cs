using SweetnSaltyModels;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness
{
    public interface IMapper
    {
        Person EntityToPerson(SqlDataReader dr);
        Flavor EntityToFlavor(SqlDataReader dr);
    }
}