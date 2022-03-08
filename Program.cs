using DIO.Filmes;
using System;
using System.Collections.Generic;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmesRepositorio repositorioFilmes = new FilmesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "0":
                        ListarSeries();
                        break;
                    case "1":
                        InserirSerie();
                        break;
                    case "2":
                        AtualizarSerie();
                        break;
                    case "3":
                        ExcluirSerie();
                        break;
                    case "4":
                        VisualizarSerie();
                        break;
                    case "5":
                        ListarFilmes();
                        break;
                    case "6":
                        InserirFilmes();
                        break;
                    case "7":
                        AtualizarFilmes();
                        break;
                    case "8":
                        ExcluirFilmes();
                        break;
                    case "9":
                        VisualizarFilmes();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSerie.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void VisualizarFilmes()
        {
            Console.Write("Digite o id do Filme: ");
            int indiceFilmes = int.Parse(Console.ReadLine());

            var filmes = repositorioFilmes.RetornaPorId(indiceFilmes);

            Console.WriteLine(filmes);
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceSerie);
        }
        private static void ExcluirFilmes()
        {
            Console.Write("Digite o id do Filme: ");
            int indiceFilmes = int.Parse(Console.ReadLine());

            repositorioFilmes.Exclui(indiceFilmes);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioSerie.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void AtualizarFilmes()
        {
            Console.Write("Digite o id do Filme: ");
            int indiceFilmes = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGeneroFilmes = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTituloFilmes = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAnoFilmes = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricaoFilmes = Console.ReadLine();

            DIO.Filmes.Filmes atualizaFilmes = new DIO.Filmes.Filmes(id: indiceFilmes,
                                        genero: (Genero)entradaGeneroFilmes,
                                        titulo: entradaTituloFilmes,
                                        ano: entradaAnoFilmes,
                                        descricao: entradaDescricaoFilmes);

            repositorioFilmes.Atualiza(indiceFilmes, atualizaFilmes);
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie NovaSerie = new(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioSerie.Insere(NovaSerie);
        }

        private static void InserirFilmes()
        {
            Console.WriteLine("Inserir novo Filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGeneroFilmes = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTituloFilmes = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAnoFilmes = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricaoFilmes = Console.ReadLine();

            DIO.Filmes.Filmes novoFilmes = new DIO.Filmes.Filmes(id: repositorioFilmes.ProximoId(),
                                        genero: (Genero)entradaGeneroFilmes,
                                        titulo: entradaTituloFilmes,
                                        ano: entradaAnoFilmes,
                                        descricao: entradaDescricaoFilmes);

            repositorioFilmes.Insere(novoFilmes);
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorioSerie.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }
        private static void ListarFilmes()
        {
            Console.WriteLine("Listar Filmes");

            var lista = repositorioFilmes.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach (var filmes in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", filmes.retornaId(), filmes.retornaTitulo());
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("0- Listar séries");
            Console.WriteLine("1- Inserir nova série");
            Console.WriteLine("2- Atualizar série");
            Console.WriteLine("3- Excluir série");
            Console.WriteLine("4- Visualizar série");
            Console.WriteLine("5- Listar Filmes");
            Console.WriteLine("6- Inserir novo filme");
            Console.WriteLine("7- Atualizar filme");
            Console.WriteLine("8- Excluir filme");
            Console.WriteLine("9- Visualizar filme");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}