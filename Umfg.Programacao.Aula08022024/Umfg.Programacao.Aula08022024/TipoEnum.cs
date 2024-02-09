using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Programacao.Aula08022024
{
    internal class TipoEnum
    {
        public void Executar() 
        {

            var diasUteis = TiposDiasDaSemana.Segunda
                              | TiposDiasDaSemana.Terca
                              | TiposDiasDaSemana.Quarta
                              | TiposDiasDaSemana.Quinta
                              | TiposDiasDaSemana.Sexta;

            var finalDeSemana = TiposDiasDaSemana.Sabado
                                | TiposDiasDaSemana.Domingo;

            Console.WriteLine("Dias utéis: " + diasUteis);
            Console.WriteLine("Final de Semana: " + finalDeSemana);
        }
    }
}
