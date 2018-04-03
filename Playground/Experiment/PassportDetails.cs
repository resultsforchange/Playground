namespace Playground.Experiment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PassportDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pk_Passport_Id { get; set; }

        [StringLength(255)]
        public string Passport_Number { get; set; }

        public int? Fk_Person_Id { get; set; }

        public virtual Person Person { get; set; }
    }
}
