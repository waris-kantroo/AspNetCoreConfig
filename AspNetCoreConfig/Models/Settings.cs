using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreConfig.Models
{

    // this class correpondes to the Settings section given in the appsettings.json file
    public class Settings
    {

        public string DbConnection { get; set; }

        public string Email { get; set; }

        public string SMTPPort { get; set; }
    }
}
