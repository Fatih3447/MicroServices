﻿using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Infrastructrue
{
    public interface IContactService
    {
        public ContactDto GetContactById(int Id);
    }
}
