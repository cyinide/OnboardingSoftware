﻿using OnboardingSoftware.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnboardingSoftware.App.Views.Tests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewTest : ContentPage
    {
        public ViewTest()
        {
            InitializeComponent();
            MessagingCenter.Send<Xamarin.Forms.Application>(Xamarin.Forms.Application.Current, "InitializeTest");
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (this.BindingContext is BaseViewModel viewModel)
                await viewModel.OnAppearing();
        }

        protected async override void OnDisappearing()
        {
            base.OnDisappearing();
            if (this.BindingContext is BaseViewModel viewModel)
                await viewModel.OnDisappearing();
        }
    }
}