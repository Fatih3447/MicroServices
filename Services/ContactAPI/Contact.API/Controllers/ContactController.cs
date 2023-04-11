using Contact.API.Infrastructrue;
using Contact.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{Id}")]
        public ContactDto Get(int Id)
        {
            return _contactService.GetContactById(Id);
        }
    }
}
