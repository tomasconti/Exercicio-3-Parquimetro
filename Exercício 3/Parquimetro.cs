using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Parquimetro
    {
        private float saldo = 0;

        public float Saldo
        {
            get
            {
                return saldo ;
            }
            set
            {
                saldo = value;
            }
        }

        public void adicionaMoeda(float moeda)
        {
            saldo = saldo + moeda;
        }

        public float consultaSaldo()
        {

            return saldo;
        }

        public float confirmar(float hora)
        {
            float valor = hora * 1.5f;
            return valor;
        }

        public void cancelar()
        {
            saldo = 0;
        }
    }
}
