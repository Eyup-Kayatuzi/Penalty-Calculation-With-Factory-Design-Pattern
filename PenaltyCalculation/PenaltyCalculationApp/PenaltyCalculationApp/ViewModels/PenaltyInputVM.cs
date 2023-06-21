using PenaltyCalculationApp.Datas;
using System.ComponentModel.DataAnnotations;

namespace PenaltyCalculationApp.ViewModels
{
    public class PenaltyInputVM
    {
        [Required(ErrorMessage = "Please enter checkout date")]
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }
        [Required(ErrorMessage = "Please enter returned date")]
        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }
        [Required(ErrorMessage = "Please select your country")]
        public Country Country { get; set; } = null!; // for taking currency
        public List<DateTime> dateTimes22 { get; set; }
    }
}
