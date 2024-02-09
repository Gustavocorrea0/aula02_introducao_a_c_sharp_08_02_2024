using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Umfg.Programacao.Aula08022024
{
    internal class TiposInteiros
    {
        // Metodo
        public void Executar() 
        {
            #region Tipos Inteiros
            Console.WriteLine("short");
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine("byte");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            // ushort - começa possitivo
            Console.WriteLine("ushort");
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            // Tipos Inteiros
            var inteiroUm = int.MinValue;
            var inteiroDois = int.MaxValue;

            Console.WriteLine("int");
            Console.WriteLine(inteiroUm);
            Console.WriteLine(inteiroDois);

            // uint - ocupa o mesmo numero de memoria do int e comeca do 0
            var inteiroTres = uint.MinValue;
            var inteiroQuatro = uint.MaxValue;

            Console.WriteLine("uint");
            Console.WriteLine(inteiroTres);
            Console.WriteLine(inteiroQuatro);

            Console.WriteLine("long");
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            #endregion 
        }
    }
}
