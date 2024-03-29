﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Padrao_Builder.Model;

namespace Padrao_Builder.Model
{
    /// <summary>
    /// Concret Builder - Construtor concreto 1.
    /// Constroi um veículo do tipo Moto
    /// </summary>
    public class ConstrutorMoto : ConstruirVeiculo
    {
        public override void ContruirChassi()
        {
            veiculo = new Veiculo("Moto");
            veiculo["chassi"] = "Chassi da Moto";
        }

        public override void ConstruirMotor()
        {
            veiculo["motor"] = "500 cc";
        }

        public override void ConstruirRodas()
        {
            veiculo["rodas"] = "2";
        }

        public override void ConstruirPortas()
        {
            veiculo["portas"] = "0";
        }
    }
}
