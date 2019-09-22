using System;
using System.Collections.Generic;
using System.Text;

namespace flwup.ApplicationCore.Model
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
    }

}
