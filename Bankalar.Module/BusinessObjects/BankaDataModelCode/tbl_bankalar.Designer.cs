﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace Bankalar.Module.BusinessObjects.dbDeneme2
{

    [Persistent(@"tbl_bankalar")]
    public partial class Bankalar : XPLiteObject
    {
        Guid fid;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid id
        {
            get { return fid; }
            set { SetPropertyValue<Guid>(nameof(id), ref fid, value); }
        }
        string fbankaAdi;
        [Size(50)]
        public string bankaAdi
        {
            get { return fbankaAdi; }
            set { SetPropertyValue<string>(nameof(bankaAdi), ref fbankaAdi, value); }
        }


        [Association]
        public XPCollection<Subeler> Subelers
        {
            get { return GetCollection<Subeler>(nameof(Subelers)); }
        }

        //[XafDisplayName("Subeler"), ToolTip("Subeler")]
        //[Association("Bankalar-Subeler")]
        //public XPCollection<Subeler> Subelers
        //{
        //    get { return GetCollection<Subeler>(nameof(Subelers)); }
        //}

        //Subeler sube;
        //[Association]
        //public Subeler Subeler
        //{
        //    get { return sube; }
        //    set { SetPropertyValue(nameof(Subeler), ref sube, value); }
        //}
    }

}
