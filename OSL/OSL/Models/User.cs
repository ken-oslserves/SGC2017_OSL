﻿using System;
namespace OSL.Models
{
    public class User
    {
        public string Email { get; set; }
        // From auth AccessToken
        public string OId { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        //public string Country { get; set; }
        public string OrgName { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Person_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Status { get; set; }
        public bool Verified { get; set; }
    };
}
