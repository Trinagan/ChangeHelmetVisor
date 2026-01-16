using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeHelmetVisor.Models
{
    public record ModConfig
    {
        public bool AllFaceShields { get; set; }
        public string MaskType { get; set; }
        public Dictionary<string, string> SpecificFaceShields { get; set; } = new();
    }
}
