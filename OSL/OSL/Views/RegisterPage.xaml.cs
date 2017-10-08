﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace OSL.Views
{
    public partial class RegisterPage : ContentPage
    {
        public Models.User User;

        public RegisterPage()
        {
            User = new Models.User();
            InitializeComponent();
            registerButton.Clicked += Handle_Registration;
        }

        private async void Handle_Registration(object sender, EventArgs e)
        {
            User.Organization_Country = "USA";
            User.Organization_Name = orgName.Value;
            await DisplayAlert(User.Organization_Country, "a", "b");
            //await DisplayAlert(User.Organization_Name, User.Person_Name, User.Organization_City);
            /*string url = "http://secondhelpingweb.azurewebsites.net/api/users";
            var request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            request.Method = "POST";*/

            //var json = JsonConvert.SerializeObject(User);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

		}
    }
}
