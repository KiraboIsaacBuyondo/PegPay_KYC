using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegPayKYC.Helpers
{
    public interface IStorage
    {
        List<object> ExecuteSelectQuery(string query);
    }
}
