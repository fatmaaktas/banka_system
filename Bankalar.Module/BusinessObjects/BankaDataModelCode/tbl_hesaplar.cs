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
    [DefaultClassOptions]
    [XafDisplayName("Hesaplar")]
    public partial class tbl_hesaplar
    {
        public tbl_hesaplar(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
