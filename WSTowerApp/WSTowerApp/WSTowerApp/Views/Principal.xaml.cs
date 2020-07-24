﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTowerApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        private bool acessoLivre;

        public static IList<Evento> Evento { get; private set; }
        //private ViewModel _viewModel = new ViewModel();
        
        public Principal()
        {
            InitializeComponent();
            //this.BindingContext = this._viewModel;

            Evento = new List<Evento>();
            
            Evento.Add(new Evento
            {
               ID = 1,
               Favorito = "Não Favoritado",
               DataHora = Convert.ToDateTime("20/07/2020 20:00"),
               NomeEvento = "Ponte Preta X Grêmio Novorizontino",
               NomeEstadio = "Estádio Cícero Pompeu de Toledo | São Paulo - Morumbi",
               NomeTipoParticipacao = "Transmissão Ao Vivo",
               NomeTipoEvento = "Futebol",
               AcessoLivre = true
            });

            Evento.Add(new Evento
            {
                ID = 2,
                DataHora = Convert.ToDateTime("21/07/2020 21:00"),
                Favorito = "Favorito",
                NomeEvento = "Corinthians X Palmeiras",
                NomeEstadio = "Alianz Parque | São Paulo - Barra Funda",
                NomeTipoParticipacao = "Transmissão Ao Vivo",
                NomeTipoEvento = "Futebol",
                AcessoLivre = true
            });

            Evento.Add(new Evento
            {
                ID = 3,
                DataHora = Convert.ToDateTime("21/07/2020 17:00"),
                Favorito = "Não Favoritado",
                NomeEvento = "Flamengo X Fluminense",
                NomeEstadio = "Estádio Jornalista Mário Filho | Rio de Janeiro - Maracanã",
                NomeTipoParticipacao = "Para Assistir No Local",
                NomeTipoEvento = "Futebol",
                AcessoLivre = true
            });
            
            Evento.Add(new Evento
            {
                ID = 4,
                DataHora = Convert.ToDateTime("21/07/2020 20:30"),
                Favorito = "Favorito",
                NomeEvento = "Santos X São Paulo",
                NomeEstadio = "Estádio Urbano Caldeira | Santos - Vila Belmiro",
                NomeTipoParticipacao = "Transmissão Ao Vivo",
                NomeTipoEvento = "Futebol",
                AcessoLivre = true
            }); 
            
            Evento.Add(new Evento
            {
                ID = 5,
                DataHora = Convert.ToDateTime("22/07/2020 13:00"),
                Favorito = "Não Favoritado",
                NomeEvento = "Campeonato Brasileiro de League of Legends",
                NomeEstadio = "Arena Corinthians | São Paulo - Itaquera",
                NomeTipoParticipacao = "Para Assistir No Local",
                NomeTipoEvento = "E-Sports",
                AcessoLivre = true
            }); 
            
            Evento.Add(new Evento
            {
                ID = 6,
                DataHora = Convert.ToDateTime("22/07/2020 11:00"),
                Favorito = "Favorito",
                NomeEvento = "Feira de Artesanato",
                NomeEstadio = "Jockey CLub | São Paulo - Cidade Jardim",
                NomeTipoParticipacao = "Para Participar",
                NomeTipoEvento = "Feira",
                AcessoLivre = true
            }); 
            
            Evento.Add(new Evento
            {
                ID = 7,
                DataHora = Convert.ToDateTime("24/07/2020 16:00"),
                Favorito = "Favorito",
                NomeEvento = "Feira de Artesanato Alternativa",
                NomeEstadio = "Estádio Caiu na Vila o Peixe Fuzila | Santos - Vila Belmiro",
                NomeTipoParticipacao = "Para Participar",
                NomeTipoEvento = "Feira",
                AcessoLivre = true
            });

            Evento.Add(new Evento
            {
                ID = 8,
                DataHora = Convert.ToDateTime("25/07/2020 23:00"),
                Favorito = "Favorito",
                NomeEvento = "Ed Sheeran - Turnê",
                NomeEstadio = "Estádio Governador Magalhães Pinto (Mineirão) | Belo Horizonte - São José",
                NomeTipoParticipacao = "Para Assistir no Local",
                NomeTipoEvento = "Música",
                AcessoLivre = true
            });

            Evento.Add(new Evento
            {
                ID = 9,
                DataHora = Convert.ToDateTime("24/07/2020 19:00"),
                Favorito = "Não Favoritado",
                NomeEvento = "120 Anos de Mamonas Assasinas",
                NomeEstadio = "Estádio Cícero Pompeu de Toledo | São Paulo - Morumbi",
                NomeTipoParticipacao = "Para Assistir no Local",
                NomeTipoEvento = "Música",
                AcessoLivre = true
            });

            Evento.Add(new Evento
            {
                ID = 10,
                DataHora = Convert.ToDateTime("24/07/2020 20:00"),
                Favorito = "Favorito",
                NomeEvento = "Ferroviária X Portuguesa",
                NomeEstadio = "Estádio Municipal Paulo Machado de Carvalho | São Paulo - Pacaembu",
                NomeTipoParticipacao = "Transmissão Ao Vivo",
                NomeTipoEvento = "Futebol",
                AcessoLivre = true
            });

            EventosLista.ItemsSource = Evento;
        }

        private void buscarEventos_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = buscarEventos.Text;

            if(keyword.Length >= 1)
            {
                var sugestao = Evento.Where(c => c.ToString().ToLower().Contains(keyword.ToLower()));

                EventosLista.ItemsSource = sugestao;
                EventosLista.IsVisible = true;
            }
            else
            {
                EventosLista.IsVisible = false;
            }
        }

        private void EventosLista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item as string == null)
            {
                return;
            }
            else
            {
                EventosLista.ItemsSource = Evento.Where(c => c.Equals(e.Item as string));
                EventosLista.IsVisible = true;
                buscarEventos.Text = e.Item as string;
            }
        }
    }
}