using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticApp
{
    public class VerifyResult
    {
        public List<string> ValidApps { get; set; }
        public List<string> InValidApps { get; set; }
        public string Username { get; set; }
        public VerifyResult()
        {
            this.ValidApps = new List<string>();
            this.InValidApps = new List<string>();
        }
    }
}
