using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExam.Model;

[Table("Customer")]
public class Customer
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Lastname { get; set; } = null!;
    public List<Account> Accounts { get; set; } = null!;

    public Customer() { }

    public Customer(int id, string name, string lastname, List<Account> accounts)
    {
        Id = id;
        Name = name;
        Lastname = lastname;
        Accounts = accounts;
    }
}
