using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWPF.Model
{
        public class PersonViewModel
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int? Edad { get; set; }
            public string Email { get; set; }
        }    
}
