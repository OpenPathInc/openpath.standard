using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenPath.Standard.Base.Data.Database {

    [Table("Planets")]
    public class PlanetModel {

        [Key, Required]
        public long Id { get; set; }

        [Required, MaxLength(64)]
        public string Key { get; set; }

        [Required, MaxLength(64)]
        public string Name { get; set; }

        public double EquatorialDiameter { get; set; }

        public double EquatorialBulge { get; set; }

        public double PolarDiameter { get; set; }

        public double FlatteningRatio { get; set;  }

        public double RotationPeriod { get; set; }

        public double Density { get; set; }

        public double F { get; set; }

        public int DeviationFromF { get; set; }

    }

}
