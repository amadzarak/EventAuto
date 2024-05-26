namespace EventAuto.Models;

using System.ComponentModel.DataAnnotations;
public class User
{
    [Key]
    public int uid { get; set; }
    public string username { get; set; } = null!;
    public string password { get; set; } = null!;
    public DateTime created_at { get; set; }
    public bool recieve_promotions { get; set; }
}


