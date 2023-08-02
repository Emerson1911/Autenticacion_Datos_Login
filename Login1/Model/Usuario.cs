using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1.Model
{
   public class Usuario
    {

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {
            Id= Guid.NewGuid();
        }
    }
}
