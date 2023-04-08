using System.ComponentModel.DataAnnotations;

namespace Core.Models.Base;

public class PersonBase
{
    [Key]
    public int Id { get; set; }
    [MaxLength(64)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(64)]
    public string Email { get; set; } = string.Empty;
    [MaxLength(24)]
    public string PhoneNumber { get; set; } = string.Empty;

}
