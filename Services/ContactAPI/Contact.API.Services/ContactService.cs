using Contact.API.Infrastructrue;
using Contact.API.Models;
using System;


namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDto GetContactById(int Id)
        {
            return new ContactDto()
            {
                Id=Id,
                FirstName = "Fatih",
                LastName = "Dindar"
            };
        }
    }
}
