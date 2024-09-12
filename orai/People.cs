using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai
{
    internal class People
    {
        string firstName;
        string lastName;
        string id;
        List<Dogs> listaKutya;

        public People(string sor)
        {
            string[] tomb = sor.Split(';');
            this.firstName = tomb[0];
            this.lastName = tomb[1];
            this.id = tomb[2];
            listaKutya = [];
        }

        public string FirstName => firstName;
        public string LastName => lastName;
        public string Id => id;
        public int GetEletkor => int.Parse(id.Split('-')[1]);
        public List<Dogs> ListaKutyak => listaKutya; 
        public void listaTolt(Dogs kutya) => listaKutya.Add(kutya); 
    }
}
