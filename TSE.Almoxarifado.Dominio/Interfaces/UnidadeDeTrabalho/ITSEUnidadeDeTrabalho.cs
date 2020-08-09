using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSE.Almoxarifado.Dominio.Interfaces.Repositorios;

namespace TSE.Almoxarifado.Dominio.Interfaces.UnidadeDeTrabalho
{
    public interface ITSEUnidadeDeTrabalho
    {
        void InicieTransacao();

        void FinalizeTransacao();
        void SalveAlteracoes();

        IRepositorioItem ObtenhaRepositorioItem();
    }
}
