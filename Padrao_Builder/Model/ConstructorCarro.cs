using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Padrao_Builder.Model;

namespace Padrao_Builder.Model
{
    /// <summary>
    /// Concret Builder - Construtor concreto 2.
    /// Constroi um veículo do tipo Carro
    /// </summary>
    class ConstrutorCarro : ConstruirVeiculo
    {
        public override void ContruirChassi()
        {
            veiculo = new Veiculo("Carro");
            veiculo["chassi"] = "Chassi do Carro";
        }

        public override void ConstruirMotor()
        {
            veiculo["motor"] = "2500cc";
        }


        public override void ConstruirRodas()
        {
            veiculo["rodas"] = "4";
        }


        public override void ConstruirPortas()
        {
            veiculo["portas"] = "4";
        }
    }
}

