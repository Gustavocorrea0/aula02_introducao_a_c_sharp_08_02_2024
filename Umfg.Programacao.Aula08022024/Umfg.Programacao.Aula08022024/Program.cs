using Umfg.Programacao.Aula08022024.Estruturas;

namespace Umfg.Programacao.Aula08022024
// namespace - pasta fisica do projeto
// limpar solução - elimina arquivos desnecessarios

{
    internal class Program
    // internal - Não permite que uma classe seja vista por outra
    {
        static void Main(string[] args)
        {
            // Forma1 = TiposInteiros tiposInteiros = new TiposInteiros();
            var tiposInteiros = new TiposInteiros();
            TiposPontoFlutuante tiposPontoFlutuante = new TiposPontoFlutuante();
            TipoBoolean tipoBoolean = new TipoBoolean();
            TipoDateTime tipoDateTime = new TipoDateTime();
            TipoEnum tipoEnum = new TipoEnum();
            Condicoes condicoes = new Condicoes();
            Repeticoes repeticoes = new Repeticoes();

            //tiposInteiros.Executar();
            //tiposPontoFlutuante.Executar();
            //tipoBoolean.Executar();
            //tipoDateTime.Executar();
            //tipoEnum.Executar();
            //condicoes.Executar();
            repeticoes.Executar();

            Console.ReadLine();
        }
    }
}