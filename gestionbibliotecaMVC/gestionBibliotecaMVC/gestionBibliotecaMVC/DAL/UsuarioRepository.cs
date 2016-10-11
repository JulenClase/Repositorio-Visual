using gestionBibliotecaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionBibliotecaMVC.DAL
{
    interface UsuarioRepository
    {
        IList<Usuario> getAll();
        Usuario getById(Guid codigo);
        Usuario update(Guid codigo);
        void delete(Guid codigo);
        Guid create(Usuario usuario);
    }
}
