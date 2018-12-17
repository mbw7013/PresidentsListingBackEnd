namespace CorcoranPresidentsBackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("President")]
    public partial class President
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string PresidentName { get; set; }

        [StringLength(200)]
        public string PresidentURL { get; set; }

        [Required]
        [StringLength(100)]
        public string Birthday { get; set; }

        [Required]
        [StringLength(100)]
        public string Birthplace { get; set; }

        [StringLength(200)]
        public string BirthplaceURL { get; set; }

        [StringLength(100)]
        public string Deathday { get; set; }

        [StringLength(100)]
        public string Deathplace { get; set; }
    }
}
