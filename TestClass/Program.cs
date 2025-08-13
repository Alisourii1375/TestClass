using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArghamNegarLibrary; 
 

namespace TestClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Multi m  = new Multi();

            Console.WriteLine( m.mult(2, 3));
            Console.WriteLine( m.threemult(2, 3 , 4 ));
            Console.WriteLine( m.fourmult(Convert.ToDecimal( 3.1416)
                        , Convert.ToDecimal(3.3575)
                        , Convert.ToDecimal(4.575)
                        , Convert.ToDecimal(5.57578)
                        )
                )
                        ;

            
        }
    }
}
