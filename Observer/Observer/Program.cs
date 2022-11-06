using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(10240);
            Buyer buyer = new Buyer(product);
            product.ChangeMegaBites(145);
            product.ChangeMegaBites(145);

        }
    }
}


