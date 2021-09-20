using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class PremiumFactory : CreditCardFactory
    {
        public override ICreditCard MakeInstanceOfCreditCard()
        {
            return new Premium();
        }
    }
}
