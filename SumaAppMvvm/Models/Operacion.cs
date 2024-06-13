using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAppMvvm.Models
{
    public class Operacion
    {
        [NotNull]
        public string? value1 { get; set; }

        [NotNull]
        public string? value2 { get; set; }

        public string? result { get; set; }

    }
}
