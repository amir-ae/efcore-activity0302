﻿using InventoryModels.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryModels
{
    public abstract class FullAuditModel : IIdentityModel, IAuditedModel, IsActivatableModel, ISoftDeletable
    {
        [Key]
        public int Id { get ; set; }

        public Guid? CreatedByUserId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        
        public Guid? LastModifiedUserId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
