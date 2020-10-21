using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace yxyl.leanr.Albums
{
    [Table("T_Category")]
    public class Category : Entity<Guid>, ISoftDelete, IAuditedObject
    {
        public Category()
        {

        }

        [MaxLength(50)]
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? LastModifierId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
