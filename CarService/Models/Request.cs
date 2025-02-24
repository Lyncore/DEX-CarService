using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Models
{
    internal class Request
    {
        public int Id { get; set; }
        public int RequesterId { get; set; }
        public User Requester { get; set; }
        public int CarId {  get; set; }
        public Car Car { get; set; }
        public string VIN { get; set; }
        [NotNull, MaxLength(100)]
        public string Description { get; set; }
        [NotNull] 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string? Message { get; set; }
        public int? MechanicId { get; set; }
        public User? Mechanic { get; set; }
        public byte? Rank { get; set; }
    }
}
