﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatchat.Logica
{
    class ClaseSolicitudClaseDo
    {
        private int idSolicitudClaseDo;
        private int idClase;
        private int oriClase;

        public ClaseSolicitudClaseDo()
        {

        }
        public ClaseSolicitudClaseDo(int idSolicitudClaseDo, int idClase, int oriClase)
        {
            this.idSolicitudClaseDo = idSolicitudClaseDo;
            this.idClase = idClase;
            this.oriClase = oriClase;
        }

        public int IdSolicitudClaseDo
        {
            get { return idSolicitudClaseDo; }
            set { idSolicitudClaseDo = value; }
        }
        public int IdClase
        {
            get { return idClase; }
            set { idClase = value; }
        }
        public int OriClase
        {
            get { return oriClase; }
            set { oriClase = value; }
        }
       
    }
}
