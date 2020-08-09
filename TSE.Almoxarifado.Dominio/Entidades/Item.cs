using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSE.Almoxarifado.Dominio.Entidades
{
    public class Item
    {
        public Guid Id { get; set; }

        public string NomeItem { get; set; }
        
        public int Quantidade { get; set; }
    }
}
