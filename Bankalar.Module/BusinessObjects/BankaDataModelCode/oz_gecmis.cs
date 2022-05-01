using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.ConditionalAppearance;

namespace Bankalar.Module.BusinessObjects.dbDeneme2
{
    [DefaultClassOptions]
    public partial class OzGecmis
    {
        public OzGecmis(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
