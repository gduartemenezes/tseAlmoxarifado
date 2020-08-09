using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSE.Almoxarifado.Dominio.Interfaces.UnidadeDeTrabalho;

namespace TSE.Almoxarifado.Dominio.Servicos
{
    public class ServicoBase
    {
        protected ITSEUnidadeDeTrabalho UnidadeDeTrabalho { get; set; }

        public ServicoBase(ITSEUnidadeDeTrabalho unidadeDeTrabalho)
        {
            this.UnidadeDeTrabalho = unidadeDeTrabalho;
        }
    }
}
