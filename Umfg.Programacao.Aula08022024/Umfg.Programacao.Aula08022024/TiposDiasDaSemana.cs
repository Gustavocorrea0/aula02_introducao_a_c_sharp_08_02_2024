using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Programacao.Aula08022024
{
    internal enum TiposDiasDaSemana
    {
        /// <summary>
        /// NaoIdentidicado - Representa a um dia da semana não indentificado
        /// </summary>
        [Description("Nao Identificado")]
        NaoIdentificado = 0,

        /// <summary>
        /// Segunda - Representa a segunda-feira
        /// </summary>
        [Description("Segunda")]
        Segunda = 1,

        /// <summary>
        /// Terca - Representa a terça-feira
        /// </summary>
        [Description("Terca")]
        Terca = 2,

        /// <summary>
        /// Quarta - Representa a quarta-feira
        /// </summary>
        [Description("Quarta")]
        Quarta = 3,

        /// <summary>
        /// Quinta - Representa a quinta-feira
        /// </summary>
        [Description("Quinta")]
        Quinta = 4,

        /// <summary>
        /// Sexta - Representa a sexta-feira
        /// </summary>
        [Description("Sexta")]
        Sexta = 5,

        /// <summary>
        /// Sabado - Representa a sexta-feira
        /// </summary>
        [Description("Sabado")]
        Sabado = 6,

        /// <summary>
        /// Domingo - Representa a sexta-feira
        /// </summary>
        [Description("Domingo")]
        Domingo = 7

    }
}
