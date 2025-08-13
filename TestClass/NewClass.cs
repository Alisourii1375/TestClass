using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class Multi
    {
        public int mult(int a , int b)
        {

            return (a * b);         
        }

        public decimal dmult(decimal a, decimal b)
        {

            return (a * b);
        }

        public int  threemult( int a, int  b, int  c)
        {

            return (a * b  * c ) ;
        }

        public decimal fourmult(decimal a, decimal b, decimal c , decimal d )
        {

            return (a * b * c * d );
        }



    }
}
