﻿// <auto-generated />
using System;
using Livraria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Livraria.Migrations
{
    [DbContext(typeof(LivrariaContext))]
    partial class LivrariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Livraria.Autor", b =>
                {
                    b.Property<int>("autorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("lingua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeautor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("autorId");

                    b.ToTable("DAutores");

                    b.HasData(
                        new
                        {
                            autorId = 1,
                            lingua = "português",
                            nomeautor = "Jose Saramago",
                            pais = "Portugal"
                        },
                        new
                        {
                            autorId = 2,
                            lingua = "português",
                            nomeautor = "Fernando Pessoa",
                            pais = "Portugal"
                        },
                        new
                        {
                            autorId = 3,
                            lingua = "português",
                            nomeautor = "Eça de Queirós",
                            pais = "Portugal"
                        },
                        new
                        {
                            autorId = 4,
                            lingua = "português",
                            nomeautor = "Miguel Torga",
                            pais = "Portugal"
                        });
                });

            modelBuilder.Entity("Livraria.Autoria", b =>
                {
                    b.Property<int>("autoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("autorId")
                        .HasColumnType("int");

                    b.Property<int>("livroId")
                        .HasColumnType("int");

                    b.HasKey("autoriaId");

                    b.HasIndex("autorId");

                    b.HasIndex("livroId");

                    b.ToTable("Autorias");

                    b.HasData(
                        new
                        {
                            autoriaId = 1,
                            autorId = 1,
                            livroId = 1
                        },
                        new
                        {
                            autoriaId = 2,
                            autorId = 2,
                            livroId = 2
                        },
                        new
                        {
                            autoriaId = 3,
                            autorId = 3,
                            livroId = 3
                        },
                        new
                        {
                            autoriaId = 4,
                            autorId = 4,
                            livroId = 4
                        });
                });

            modelBuilder.Entity("Livraria.Editora", b =>
                {
                    b.Property<int>("editoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("codigoPostal")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeEditora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroPorta")
                        .HasColumnType("int");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.Property<string>("webSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("editoraId");

                    b.ToTable("DEditoras");

                    b.HasData(
                        new
                        {
                            editoraId = 1,
                            codigoPostal = 4099023,
                            email = "porto@porto.com.pt",
                            fracao = "na",
                            morada = "Rua da Restauração",
                            nomeEditora = "Porto",
                            numeroPorta = 365,
                            telefone = 226088322,
                            webSite = "www.portoeditora.pt"
                        },
                        new
                        {
                            editoraId = 2,
                            codigoPostal = 1500499,
                            email = "bertrand@editoa.com.pt",
                            fracao = "na",
                            morada = "Rua Professor Jorge Silva Horta",
                            nomeEditora = "Bertrand Editora",
                            numeroPorta = 1,
                            telefone = 217626000,
                            webSite = "www.bertrandeditora.pt"
                        },
                        new
                        {
                            editoraId = 3,
                            codigoPostal = 42610038,
                            email = "leya@editora.com.pt",
                            fracao = "na",
                            morada = "Rua Cidade de Córdova",
                            nomeEditora = "Leya",
                            numeroPorta = 2,
                            telefone = 214272200,
                            webSite = "www.leya.com"
                        });
                });

            modelBuilder.Entity("Livraria.Livro", b =>
                {
                    b.Property<int>("livroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ano")
                        .HasColumnType("int");

                    b.Property<int?>("editoraId")
                        .HasColumnType("int");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("livroId");

                    b.HasIndex("editoraId");

                    b.HasIndex("usuarioId");

                    b.ToTable("DLivros");

                    b.HasData(
                        new
                        {
                            livroId = 1,
                            ano = 1995,
                            editoraId = 1,
                            genero = "Romance",
                            preco = 17m,
                            quantidade = 100,
                            titulo = "Ensaio sobre a Cegueira"
                        },
                        new
                        {
                            livroId = 2,
                            ano = 1946,
                            editoraId = 2,
                            genero = "Poesia",
                            preco = 18m,
                            quantidade = 150,
                            titulo = "Poemas Completos de Alberto Caeiro"
                        },
                        new
                        {
                            livroId = 3,
                            ano = 1878,
                            editoraId = 3,
                            genero = "Romance",
                            preco = 8m,
                            quantidade = 150,
                            titulo = "O Primo Basílio"
                        },
                        new
                        {
                            livroId = 4,
                            ano = 1940,
                            editoraId = 1,
                            genero = "Poesia",
                            preco = 10m,
                            quantidade = 150,
                            titulo = "Bichos"
                        });
                });

            modelBuilder.Entity("Livraria.Localidade", b =>
                {
                    b.Property<int>("localidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("localidadeId");

                    b.ToTable("Localidades");

                    b.HasData(
                        new
                        {
                            localidadeId = 1,
                            Local = "Lisboa"
                        },
                        new
                        {
                            localidadeId = 2,
                            Local = "Porto"
                        });
                });

            modelBuilder.Entity("Livraria.Requisicao", b =>
                {
                    b.Property<int>("requisicaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataRequisicao")
                        .HasColumnType("datetime2");

                    b.Property<int>("livroId")
                        .HasColumnType("int");

                    b.Property<int>("localidadeId")
                        .HasColumnType("int");

                    b.Property<int?>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("requisicaoId");

                    b.HasIndex("livroId");

                    b.HasIndex("localidadeId");

                    b.HasIndex("usuarioId");

                    b.ToTable("DRequisicoes");

                    b.HasData(
                        new
                        {
                            requisicaoId = 1,
                            dataDevolucao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dataRequisicao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            livroId = 2,
                            localidadeId = 1
                        },
                        new
                        {
                            requisicaoId = 2,
                            dataDevolucao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dataRequisicao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            livroId = 1,
                            localidadeId = 2
                        },
                        new
                        {
                            requisicaoId = 3,
                            dataDevolucao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dataRequisicao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            livroId = 4,
                            localidadeId = 1
                        },
                        new
                        {
                            requisicaoId = 4,
                            dataDevolucao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dataRequisicao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            livroId = 3,
                            localidadeId = 2
                        });
                });

            modelBuilder.Entity("Livraria.Usuario", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("bilheteIdentidade")
                        .HasColumnType("int");

                    b.Property<int>("codigoPostal")
                        .HasColumnType("int");

                    b.Property<int>("contribuinte")
                        .HasColumnType("int");

                    b.Property<DateTime?>("dataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroPorta")
                        .HasColumnType("int");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.HasKey("usuarioId");

                    b.ToTable("DUsuarios");

                    b.HasData(
                        new
                        {
                            usuarioId = 1,
                            bilheteIdentidade = 6666666,
                            codigoPostal = 2825420,
                            contribuinte = 294260250,
                            email = "aecmar@hotmail.com",
                            fracao = "anexo a",
                            morada = "Rua Vitimas da Guerra",
                            nomeUsuario = "Alexandre Couto",
                            numeroPorta = 30,
                            telefone = 222222222
                        },
                        new
                        {
                            usuarioId = 2,
                            bilheteIdentidade = 7777777,
                            codigoPostal = 1234567,
                            contribuinte = 289076145,
                            email = "jg@hotmail.com",
                            fracao = "na",
                            morada = "Rua Lisboa",
                            nomeUsuario = "João Golçalves",
                            numeroPorta = 40,
                            telefone = 333333333
                        },
                        new
                        {
                            usuarioId = 3,
                            bilheteIdentidade = 8888888,
                            codigoPostal = 7654321,
                            contribuinte = 876956456,
                            email = "apjose@hotmail.com",
                            fracao = "2E",
                            morada = "Rua Almirante reis",
                            nomeUsuario = "Pedro Jose",
                            numeroPorta = 3,
                            telefone = 444444444
                        });
                });

            modelBuilder.Entity("Livraria.Autoria", b =>
                {
                    b.HasOne("Livraria.Autor", "Autor")
                        .WithMany("Autorias")
                        .HasForeignKey("autorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livraria.Livro", "Livro")
                        .WithMany("Autorias")
                        .HasForeignKey("livroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Livraria.Livro", b =>
                {
                    b.HasOne("Livraria.Editora", "Editora")
                        .WithMany("Livros")
                        .HasForeignKey("editoraId");

                    b.HasOne("Livraria.Usuario", null)
                        .WithMany("Livros")
                        .HasForeignKey("usuarioId");
                });

            modelBuilder.Entity("Livraria.Requisicao", b =>
                {
                    b.HasOne("Livraria.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("livroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livraria.Localidade", "Localidade")
                        .WithMany()
                        .HasForeignKey("localidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livraria.Usuario", null)
                        .WithMany("Requisicoes")
                        .HasForeignKey("usuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}