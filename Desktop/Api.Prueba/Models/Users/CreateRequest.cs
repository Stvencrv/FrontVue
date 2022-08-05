namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateRequest
{

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

}