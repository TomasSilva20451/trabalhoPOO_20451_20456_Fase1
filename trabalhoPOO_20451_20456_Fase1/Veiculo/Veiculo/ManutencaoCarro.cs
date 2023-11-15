/**
 * @file ManutencaoCarro.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Classe para representar a manutencao de carros
 * @version 0.1
 * @date 2023-11-14
 * 
 * @copyright Copyright (c) 2023
 */
using System;
namespace Autoprem
{
    
    public class ManutencaoCarro : Veiculo
    {
        public ManutencaoCarro(int id, string marca, string modelo, decimal preco)
            : base(id, marca, modelo, preco)
        {
            // Construtor de ManutencaoCarro
            // Console.WriteLine($"Criando um novo ManutencaoCarro com ID: {id}");
        }

        // Sobrescrever o metodo para realizar manutencao em carros
        public override void RealizarManutencao()
        {
            base.RealizarManutencao(); // Chama a implementacao na classe base
            Console.WriteLine("Realizando manutencao especifica para carros.");
            // Adicionar a logica de manutencao especifica para carros
        }
    }
}

