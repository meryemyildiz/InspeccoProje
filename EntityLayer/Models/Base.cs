using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Models
{
   public class Base<T>
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        [DataType(DataType.DateTime)]
        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
       
    }
}
