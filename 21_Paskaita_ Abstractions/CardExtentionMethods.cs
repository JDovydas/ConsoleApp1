using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _21_Paskaita__Abstractions
{
    internal static class CardExtentionMethods
    {
        public static PaypalProcessor CreditCardToPaypal(this CreditCardProcessor creditCard)
        {
            return new PaypalProcessor
            {
                TransactionId = creditCard.TransactionId,
                Amount = creditCard.Amount,
            };

        }
    }
}
