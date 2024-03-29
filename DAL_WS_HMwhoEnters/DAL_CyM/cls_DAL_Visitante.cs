﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_WS_HMwhoEnters.DAL_CyM
{
    public class cls_DAL_Visitante
    {
        private string _APELLIDOS;
        private string _CED_ULT_VISITADO;
        private string _CEDULA;
        private string _CORREO;
        private char _ESTADO;
        private DateTime _FECHA_CREACION;
        private string _GENERO;
        private int _ID_TIPO_VISITANTE;
        private string _NOMBRE;
        private string _TEL_VISITANTE;
        private int _USUARIO_CREACION;

        public string APELLIDOS
        {
            get
            {
                return _APELLIDOS;
            }

            set
            {
                _APELLIDOS = value;
            }
        }

        public string CED_ULT_VISITADO
        {
            get
            {
                return _CED_ULT_VISITADO;
            }

            set
            {
                _CED_ULT_VISITADO = value;
            }
        }

        public string CEDULA
        {
            get
            {
                return _CEDULA;
            }

            set
            {
                _CEDULA = value;
            }
        }

        public string CORREO
        {
            get
            {
                return _CORREO;
            }

            set
            {
                _CORREO = value;
            }
        }

        public char ESTADO
        {
            get
            {
                return _ESTADO;
            }

            set
            {
                _ESTADO = value;
            }
        }

        public DateTime FECHA_CREACION
        {
            get
            {
                return _FECHA_CREACION;
            }

            set
            {
                _FECHA_CREACION = value;
            }
        }

        public string GENERO
        {
            get
            {
                return _GENERO;
            }

            set
            {
                _GENERO = value;
            }
        }

        public int ID_TIPO_VISITANTE
        {
            get
            {
                return _ID_TIPO_VISITANTE;
            }

            set
            {
                _ID_TIPO_VISITANTE = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return _NOMBRE;
            }

            set
            {
                _NOMBRE = value;
            }
        }

        public string TEL_VISITANTE
        {
            get
            {
                return _TEL_VISITANTE;
            }

            set
            {
                _TEL_VISITANTE = value;
            }
        }

        public int USUARIO_CREACION
        {
            get
            {
                return _USUARIO_CREACION;
            }

            set
            {
                _USUARIO_CREACION = value;
            }
        }
    }
}
