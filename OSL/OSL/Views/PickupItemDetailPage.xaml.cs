﻿using System;

using Xamarin.Forms;

namespace OSL
{
    public partial class PickupItemDetailPage : ContentPage
    {
        PickupItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public PickupItemDetailPage()
        {
            InitializeComponent();

            var item = new PickupItem
            {
                Title = "New Item posted"
            };

            viewModel = new PickupItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public PickupItemDetailPage(PickupItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;

            Accept.Clicked += Accept_Clicked;
        }

        private void Accept_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Information", "Thank you for accepting the donation", "OK");
            this.Navigation.PopAsync();//.PushModalAsync(new PickupItemsPage());
        }
    }
}
