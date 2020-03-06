using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Padrao_Prototype.Model
{
    public class IdCaracteristicas
    {

        public int _IdFabricante;

        public int _IdPreco;

        public string _IdDescricao;

        public IdCaracteristicas(int vIdFabricante, int vIdPreco, string vIdDescricao)
        {
            this._IdFabricante = vIdFabricante;

            this._IdPreco = vIdPreco;

            this._IdDescricao = vIdDescricao;
        }
    }
}
