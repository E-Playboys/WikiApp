﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EWiki.XF.ViewModels;
using Plugin.Geolocator;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace EWiki.XF.Views.Popups
{
    public partial class PokemonGoAccountPopup : PopupPage
    {
        public PokemonGoAccountPopup()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(10000);
            var pokemonGoAccountPopupViewModel = BindingContext as PokemonGoAccountPopupViewModel;
            if (pokemonGoAccountPopupViewModel != null)
            {
                pokemonGoAccountPopupViewModel.Account.Latitude = position.Latitude;
                pokemonGoAccountPopupViewModel.Account.Longitude = position.Longitude;
            }
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
