using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Padrao_Builder.Model
{
    /// <summary>
    /// Produto
    /// </summary>
    public class Veiculo
    {

        // Configura o tipo do Veículo
        private string tipo;

        // Criamos uma Hashtable para armazenar as partes do veículo atribuindo a elas uma chave.
        // Assim podemos realizar buscas nos elementos da coleção.
        private Hashtable partes = new Hashtable();


        // Construtor da classe.
        public Veiculo(string tipo)
        {
            this.tipo = tipo;
        }


        // Crio um Indexador para a classe
        public object this[string chave]
        {
            get { return partes[chave]; }
            set { partes[chave] = value; }
        }


        /// <summary>
        /// Método responsável por imprimir os dados do Veículo
        /// </summary>
        public void Mostra()
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("Tipo do Veículo: {0}", tipo);
            Console.WriteLine("Chassi : {0}", partes["chassi"]);
            Console.WriteLine("Motor : {0}", partes["motor"]);
            Console.WriteLine("Rodas : {0}", partes["rodas"]);
            Console.WriteLine("Portas : {0}", partes["portas"]);
            Console.ReadLine();
        }
    }
}



