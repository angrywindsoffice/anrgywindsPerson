using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Entity
{
    [Serializable]
    public class User
    {
        public virtual int ID { get; set; }
        public virtual Guid InnerID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Memo { get; set; }

    }
}
