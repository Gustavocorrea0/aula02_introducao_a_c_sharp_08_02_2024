using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Programacao.Aula08022024
{
    internal class TipoDateTime
    {
        public void Executar() 
        {
            // DateTime.Now - dia e hora do servidor (ter cuidado com a regiao)
            Console.WriteLine(DateTime.Now);

            // 
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            // Padrao BR 12 horas
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            // Padrao BR 24 horas
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            // Padrao EUA 24 horas
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            // Utilizacao de Short
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            // Utilizacao de Long
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            // Hora local
            Console.WriteLine(DateTime.Now.ToLocalTime());

            var dataUm = DateTime.Now;

            // Data especifica
            var dataDois = new DateTime(2023, 02, 08);

            Console.WriteLine(dataUm);
            Console.WriteLine(dataDois);

        }
    }
}
