using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionBibliotecaMVC.Models
{
    public class Editorial
    {
        private Guid _codEditorial;
        private string _nombre;

        public Editorial()
        {
            this._codEditorial = new Guid("-1");
            this._nombre = "";
        }

        public Guid CodLibro
        {
            get
            {
                return _codEditorial;
            }

            set
            {
                _codEditorial = value;
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