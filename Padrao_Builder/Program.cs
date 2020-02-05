using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using Padrao_Builder.Model;


namespace Builder
{
    /// <summary>
    /// Separa a construção de um objeto complexo da sua representação de forma que o mesmo processo
    /// de construção possa criar representações diferentes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // Cria a montadora com construtores de veículos
            Montadora montadora = new Montadora();

            // Build Moto
            ConstruirVeiculo cMoto = new ConstrutorMoto();

            // Build Carro
            ConstruirVeiculo cCarro = new ConstrutorCarro();

            // Construir e exibir os veículos
            montadora.Construir(cMoto);

            cMoto.Veiculo.Mostra();

            montadora.Construir(cCarro);

            cCarro.Veiculo.Mostra();
        }
    }
}