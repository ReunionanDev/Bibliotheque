using System;
using System.Collections.Generic;
using System.Text;

namespace SalariesDll
{
    [Serializable()]
    public class Commercial : Salarie
   {
        private decimal _turnover;
        private decimal _commission;

        public decimal Turnover
        {
            get
            {
                return this._turnover;
            }
            set
            {
                this._turnover = value;
            }
        }
        public decimal Commission
        {
            get
            {
                return this._commission;
            }
            set
            {
                this._commission = value;
            }
        }

        public override decimal NetSalary()
        {
            return this.GrossSalary * (1 - this.SocialRate) + (Turnover * (Commission / 100));
            
        }

        // Constructors

        public Commercial()
            : base()
        {
        }

        public Commercial(Commercial commercial)
            : base(commercial)
        {
            Turnover = commercial.Turnover;
            Commission = commercial.Commission;
        }


   }

    
}
