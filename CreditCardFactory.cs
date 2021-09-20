using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard MakeInstanceOfCreditCard();

        public  ICreditCard CreateInstance()
        {
            return this.MakeInstanceOfCreditCard();
        }

    }
}
