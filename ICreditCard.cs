using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public interface ICreditCard
    {
        public string GetCardType();
        public int GetAnnualCharge();
        public int GetMaxLimit();
    }
}
