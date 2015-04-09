using MyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageLibraries
{
    public class KinderJoy : IKinderJoy
    {
        public string Greet(string name)
        {
            return string.Format("hello {0}!", name);
        }

        public string GreetBye(string name)
        {
            return string.Format("bye {0}!", name);
        }
    }
}
