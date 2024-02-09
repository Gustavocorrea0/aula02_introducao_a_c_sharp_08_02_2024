using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Programacao.Aula08022024
{
    internal class TiposPontoFlutuante
    {
        public void Executar() 
        {
            // Para trabalho com valores utilizar decimal
            // #region - Delimita uma regiao
            #region Tipos Ponto Flutuante

            var pontoFlutuanteDouble = 1.33;
            var pontoFlutuanteFloat = 1.33f;
            var pontoFlutuanteDecimal = 1.33m;

            Console.WriteLine("float");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine("double");
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("decimal");
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            // float apresenta baixa precisao para soma
            Console.WriteLine(10.10f + 20.20f);

            // decimal apresenta alta precisao para soma
            Console.WriteLine(10.10m + 20.20m);
            #endregion
        }
    }
}
