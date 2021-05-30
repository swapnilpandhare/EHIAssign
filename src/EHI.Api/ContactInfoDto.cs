using System;

namespace EHI.Api
{

    public class ContactInfoDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNo { get; set; }
        public bool Gender { get; set; }

    }

}
