namespace QuanlyHocSinh.Enties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string Major { get; set; }
    }
}
