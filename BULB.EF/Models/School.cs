using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BULB.EF.Models
{
    [Table("SCHOOL")]
    public partial class School
    {
        [Key]
        [Column("SCHOOL_ID")]
        [Precision(8)]
        public int SchoolId { get; set; }
        [Column("SCHOOL_NAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
    }
}
