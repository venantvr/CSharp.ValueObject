using System;

namespace ValueObject
{
    public struct Adresse
    {
        private readonly string _codePostal;
        private readonly string _complement;
        private readonly int _numero;
        private readonly string _rue;
        private readonly string _ville;
        // Pas de constructeur sans paramètres pour une structure
        public Adresse(int numero, string rue, string complement, string codePostal, string ville)
        {
            if (numero < 0) throw new ArgumentException(@"Le numéro de rue doit être positif");
            if (string.IsNullOrWhiteSpace(rue)) throw new ArgumentException(@"Le nom de la rue doit être renseigné");
            if (string.IsNullOrWhiteSpace(codePostal)) throw new ArgumentException(@"Le code postal doit être renseigné");
            if (string.IsNullOrWhiteSpace(ville)) throw new ArgumentException(@"La ville doit être renseignée");

            _numero = numero;
            _rue = rue;
            _complement = complement;
            _codePostal = codePostal;
            _ville = ville;
        }
    }
}