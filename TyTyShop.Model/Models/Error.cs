using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TyTyShop.Model.Models
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        public int ID { get; set; }

        public string message { get; set; }

        public string Stacktrace { get; set; }

        public DateTime CreateDate { get; set; }
    }
}