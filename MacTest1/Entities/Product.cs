﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProductTest.Entities
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
        [Unicode(false)]
        public string Description { get; set; }
        [Column("SKU")]
        [Unicode(false)]
        public string Sku { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ImagePath { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? SellingPrice { get; set; }
        public int? AvailableQty { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Type { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Weight { get; set; }
        public int? Length { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? ShippingCost { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
    }
}