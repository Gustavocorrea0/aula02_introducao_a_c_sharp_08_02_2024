using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Programacao.Aula08022024.Estruturas
{
    internal class Condicoes
    {
        // VARIAVEIS DE ESCOPO CONSTANTE
        private const string C_VALOR_A = "A";

        public void Executar() 
        {

            // CASO A CONDICAO OCORRA EM UMA LINHA NAO É NECESSARIO UTILIZAR DE CHAVES
            /*
            #region Condicoes
            // IF - Comun
            if (true)
            {}
            else 
            {}

            // IF ELSE
            if (true)
            { }
            else if(false)
            { }

            // SWITCH CASE
            var boolTeste = true;

            switch (boolTeste)
            {
                case true:
                    Console.WriteLine("False");
                    break;

                case false:
                    Console.WriteLine("False"); 
                    break;
            }

            #endregion

            #region uso if

            string nome = "Gustavo";

            
            if (nome == null || string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Valor Inválido");
            }

            if (nome != null)
                Console.WriteLine("Olá "+ nome);
            else
                Console.WriteLine("Valor Inválido");

            // Como testar a igualdade do sinal


            #endregion

            #region Cotrole de VARIAVEIS DE ESCOPO CONSTANTE com IF
            Console.WriteLine("ESCOLHA UMA OPÇÃO");
            Console.WriteLine("A");
            Console.WriteLine("B");

            var valorDigitado = Console.ReadLine();

            if (C_VALOR_A == valorDigitado)
            {
                Console.WriteLine("Seu usuario será Administrador");
            }

            Console.WriteLine("Seu usuario será Padrão");

            #endregion
            */

            #region Cotrole de VARIAVEIS DE ESCOPO CONSTANTE com SWITCH CASE

            Console.WriteLine("INFORME UM VALOR: ");
            var valorUm = int.Parse(Console.ReadLine());

            Console.WriteLine("INFORME OUTRO VALOR: ");
            int.TryParse(Console.ReadLine(), out int valorDois);

            Console.WriteLine(valorUm);
            Console.WriteLine(valorDois);

            Console.WriteLine("INFORME O TIPO DE OPERAÇÃO: ");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICACÃO");
            Console.WriteLine("4 - DIVISÃO");
            var operacao = Console.ReadLine();  

            switch (operacao)
            {
                case "1":
                    Console.WriteLine("SOMA: " + (valorUm + valorDois));
                    break; 
                case "2":
                    Console.WriteLine("SUBTRAÇÃO: " + (valorUm - valorDois));
                    break;
                case "3":
                    Console.WriteLine("MULTIPLICACÃO: " + (valorUm * valorDois));
                    break;
                case "4":
                    Console.WriteLine("DIVISÃO: " + (valorUm / valorDois));
                    break;
            }

            #endregion
        }
    }
}
