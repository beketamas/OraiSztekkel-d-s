using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai
{
    internal class Dogs
    {
        string name;
        string breed;
        string age;
        string owner_id;

        public Dogs(string sor)
        {
            string[] tomb = sor.Split(';');
            this.name = tomb[0];
            this.breed = tomb[1];
            this.age = tomb[2];
            this.owner_id = tomb[3];
        }

        public string Name  => name;
        public string Breed  => breed; 
        public string Age  => age;
        public string Owner_id  => owner_id; 
    }
}
