using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionBibliotecaMVC.Models
{
    public class Autor
    {
        private Guid _codAutor;
        private string _nombre;

        public Autor()
        {
            this._codAutor = new Guid("-1");
            this._nombre = "";
        }

        public Guid CodAutor
        {
            get
            {
                return _codAutor;
            }

            set
            {
                _codAutor = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }
    }
}