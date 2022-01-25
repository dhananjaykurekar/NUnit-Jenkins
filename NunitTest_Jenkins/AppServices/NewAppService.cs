using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NunitTest_Jenkins.AppServices
{
    public class NewAppService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}