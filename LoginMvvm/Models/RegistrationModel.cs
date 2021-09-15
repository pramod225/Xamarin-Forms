using System;
using System.Collections.Generic;
using Realms;

namespace LoginMvvm.Models
{
    public class RegistrationModel :RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string PhoneNo { get; set; }
        public string ImageUrl { get; set; }


    }
    
}
