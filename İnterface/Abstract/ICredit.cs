using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface.Abstract
{
    public interface ICredit

    {
        public int Id { get; set; }
        public int CreditLimit { get; set; }
        public int Interest { get; set; }

        void Calculate();
        


    }

}
