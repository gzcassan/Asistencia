﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 8/11/2015 12:15:01 AM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Asistencia.Clases;

namespace Asistencia.DbDominio
{

    /// <summary>
    /// There are no comments for Asistencia.DbDominio.Empleado, Asistencia in the schema.
    /// </summary>
    public partial class Empleado
    {

        #region Extensibility Method Definitions

        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        #endregion
        /// <summary>
        /// There are no comments for Empleado constructor in the schema.
        /// </summary>
        public Empleado()
        {
            this.Habilitado = true;
            this.Activo = true;
            this.FechaAlta = DateTime.Now;
            this.FechaCreacion = DateTime.Now;
            this.FechaModificacion = DateTime.Now;
            OnCreated();
        }


        public virtual ISet<EmpleadoControlAcceso> EmpleadoControlAccesos
        {
            get;
            set;
        }

        public virtual string NombreClaseCSS
        {

            get
            {
                return (Activo != null && Activo.Value) ? "css_registro_activo" : "css_registro_inactivo";
            }
        }

        public virtual String NombrePlaza
        {
            get
            {
                return Plaza != null ? Plaza.Nombre : Constantes.TEXTO_BLANCO;

            }
        }

        /// <summary>
        /// There are no comments for CveEmpleado in the schema.
        /// </summary>
        public virtual int CveEmpleado
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for NoEmpleado in the schema.
        /// </summary>
        public virtual int NoEmpleado
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Nombre in the schema.
        /// </summary>
        public virtual string UltimaColeccion
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Nombre in the schema.
        /// </summary>
        public virtual string Nombre
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for FechaBaja in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> FechaBaja
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for FechaAlta in the schema.
        /// </summary>
        public virtual System.DateTime FechaAlta
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Tarjeta in the schema.
        /// </summary>
        public virtual string Tarjeta
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Habilitado in the schema.
        /// </summary>
        public virtual System.Nullable<bool> Habilitado
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for FechaCreacion in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> FechaCreacion
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for FechaModificacion in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> FechaModificacion
        {
            get;
            set;
        }

        /// <summary>
        /// There are no comments for Usuario_cve_usuario_alta in the schema.
        /// </summary>
        public virtual Usuario Usuario_cve_usuario_alta
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Usuario_creado_por in the schema.
        /// </summary>
        public virtual Usuario Usuario_creado_por
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Usuario_modificado_por in the schema.
        /// </summary>
        public virtual Usuario Usuario_modificado_por
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Plaza in the schema.
        /// </summary>
        public virtual Plaza Plaza
        {
            get;
            set;
        }




        /// <summary>
        /// There are no comments for Habilitado in the schema.
        /// </summary>
        public virtual System.Nullable<bool> Activo
        {
            get;
            set;
        }
    }

}
