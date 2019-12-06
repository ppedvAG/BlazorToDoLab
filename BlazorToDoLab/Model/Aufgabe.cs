using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToDoLab.Model
{
    public class Aufgabe
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public bool Erledigt { get; set; }
        public bool EditModus { get; set; }
        public string Bearbeiter { get; set; }
    }
}
