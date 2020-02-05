using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Padrao_Singleton.Model
{
    /// <summary>
    /// Classe no modelo Singleton simples
    /// </summary>
    public sealed class Cadeira
    {
        private static readonly Cadeira instance = new Cadeira();
        public int Quantidade { get; set; }
 
        private Cadeira() { }
 
        public static Cadeira Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
