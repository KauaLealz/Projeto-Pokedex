    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace appPokemon
    {
        public class Pokemon
        {

            private String nome;

            public String Nome 
            {
                get { return nome; }
                set 
                { nome = value.ToUpper(); }
            }

            private String descricao;

            public String Descricao
            {
                get { return descricao; }
                set { descricao = value.ToUpper(); }
            }

            public Pokemon()
            {

                this.nome = "";
                this.descricao = "";

            }

            public Pokemon(String nome, String descricao)
            {

                this.nome = nome;
                this.descricao = descricao;

            }

            public void exibirDadosPokemon()
            {

                Console.WriteLine($@"
                Nome do Pokémon: {nome}
                Descrição do Pokémon: {descricao}");

            }

        }
    }
