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
    /// There are no comments for Asistencia.DbDominio.Usuario, Asistencia in the schema.
    /// </summary>
    public partial class Usuario
    {

        #region Extensibility Method Definitions

        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        #endregion
        /// <summary>
        /// There are no comments for Usuario constructor in the schema.
        /// </summary>
        public Usuario()
        {
            this.EsAdmin = false;
            this.Habilitado = true;
            this.Activo = true;
            Loginsql = Constantes.TEXTO_BLANCO;
            this.FechaCreacion = DateTime.Now;
            this.FechaModificacion = DateTime.Now;
            this.Tipo = 1;
            OnCreated();
        }


        /// <summary>
        /// There are no comments for CveUsuario in the schema.
        /// </summary>
        public virtual int CveUsuario
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Loginsql in the schema.
        /// </summary>
        public virtual string Loginsql
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
        /// There are no comments for Activo in the schema.
        /// </summary>
        public virtual bool Activo
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Username in the schema.
        /// </summary>
        public virtual string Username
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        public virtual string Password
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for EsAdmin in the schema.
        /// </summary>
        public virtual System.Nullable<bool> EsAdmin
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
        /// There are no comments for CorreoElectronico in the schema.
        /// </summary>
        public virtual string CorreoElectronico
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Tipo in the schema.
        /// </summary>
        public virtual System.Nullable<short> Tipo
        {
            get;
            set;
        }




        /// <summary>
        /// There are no comments for Oficina_cve_oficina in the schema.
        /// </summary>
        public virtual Oficina Oficina_cve_oficina
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Perfil_id_perfil in the schema.
        /// </summary>
        public virtual Perfil Perfil_id_perfil
        {
            get;
            set;
        }

        public virtual string NombreClaseCSS
        {

            get
            {
                return Activo ? "css_registro_activo" : "css_registro_inactivo";
            }
        }

        public virtual string NombrePerfil
        {

            get
            {
                return Perfil_id_perfil != null ? Perfil_id_perfil.Nombre : Constantes.TEXTO_BLANCO;
            }
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


    }

}
