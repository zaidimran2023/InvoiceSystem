using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace InvoiceSystem.Models
{
    public class InvoiceModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Precision(18, 2)] // ✅ Correct precision for SQL Server
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        [Required]
        public string Status { get; set; }  // e.g. "Paid", "Unpaid"
    }
}
