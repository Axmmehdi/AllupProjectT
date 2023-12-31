﻿using System.ComponentModel.DataAnnotations;

namespace AllupProjectT.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(255)]
       public string CreatedBy { get; set; }
        public Nullable<DateTime>  CreatedAt { get; set; }
        [StringLength(255)]

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
    }
}
