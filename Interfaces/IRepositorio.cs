using System.Collections.Generic;

namespace DIO_Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Excluir(int id);
         void Atualiza(int id, Serie entidade);
         int ProximoId();

    }
}