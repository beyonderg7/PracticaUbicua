using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTelemetria.Models
{
    public class Data
    {
        [Key]
        public string NameDevice { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EventDateTime { get; set; }
        [Required]
        public string Temperatura { get; set; }
        [Required]
        public string Humedad { get; set; }
    }
}
