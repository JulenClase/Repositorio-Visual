using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionBibliotecaMVC.Models
{
    public class Ejemplar : Libro
    {
        private Guid _idEjemplar;
        private string _isbn;
        private DateTime _fPublicacion;
        private int _nPaginas;
        private Editorial _editorial;
        private IList<Prestamo> _prestamos;

        public Ejemplar()
        {
            this.IdEjemplar = new Guid("-1");
            this.Isbn = "";
            this.NPaginas = 0;
            this.Editorial = new Editorial();
            this.FPublicacion = new DateTime();
            this.Prestamos = null;
        }

        public Guid IdEjemplar
        {
            get
            {
                return _idEjemplar;
            }

            set
            {
                _idEjemplar = value;
            }
        }

        public string Isbn
        {
            get
            {
                return _isbn;
            }

            set
            {
                _isbn = value;
            }
        }

        public DateTime FPublicacion
        {
            get
            {
                return _fPublicacion;
            }

            set
            {
                _fPublicacion = value;
            }
        }

        public int NPaginas
        {
            get
            {
                return _nPaginas;
            }

            set
            {
                _nPaginas = value;
            }
        }

        public Editorial Editorial
        {
            get
            {
                return _editorial;
            }

            set
            {
                _editorial = value;
            }
        }

        public IList<Prestamo> Prestamos
        {
            get
            {
                return _prestamos;
            }

            set
            {
                _prestamos = value;
            }
        }

       
    }
}