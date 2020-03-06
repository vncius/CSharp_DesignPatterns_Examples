using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Padrao_Prototype.Model
{
    public class Produto : ICloneable
    {
        public int _IdCategoria;

        public string _Classificacao;

        public IdCaracteristicas IdCaracteristica;

        #region Metodos de clonagem

        public Object Clone()
        {
            DateTime dateTeste = DateTime.Now;
            dateTeste.AddDays(60);
            
            return (Produto)this.MemberwiseClone();
        
        }

        public Object Copiar()
        {
            Produto copiaProduto = (Produto)this.MemberwiseClone();

            copiaProduto.IdCaracteristica = new IdCaracteristicas(this.IdCaracteristica._IdFabricante,
                                                                    this.IdCaracteristica._IdPreco, 
                                                                    this.IdCaracteristica._IdDescricao);

            return copiaProduto;
        }

        #endregion

    }
}