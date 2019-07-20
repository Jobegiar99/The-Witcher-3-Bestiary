using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bestiary.Classes;

namespace Bestiary.Classes
{
    static class EntriesDone
    {
        public static Entry[] Beasts { get; set; } = new Entry[8];
        public static Entry[] CursedOnes { get; set; } = new Entry[7];
        public static Entry[] Draconids { get; set; } = new Entry[9];
        public static Entry[] Elementa { get; set; } = new Entry[11];
        public static Entry[] Hybrids { get; set; } = new Entry[9];
        public static Entry[] Insectoids { get; set; } = new Entry[13];
        public static Entry[] Necrophages { get; set; } = new Entry[16];
        public static Entry[] Ogroids { get; set; } = new Entry[9];
        public static Entry[] Relicts { get; set; } = new Entry[20];
        public static Entry[] Specters { get; set; } = new Entry[16];
        public static Entry[] Vampires { get; set; } = new Entry[13];
        public static dynamic SelectedEntry { get; set; }
        public static dynamic SelectedEntryArray { get; set; }
        public static string SelectedEntryType { get; set; }




    }
}
