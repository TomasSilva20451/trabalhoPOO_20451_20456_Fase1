/**
 * @file ManutencaoMoto.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Classe para representar a manutencao de motos
 * @version 0.1
 * @date 2023-11-14
 * 
 * @copyright Copyright (c) 2023
 */
using System;
namespace Autoprem
{
    
    public class ManutencaoMoto : Veiculo
    {
        public ManutencaoMoto(int id, string marca, string modelo, decimal preco)
            : base(id, marca, modelo, preco)
        {
            // Construtor de ManutencaoMoto
            // Console.WriteLine($"Criando um novo ManutencaoMoto com ID: {id}");
        }

        // Sobrescrever o metodo para realizar manutencao em motos
        public override void RealizarManutencao()
        {
            base.RealizarManutencao(); // Chama a implementacao na classe base
            Console.WriteLine("Realizando manutencao especifica para motos.");
            // Adicionar a logica de manutencao especifica para motos
        }
    }
}

