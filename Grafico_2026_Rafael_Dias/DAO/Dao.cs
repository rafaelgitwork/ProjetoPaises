using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.DAO
{
    internal abstract class Dao
    {
        public abstract string Salvar(object obj);

        public abstract string CarregarObj(object obj);

        public abstract List<object> CarregarColecao(object obj);

        public abstract List<object> Pesquisar(object obj);

        public abstract string Excluir(object obj);
    }
}
