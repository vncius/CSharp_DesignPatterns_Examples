using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Padrao_Builder.Model;

namespace Padrao_Builder.Model
{
    /// <summary>
    /// Director - Conecta as partes produzidas
    /// <remarks>
    /// A Montadora usa a ConstruirVeiculo para construir uma variedade de Veiculo
    /// em uma série de passos sequenciais.
    /// </remarks>
    /// </summary>

    public class Montadora
    {

        /// <summary>
        /// Para todos os objetos da estrutura.
        /// </summary>
        /// <param name="construirVeiculo"></param>
        public void Construir(ConstruirVeiculo construirVeiculo)
        {
            construirVeiculo.ContruirChassi();
            construirVeiculo.ConstruirRodas();
            construirVeiculo.ConstruirPortas();
            construirVeiculo.ConstruirMotor();
        }
    }
}
