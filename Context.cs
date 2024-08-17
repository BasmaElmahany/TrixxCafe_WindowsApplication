using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trixx_CafeSystem
{
    class Context:DbContext
    {

        public Context() : base(@"Data Source=LOLITA\MSSQLSERVER02;initial catalog=Trixx;integrated security=True;")
        {


        }


    }
}
