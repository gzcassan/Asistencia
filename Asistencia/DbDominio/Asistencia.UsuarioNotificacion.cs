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

namespace Asistencia.DbDominio
{

    /// <summary>
    /// There are no comments for Asistencia.DbDominio.UsuarioNotificacion, Asistencia in the schema.
    /// </summary>
    public partial class UsuarioNotificacion
    {

        #region Extensibility Method Definitions

        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        #endregion
        /// <summary>
        /// There are no comments for UsuarioNotificacion constructor in the schema.
        /// </summary>
        public UsuarioNotificacion()
        {
            OnCreated();
        }


        /// <summary>
        /// There are no comments for CveUsuarioNotificacion in the schema.
        /// </summary>
        public virtual int CveUsuarioNotificacion
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for NombreUsuario in the schema.
        /// </summary>
        public virtual string NombreUsuario
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        public virtual string Email
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
    }

}