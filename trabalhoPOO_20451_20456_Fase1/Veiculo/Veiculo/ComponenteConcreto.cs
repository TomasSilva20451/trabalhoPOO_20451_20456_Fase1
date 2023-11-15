/**
 * @file ComponenteConcreto.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Classe concreta que representa um Componente específico
 * @version 0.1
 * @date 2023-11-14
 * 
 * @copyright Copyright (c) 2023
 */

using System;

namespace Autoprem
{
    // Classe concreta que herda de Componente
    public class ComponenteConcreto : Componente
    {
        // Construtor para criar instâncias de ComponenteConcreto
        public ComponenteConcreto(int id, string nome, decimal preco)
            : base(id, nome, preco)
        {
            // Adicionar a lógica específica para a inicialização de ComponenteConcreto
            Console.WriteLine($"Criando um novo ComponenteConcreto com ID: {id}");
            
        }

        // Implementação do método abstrato RealizarManutencao
        public override void RealizarManutencao()
        {
            Console.WriteLine($"Realizando manutenção específica para {Nome}");
            // Adicionar a lógica de manutenção específica para ComponenteConcreto
        }
    }
}
