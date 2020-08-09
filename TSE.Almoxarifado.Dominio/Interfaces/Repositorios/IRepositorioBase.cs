using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSE.Almoxarifado.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<T> where T : class
    {
        T ObtenhaPorId(Guid id);

        IEnumerable<T> ObtenhaTodos();

        IEnumerable<T> Filtre(Func<T, bool> expressaoFiltro);

        void Adicione(T objeto);
        void Atualize(T objeto);
        void Remova(T objeto);
    }
}
