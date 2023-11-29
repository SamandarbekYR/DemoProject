using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Domain.Entities
{
    public class BaseEntity 
    {
        [Key,Required]
        [Column("id")]
        public Guid Id { get; set; }    
    }
}
