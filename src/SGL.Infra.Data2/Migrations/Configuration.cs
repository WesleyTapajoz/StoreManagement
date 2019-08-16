using SGL.Domain.Entity;
using SGL.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SGL.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SGLContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SGLContext context)
        {
            if (context.Autores.Count() == 0)
            {
                try
                {
                    PopularDados(context);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    // TODO: fazer log de erro
                    ex.ToString();
                }
            }
        }

        private void PopularDados(SGLContext context)
        {
            var Autores = new List<Autor>
            {
                new Autor {
                    Nome = "Andrew Stellman",
                    Email = "andrewstellman@hotmail.com",
                },

                new Autor {
                    Nome = "CORNES, OLLIE",
                    Email = "cornesollie@hotmail.com",
                },

                new Autor {
                    Nome = "John Sharp",
                    Email = "johnsharp@hotmail.com",
                },
            };
            context.Autores.AddRange(Autores);

            var Editoras = new List<Editora>
            {
                new Editora {
                    Descricao =  "Alta Books",
                    Email = "altabooks@hotmail.com",
                },

                new Editora {
                    Descricao =  "MAKRON",
                    Email = "makron@hotmail.com",
                },
                new Editora {
                    Descricao =  "Bookman",
                    Email = "bookman@hotmail.com",
                },

            };
            context.Editoras.AddRange(Editoras);

            var Generos = new List<Genero>
            {
                new Genero {
                    Descricao = "Use A Cabeça! C#",
                },

                new Genero {
                    Descricao = "Informática e Tecnologia - Programação",
                },

                  new Genero {
                    Descricao = "Design de software",
                },

            };
            context.Generos.AddRange(Generos);


            var links = new List<Link>
            {
                new Link {
                    Url = "https://www.amazon.com.br/Use-Cabe%C3%A7a-C-Andrew-Stellman/dp/8576085593?tag=goog0ef-20&smid=A3112JKNHESVZU&ascsubtag=go_1494986073_58431735035_285514469186_pla-566080525912_c_",
                    Descricao = "Use A Cabeça! C# (Português) Capa Comum",
                    Icone = "",
                },

                 new Link {
                    Url = "https://www.livrariacultura.com.br/p/livros/informatica-e-tecnologia/programacao/professional-c-programando-734214?id_link=8787&adtype=pla&gclid=Cj0KCQjwhdTqBRDNARIsABsOl98uPw5gVecmURAfh5luAG25U91xqzp1YDhzonFxpHcySfmroAFdWdkaAtGqEALw_wcB",
                    Descricao = "PROFESSIONAL C# PROGRAMANDO",
                    Icone = "",
                },

                  new Link {
                    Url = "https://www.amazon.com.br/Microsoft-Visual-C-2013-Desenvolvedor/dp/858260209X/ref=pd_sbs_14_2/131-7162415-3827340?_encoding=UTF8&pd_rd_i=858260209X&pd_rd_r=242a4094-5d05-4cd5-beb4-ce30fd31f8cc&pd_rd_w=J7nys&pd_rd_wg=5Wior&pf_rd_p=80c6065d-57d3-41bf-b15e-ee01dd80424f&pf_rd_r=T3JWX60Y7VD6SWJ4KHD0&psc=1&refRID=T3JWX60Y7VD6SWJ4KHD0",
                    Descricao = "Microsoft Visual C# 2013: Desenvolvedor (Português) Capa Comum ",
                    Icone = "",
                }
            };
            context.Links.AddRange(links);


            var Livros = new List<Livro>
            {
                new Livro {
                    Titulo = "Use A Cabeça! C#",
                    DataPublicacao = DateTime.Now,
                    Paginas = 738,
                    Genero = Generos[0],
                    AutorId = 0,
                    Editora = Editoras[0],
                    Descricao = "O Use a Cabeça! C# – 2ª Edição é uma experiência completa de aprendizagem para a programação com C#, .NET Framework e IDE Visual Studio. Construído para ser assimilado rapidamente pela sua mente, este livro cobre o C# & .NET 4.0 e o Visual Studio 2010, e ensina tudo, desde a herança até a serialização. Você consultará seus dados com o LINQ, desenhará gráficos e animação e aprenderá as classes e a programação orientada a objetos, tudo através do desenvolvimento de jogos, fazendo projetos práticos e resolvendo quebra-cabeças. Você será um programador C# sólido e terá muita diversão no caminho",
                    Sinopse = "Um guia de aprendizagem para a programação no mundo real com visual C# e .NET",
                    Capa = "comum",
                    LinkId = 0
                },

                 new Livro {
                    Titulo = "Use A Cabeça! C#",
                    DataPublicacao = DateTime.Now,
                    Paginas = 800,
                    Genero =  Generos[1],
                    AutorId = 1,
                    Editora = Editoras[1],
                    Descricao = "Amplie seus conhecimentos e aprenda os fundamentos do Visual C# 2013. Destinado a programadores que estão começando a usar o Visual C# 2013, este tutorial fornece orientações passo a passo e exercícios práticos que vão ajudá-lo a dominar os tópicos e as técnicas essenciais. Descubra como: Criar e depurar aplicativos C# no Visual Studio 2013; Trabalhar com variáveis, identificadores, operadores e métodos; Criar interfaces e definir classes abstratas; Escrever código robusto que pode capturar e tratar exceções; Exibir e editar dados utilizando vinculação de dados com o Entity Framework do Microsoft ADO.NET; Responder a entradas de usuário e gestos baseados em toque; Tratar eventos de várias fontes; Desenvolver seu primeiro aplicativo Windows 8.1.",
                    Sinopse = "Desenvolvedor Passo a Passo Microsoft Visual C# 2013",
                    Capa = "comum",
                    LinkId = 1
                },

                  new Livro {
                    Titulo = "PROFESSIONAL C# PROGRAMANDO",
                    DataPublicacao = DateTime.Now,
                    Paginas = 1156,
                    Genero =  Generos[2],
                    AutorId = 2,
                    Editora = Editoras[2],
                    Descricao = "A linguagem C# é descrita como a mais importante tecnologia para desenvolvedores dos últimos anos, assim como seu ambiente associado - o .NET Framewor",
                    Sinopse = "A linguagem C# é descrita como a mais importante tecnologia para desenvolvedores dos últimos anos, assim como seu ambiente associado - o .NET Framework. O .NET fornece um novo ambiente no qual você pode desenvolver quase todos os tipos de aplicação Windows ou com base na Web, e C# é  a linguagem de programação que foi projetada especificamente para o .NET.Este livro é a ferramenta ideal para conhecer e aprofundar-se no estudo da linguagem C# e da plataforma .NET.",
                    Capa = "comum",
                    LinkId = 2
                }

            };
            context.Livros.AddRange(Livros);
        }

    }
}
