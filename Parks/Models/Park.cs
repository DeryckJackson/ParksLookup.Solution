using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required(ErrorMessage = "Name is Required")]
    [StringLength(255)]
    public string Name { get; set; }
    [StringLength(255)]
    public string Address { get; set; }
    [Required(ErrorMessage = "City is Required")]
    [StringLength(255)]
    public string City { get; set; }
    [Required(ErrorMessage = "State is Required")]
    [StringLength(2, MinimumLength = 2)]
    public string State { get; set; }
    [Required(ErrorMessage = "Zip is Required")]
    [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
    public string Zipcode { get; set; }
    [StringLength(255)]
    public string Hours { get; set; }
    public bool OpenForSeason { get; set; } = false;
    public bool HasVisitorCenter { get; set; } = false;
    public bool HasCamping { get; set; } = false;
  }
}