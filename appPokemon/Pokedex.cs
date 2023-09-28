using System;
using System.Collections.Generic;

namespace appPokemon
{
    internal class Pokedex
    {
        private List<Pokemon> pokemons;

        public Pokedex()
        {
            pokemons = new List<Pokemon>();
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        public void escanearPokemon(string nome, string descricao)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(descricao))
            {
                Pokemon pokemonCapturado = new Pokemon(nome, descricao);
                pokemons.Add(pokemonCapturado);
                Console.WriteLine($"O pokemon {nome} adicionado com sucesso à sua pokedex");
            }
            else
            {
                Console.WriteLine("Falha ao escanear pokemon");
            }
        }

        public void removerPokemon(string nome)
        {

            Boolean pkmFoiRemovido = false;

            for (int i = 0; i < pokemons.Count; i++)
            {
                string pkmAtualNome = pokemons[i].Nome;
                string pkmAtualDesc = pokemons[i].Descricao;
                
                if(pkmAtualNome ==  nome)
                {
                    pokemons.Remove(pokemons[i]);
                    pkmFoiRemovido = true;
                    Console.WriteLine($"O pokemón {nome} foi removido da sua pokedex");
                }

            }

            if (!pkmFoiRemovido)
            {
                Console.WriteLine($"Não foi encontrado nenhum pokemón com o nome {nome} na sua pokedex");
            }
        }

        public void exibirPokemons()
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                string pkmAtualNome = pokemons[i].Nome;
                string pkmAtualDesc = pokemons[i].Descricao;
                Console.WriteLine($@"
Pokemon N°{i + 1}
Nome: {pkmAtualNome}
Descrição: {pkmAtualDesc}
==============================
                ");
            }

            if (pokemons.Count == 0)
            {
                Console.WriteLine("Não há pokemons na sua pokedex");
            }
        }
    }
}
