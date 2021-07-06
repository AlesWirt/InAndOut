using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut_MVC.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        
        [DisplayName("Expense name")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public int Amount { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ExpenseCategory Category { get; set; }
    }
}
