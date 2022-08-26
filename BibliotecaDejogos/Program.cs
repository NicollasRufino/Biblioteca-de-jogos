using BibliotecaDejogos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDejogos
{
    internal class Program
    {
        public static object listaDejogos { get; private set; }

        static void Main(string[] args)
        {
            List<Jogo> listaDeJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            while (true)
            {

                Console.WriteLine("======BIBLIOTECA DE JOGOS======");

                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogos");
                Console.WriteLine("3 - Editar Jogo");
                Console.WriteLine("4 - Remover Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        resultado = AdicionarJogo(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Adicionado com Sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro no cadastro.");
                        }
                        break;
                        
                    case "2":
                        resultado = ListarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Listado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem.");
                        }
                        break;

                    case "4":
                        resultado = Remover(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem.");
                        }
                        break;

                        case "3":
                        resultado = EditarJogo(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Editado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na edição.");
                        }
                        break;
                          
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }


        public static bool AdicionarJogo(List<Jogo> listaDejogos)
        {
            Console.Clear();
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gênero: ");
            string genero = Console.ReadLine();
            Console.Write("Max. de Jogadores: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n ");

            if (titulo == "") return false;
            if (ano < 1950) return false;

            Jogo novoJogo = new Jogo(titulo, ano, "teste", 1);

            listaDejogos.Add(novoJogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos (List<Jogo> listaDejogos)
        {
            foreach(Jogo jogo in listaDejogos)
            {
                Console.Write("\n");
                Console.Write("Jogo ");
                Console.Write("\n");
                Console.Write("\n");
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.Write("Genero : ");
                Console.WriteLine(jogo.getGenero());
                Console.Write("Max Player : ");
                Console.WriteLine(jogo.Maxjogadores());
                Console.Write("Metacritica : ");
                Console.WriteLine(jogo.getMetacritic());
                Console.WriteLine("Busca Completa!");
                Console.WriteLine("-------------");
                Console.WriteLine("");
                Console.WriteLine("==========");
                Console.WriteLine("");
            }

            return true;
        }
        public static bool Remover(List<Jogo> listaDejogos)
        {
           Console.WriteLine("Título do jogo que deseja remover: ");
            Console.WriteLine("\n");
           String remove_jogo = Console.ReadLine();


            foreach (Jogo jogo in listaDejogos)
            {
                if(remove_jogo == jogo.getTitulo())
                    listaDejogos.Remove(jogo);
                

                break;
            }

            return true;
        }

    }
    public static bool EditarJogo(List<Jogo> listaDejogos)
        {
           Console.WriteLine("Título do jogo que deseja editar: ");
           Console.WriteLine("\n");
           String edit_jogo = Console.ReadLine();


            foreach (Jogo jogo in listaDejogos)
            {
           
            
                if (edit_jogo == jogo.getTitulo())
            
                Console.Write("\n");
                Console.Write("Jogo ");
                Console.Write("\n");
                Console.Write("\n");
                Console.Write("Titulo: ");
                String edit_titulo = Console.ReadLine();
                jogo.titulo = edit_titulo;


                Console.WriteLine("");
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                int edit_ano = Convert.ToInt32(Console.ReadLine());
                jogo.ano = edit_ano;

                Console.Write("Genero : ");
                String edit_Genero = Console.ReadLine();
                jogo.genero = edit_Genero;


            Console.Write("Max Player : ");
                Console.WriteLine(jogo.Maxjogadores());
                int edit_max = Convert.ToInt32(Console.ReadLine());
                jogo.maxJogadores = edit_max;



                Console.Write("Metacritica : ");
                Console.WriteLine(jogo.getMetacritic());
                int edit_metacritic = Convert.ToInt32(Console.ReadLine());
                jogo.metacritic = edit_metacritic;
                


                Console.WriteLine("Edição Completa");
                Console.WriteLine("-------------");
                Console.WriteLine("");
                Console.WriteLine("==========");
                Console.WriteLine(""); 
        }
        return true;
    }
}   
