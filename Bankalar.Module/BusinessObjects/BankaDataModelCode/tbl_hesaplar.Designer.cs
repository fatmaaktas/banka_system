//------------------------------------------------------------------------------
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

namespace Bankalar.Module.BusinessObjects.dbDeneme2
{

    public partial class tbl_hesaplar : XPLiteObject
    {
        Guid fid;
        [Key(true)]
        [ColumnDbDefaultValue("(newid())")]
        public Guid id
        {
            get { return fid; }
            set { SetPropertyValue<Guid>(nameof(id), ref fid, value); }
        }
        Guid fsube_id;
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]

        public Guid sube_id
        {
            get { return fsube_id; }
            set { SetPropertyValue<Guid>(nameof(sube_id), ref fsube_id, value); }
        }
        string fhesapNo;
        [Size(50)]
        public string hesapNo
        {
            get { return fhesapNo; }
            set { SetPropertyValue<string>(nameof(hesapNo), ref fhesapNo, value); }
        }

        [Association]
        public XPCollection<Subeler> Subelers
        {

            get { return GetCollection<Subeler>(nameof(Subelers)); }
        }



    }


}
