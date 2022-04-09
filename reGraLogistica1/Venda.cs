using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reGraLogistica1
{
    class Venda
    {
        public double skol, Brahma, Stella, bohemia;
        public Venda()
        {
            this.skol = 4.99;
            this.Brahma = 4.5;
            this.Stella = 4.15;
            this.bohemia = 4.8;
        }

        public double GetSkol(double qtd, double dia)
        {
            double cashback = 0;
            if (dia == 1)
            {
                cashback = ((qtd * skol) * 25) / 100;
            }
            else if (dia == 2)
            {
                cashback = ((qtd * skol) * 7) / 100;
            }
            else if (dia == 3)
            {
                cashback = ((qtd * skol) * 6) / 100;
            }
            else if (dia == 4)
            {
                cashback = ((qtd * skol) * 2) / 100;
            }
            else if (dia == 5)
            {
                cashback = ((qtd * skol) * 10) / 100;
            }
            else if (dia == 6)
            {
                cashback = ((qtd * skol) * 15) / 100;
            }
            else if (dia == 7)
            {
                cashback = ((qtd * skol) * 20) / 100;
            }
            return cashback;
        }
        public double GetBrahma(double qtd, double dia)
        {
            double cashback = 0;
            if (dia == 1)
            {
                cashback = ((qtd * Brahma) * 30) / 100;
            }
            else if (dia == 2)
            {
                cashback = ((qtd * Brahma) * 5) / 100;
            }
            else if (dia == 3)
            {
                cashback = ((qtd * Brahma) * 10) / 100;
            }
            else if (dia == 4)
            {
                cashback = ((qtd * Brahma) * 15) / 100;
            }
            else if (dia == 5)
            {
                cashback = ((qtd * Brahma) * 20) / 100;
            }
            else if (dia == 6)
            {
                cashback = ((qtd * Brahma) * 25) / 100;
            }
            else if (dia == 7)
            {
                cashback = ((qtd * Brahma) * 30) / 100;
            }
            return cashback;
        }
        public double GetStella(double qtd, double dia)
        {
            double cashback = 0;
            if (dia == 1)
            {
                cashback = ((qtd * Stella) * 35) / 100;
            }
            else if (dia == 2)
            {
                cashback = ((qtd * Stella) * 3) / 100;
            }
            else if (dia == 3)
            {
                cashback = ((qtd * Stella) * 5) / 100;
            }
            else if (dia == 4)
            {
                cashback = ((qtd * Stella) * 8) / 100;
            }
            else if (dia == 5)
            {
                cashback = ((qtd * Stella) * 13) / 100;
            }
            else if (dia == 6)
            {
                cashback = ((qtd * Stella) * 18) / 100;
            }
            else if (dia == 7)
            {
                cashback = ((qtd * Stella) * 25) / 100;
            }
            return cashback;
        }
        public double GetBohemia(double qtd, double dia)
        {
            double cashback = 0;
            if (dia == 1)
            {
                cashback = ((qtd * bohemia) * 35) / 100;
            }
            else if (dia == 2)
            {
                cashback = ((qtd * bohemia) * 3) / 100;
            }
            else if (dia == 3)
            {
                cashback = ((qtd * bohemia) * 5) / 100;
            }
            else if (dia == 4)
            {
                cashback = ((qtd * bohemia) * 8) / 100;
            }
            else if (dia == 5)
            {
                cashback = ((qtd * bohemia) * 13) / 100;
            }
            else if (dia == 6)
            {
                cashback = ((qtd * bohemia) * 18) / 100;
            }
            else if (dia == 7)
            {
                cashback = ((qtd * bohemia) * 25) / 100;
            }
            return cashback;
        }
    }
}
