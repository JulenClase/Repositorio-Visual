using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionBibliotecaMVC.Models
{
    public class Prestamo
    {
        private DateTime _fRecogida;
        private DateTime _fDevolucion;
        private Guid _idPrestamo;
        private Usuario _usuario;
        private Ejemplar _ejemplar;

        public Prestamo()
        {
            this.FRecogida = _fRecogida;
            this.FDevolucion = _fDevolucion;
            this.IdPrestamo = _idPrestamo;
            this.Usuario = _usuario;
            this.Ejemplar = _ejemplar;
        }

        public DateTime FRecogida
        {
            get
            {
                return _fRecogida;
            }

            set
            {
                _fRecogida = value;
            }
        }

        public DateTime FDevolucion
        {
            get
            {
                return _fDevolucion;
            }

            set
            {
                _fDevolucion = value;
            }
        }

        public Guid IdPrestamo
        {
            get
            {
                return _idPrestamo;
            }

            set
            {
                _idPrestamo = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
            }
        }

        public Ejemplar Ejemplar
        {
            get
            {
                return _ejemplar;
            }

            set
            {
                _ejemplar = value;
            }
        }

        
    }
}