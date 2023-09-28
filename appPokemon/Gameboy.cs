using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPokemon
{
    public class Gameboy
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int opcaoEscolhida;

            do
            {

                Console.WriteLine(@"
==============================
        Minha Pokedex
==============================

Escolha uma opção:
1. Escanear Pokémon
2. Remover Pokémon Escaneado
3. Visualizar Pokémons Escaneados
4. Sair
                ");

                Console.Write("");

                opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
            
                switch(opcaoEscolhida)
                {
                    case 1:
                        Console.Write("Nome do Pokemon Escaneado: ");
                        String nomeToScan = Console.ReadLine().ToUpper();
                        Console.Write("Descricao do Pokemon Escaneado: ");
                        String descPkm = Console.ReadLine().ToUpper();
                        pokedex.escanearPokemon(nomeToScan, descPkm);
                        break;
                    case 2:
                        Console.Write("Nome do Pokemon Que Deseja Remover: ");
                        String nomeToRemove = Console.ReadLine().ToUpper();
                        pokedex.removerPokemon(nomeToRemove);
                        break;
                    case 3:
                        pokedex.exibirPokemons();
                        break;
                    case 4:
                        break;
                    default: 
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opcaoEscolhida!=4);

        }
    }
}
