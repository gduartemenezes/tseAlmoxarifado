using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSE.Infra.Data.Contexto
{
     public class AlmoxarifadoContexto : DbContext
    {
       public AlmoxarifadoContexto() : base("Server = localhost; Database=master;Trusted_Connection=True;")
        {
          
        }
    }
}
