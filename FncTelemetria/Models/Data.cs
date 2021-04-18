using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FncTelemetria.Models
{
    class Data
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
