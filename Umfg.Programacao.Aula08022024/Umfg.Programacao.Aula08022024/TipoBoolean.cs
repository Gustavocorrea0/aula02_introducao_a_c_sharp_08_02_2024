using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Programacao.Aula08022024
{
    internal class TipoBoolean
    {
        public void Executar() 
        {
            var boolUm = true;
            var boolDois = false;

            // Boolean é falso por padrão
            bool boolTres = false;
            bool boolQuantro = true;

            Console.WriteLine("bollUm - " + boolUm);
            Console.WriteLine("bollDois - " + boolDois);
            Console.WriteLine("bollTres - " + boolTres);
            Console.WriteLine("bollQuatro - " + boolQuantro);
        }
    }
}
