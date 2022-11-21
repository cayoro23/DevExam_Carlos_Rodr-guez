using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExam.Model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int Number { get; set; }
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Account()
        {

        }

        public Account (int number, double amount)
        {
            Number = number;
            Amount = amount;
        }
    }
}
