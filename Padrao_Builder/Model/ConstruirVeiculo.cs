using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Padrao_Builder.Model
{
    /// <summary>
    /// Abstract Builder
    /// </summary>
    public abstract class ConstruirVeiculo
    {
        // Crio um veículo
        protected Veiculo veiculo;
        // Crio uma Propriedade
        public Veiculo Veiculo
        {
            // Busco o veículo
            get { return veiculo; }
        }

        public abstract void ContruirChassi();
        public abstract void ConstruirMotor();
        public abstract void ConstruirRodas();
        public abstract void ConstruirPortas();
    }
}
