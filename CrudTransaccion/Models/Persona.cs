using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrudTransaccion.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Name { get; set; }
        public Cargo cargo { get; set; }
        public Cargo Cargo { get; internal set; }
        public Empresa Empresa { get; set; }
    }
}
