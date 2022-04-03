﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace todoapp_api.Models
{
    public class SubItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Item Item { get; set; }
        [ForeignKey("FK_item_SubItem")]
        public int ItemId { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
