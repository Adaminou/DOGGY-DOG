using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDog
{
    class Doggy
    {
        // Attribut privé du CHIEN DOGGY DOG
        private string _nom;
        private string _race;
        private uint _age;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private bool _genre;
        private bool _sterilise;
        private bool _dresse;

        public Doggy(string nom, string race, uint age, bool enOrdreDeVaccin, bool puce, bool genre, bool sterilise, bool dresse)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _enOrdreDeVaccin = enOrdreDeVaccin;
            _puce = puce;
            _genre = genre;
            _sterilise = sterilise;
            _dresse = dresse;
        }

        public string AfficheCaracteristiques()
        {
            string chaine = "_nom" + _nom +

            "race" + _race +
            "age" + _age +
            "enOrdreDeVaccin" + _enOrdreDeVaccin+
            "puce" + _puce +
            "genre" + _genre +
            "sterilise" + _sterilise +
            "dresse" + _dresse;
            return chaine;
        }



    }
}
