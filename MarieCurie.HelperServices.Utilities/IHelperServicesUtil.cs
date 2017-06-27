using MarieCurie.Interview.Assets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarieCurie.HelperServices.Utilities
{
    public interface IHelperServicesUtil
    {
        bool checkOpenningHours(string dayOfWeek, int Hour, HelperService center);
        string nextOpenningHours(string dayOfWeek, int Hour, HelperService center);

    }
}
