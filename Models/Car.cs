using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace CarRegistry.Models
{
    public class Car
    {
        [Key]
        [Display(Name ="ID")]
        public int CarId { get; set; }
        [Display(Name = "Brand")]
        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName ="varchar(250)")]
        public string CarBrand { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Model")]
        [Column(TypeName = "varchar(250)")]
        public string CarModel { get; set; }
        [Display(Name = "Engine Capacity")]
        [Column(TypeName = "nvarchar(250)")]
        public int EngineCapacity { get; set; }
        [Display(Name = "Power")]
        [Column(TypeName = "nvarchar(250)")]
        public int EnginePower { get; set; }
        [Display(Name = "N.O. Cylinders")]
        [Column(TypeName = "nvarchar(250)")]
        public int NumberOfCylinders { get; set; }

    }
}
