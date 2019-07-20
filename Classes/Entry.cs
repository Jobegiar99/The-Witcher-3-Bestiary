using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestiary.Classes
{
    class Entry
    {
        /// <summary>
        /// The Name of the creature
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the creature (attacks, movement, etc.)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// What the creature drops if killed
        /// </summary>
        public string Loot { get; set; }

        /// <summary>
        /// Where is the creature found.
        /// </summary>
        public string Ocurrence { get; set; }

        /// <summary>
        /// What is the creature weak to.
        /// </summary>
        public string Susceptibility { get; set; }

        /// <summary>
        /// The path for the image of the creature
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// A creature that is a variation of this one.
        /// </summary>
        

        /// <summary>
        /// Constructor of the Creature
        /// </summary>
        /// <param name="Name">Name of the Creature</param>
        /// <param name="Description">Description of the Creature</param>
        /// <param name="Loot">Loot of the creature</param>
        /// <param name="Ocurrence">Ocurrence of the creature</param>
        /// <param name="Susceptibility">Susceptibility of the Creature</param>
        /// <param name="ImagePath">The ImagePath</param>
        public Entry(string Name,string Description,string Loot,string Ocurrence,string Susceptibility,string ImagePath)
        {
            this.Name = Name;
            this.Description = Description;
            this.Loot = Loot;
            this.Ocurrence = Ocurrence;
            this.Susceptibility = Susceptibility;
            this.ImagePath = ImagePath;
            
        }
    }
}
