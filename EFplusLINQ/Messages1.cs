namespace EFplusLINQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Messages")]
    public partial class Messages1
    {
        public int Id { get; set; }

        public int ThemeId { get; set; }

        public int UserId { get; set; }

        public string MessageText { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
