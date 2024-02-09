using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Programacao.Aula08022024.Estruturas
{
    internal class Repeticoes
    {
        public void Executar() 
        {
            var teste = "UMFG EDUCACIONAL";

            #region for
            for (int i = 0; i < teste.Length; i++) 
            {
                 Console.WriteLine(teste[i]);
            }
            #endregion

            #region while

            // TESTE E EXECUTA
            var cont = 5;
            while(cont > 0)
            {
                cont++;
            }

            #endregion

            #region do-while
            // EXCUTA PELO MENOS UMA VEZ ANTES DE TESTAR
            do 
            {
                Console.WriteLine(cont);
            } while(cont > 0);
            #endregion

            # region Foreach
              //REVER
            #endregion
        }
    }
}
