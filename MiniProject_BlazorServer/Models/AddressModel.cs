using System.ComponentModel.DataAnnotations;

namespace MiniProject_BlazorServer.Models;

public class AddressModel
{
    [Required]
    public string StreetAddress { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    [StringLength(2)]
    public string Province { get; set; }

    [Required]
    [StringLength(6)]
    public string PostalCode { get; set; }
}
