using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAss3
{
    public class BankAccount
    {
        private int _saldoAmount;

        public int SaldoAmount
        {
            get { 
                if(_saldoAmount <=0 )
                    _saldoAmount = 0;
                return _saldoAmount; }
            set {  _saldoAmount = value; }
        }

        public void Deposit(int inputCurrency)
        {
            _saldoAmount += inputCurrency;
        }

        public void Withdraw(int inputCurrency) 
        {
            _saldoAmount -= inputCurrency;
        }
    }
}
