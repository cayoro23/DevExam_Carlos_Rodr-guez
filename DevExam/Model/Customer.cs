using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExam.Model
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public List<Account> Accounts { get; set; }

        public Customer()
        {

        }

        public Customer(int id, string name, string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
        }
        public Customer(int id, string name, string lastname, List<Account> accounts)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Accounts = accounts;
        }

        public Customer(string name)
        {
            Name = name;
        }
    }
}
