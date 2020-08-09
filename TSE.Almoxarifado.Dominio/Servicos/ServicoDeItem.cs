using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSE.Almoxarifado.Dominio.Entidades;
using TSE.Almoxarifado.Dominio.Interfaces.Repositorios;
using TSE.Almoxarifado.Dominio.Interfaces.UnidadeDeTrabalho;

namespace TSE.Almoxarifado.Dominio.Servicos
{
    public class ServicoDeItem : ServicoBase
    {
        public IRepositorioItem  Repositorio;

        public ServicoDeItem(
            ITSEUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
            this.Repositorio = unidadeDeTrabalho.ObtenhaRepositorioItem();
        }

        public IEnumerable<Item> ObtenhaTodod()
        {
            return this.Repositorio.ObtenhaTodos();
        }

        public Item ObtenhaItem(Guid id)
        {
            return this.Repositorio.ObtenhaPorId(id);
        }

        public List<Item> Filtre(string nome)
        {
            return this.Repositorio.Filtre(item => item.NomeItem.ToUpper().Contains(nome.ToUpper())).ToList();
        }

        public void Adicione(Item item)
        {
            this.Repositorio.Adicione(item);
            base.UnidadeDeTrabalho.SalveAlteracoes();

        }

        public void Atualize(Item item)
        {
            this.Repositorio.Atualize(item);
            base.UnidadeDeTrabalho.SalveAlteracoes();

        }
        public void Remova(Item item)
        {
            this.Repositorio.Remova(item);
            base.UnidadeDeTrabalho.SalveAlteracoes();

        }

    }
}
