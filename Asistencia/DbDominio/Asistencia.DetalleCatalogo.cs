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
    /// There are no comments for Asistencia.DbDominio.DetalleCatalogo, Asistencia in the schema.
    /// </summary>
    public partial class DetalleCatalogo
    {

        #region Extensibility Method Definitions

        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        #endregion
        /// <summary>
        /// There are no comments for DetalleCatalogo constructor in the schema.
        /// </summary>
        public DetalleCatalogo()
        {
            OnCreated();
        }


        /// <summary>
        /// There are no comments for CveDetalleCatalogos in the schema.
        /// </summary>
        public virtual int CveDetalleCatalogos
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Numero in the schema.
        /// </summary>
        public virtual short Numero
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Abreviatura in the schema.
        /// </summary>
        public virtual string Abreviatura
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Descripcion in the schema.
        /// </summary>
        public virtual string Descripcion
        {
            get;
            set;
        }




        /// <summary>
        /// There are no comments for Catalogo in the schema.
        /// </summary>
        public virtual Catalogo Catalogo
        {
            get;
            set;
        }



    }

}
