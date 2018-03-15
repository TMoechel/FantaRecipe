using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.DomainModel
{
    public interface IEntity
    {
        Int64 Oid { get; set; }
    }

    public class Entity : IEntity
    {
        public virtual Int64 Oid { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual Guid? CreatedUserId { get; set; }
        public virtual Guid? DeletedUserId { get; set; }
        public virtual Guid? UpdatedUserId { get; set; }
    }
}
