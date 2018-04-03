using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Interfaces
{
    public interface IAuditableEntity
    {
        [Required, Column(TypeName = "datetime2")]
        DateTime InsertedDateTime { get; set; }
        string InsertedBy { get; set; }
        [Required, Column(TypeName = "datetime2")]
        DateTime ModifiedDateTime { get; set; }
        string ModifiedBy { get; set; }
    }
}
