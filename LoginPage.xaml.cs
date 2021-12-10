﻿using QryptIdApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QryptIdApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        User _user;
        public LoginPage(User user)
        {
            _user = user;
            InitializeComponent();
        }

        

        public async void OnClick(object sender, EventArgs e)
        {
            var qrPage = new QRPage(_user);
            Console.WriteLine(_user.Id);
            await Navigation.PushAsync(qrPage);
        }
        public async void QrOnClick(object sender, EventArgs e)
        {
            var qrPage = new ScanPage();
            await Navigation.PushAsync(qrPage);
        }
    }
}