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
        public int CarId { get; set; }
        [Required]
        [Column(TypeName ="varchar(250)")]
        public string CarBrand { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string CarModel { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public int EngineCapacity { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public int EnginePower { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public int NumberOfCylinders { get; set; }

    }
}
