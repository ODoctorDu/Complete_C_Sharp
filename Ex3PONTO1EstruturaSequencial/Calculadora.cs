using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3PONTO1EstruturaSequencial
{
    class Calculadora
    {
        //--------------------[ATRIBUTOS]
       
        public double Total;       //Atributos sempre com 1ªLetra Maiúscula

        //--------------------[MÉTODOS]
        public void Soma (double valor1, double valor2)
        {
            Total = valor1 + valor2;
        }
    }
}
