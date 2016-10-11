using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionBibliotecaMVC.Models
{
    public class Libro
    {
        private Guid _codLibro;
        private string _titulo;
        private Autor _autor;

        public Libro()
        {
            this._codLibro = new Guid("-1");
            this._titulo = "";
            this._autor = new Autor();
        }
        public Guid CodLibro
        {
            get
            {
                return _codLibro;
            }

            set
            {
                _codLibro = value;
            }
        }

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        public Autor Autor
        {
            get
            {
                return _autor;
            }

            set
            {
                _autor = value;
            }
        }
    }
}