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
        // Pas de constructeur sans param�tres pour une structure
        public Adresse(int numero, string rue, string complement, string codePostal, string ville)
        {
            if (numero < 0) throw new ArgumentException(@"Le num�ro de rue doit �tre positif");
            if (string.IsNullOrWhiteSpace(rue)) throw new ArgumentException(@"Le nom de la rue doit �tre renseign�");
            if (string.IsNullOrWhiteSpace(codePostal)) throw new ArgumentException(@"Le code postal doit �tre renseign�");
            if (string.IsNullOrWhiteSpace(ville)) throw new ArgumentException(@"La ville doit �tre renseign�e");

            _numero = numero;
            _rue = rue;
            _complement = complement;
            _codePostal = codePostal;
            _ville = ville;
        }
    }
}