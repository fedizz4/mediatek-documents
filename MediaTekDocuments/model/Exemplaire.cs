using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Exemplaire (exemplaire d'une revue)
    /// </summary>
    public class Exemplaire
    {
        public int Numero { get; set; }
        public string Photo { get; set; }
        public DateTime DateAchat { get; set; }
        public string IdEtat { get; set; }
        public string Id { get; set; }
<<<<<<< HEAD
        public string Libelle { get; set; }

        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument, string libelle)
=======
<<<<<<< HEAD
        public string Libelle { get; set; }

        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument, string libelle)
=======

        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument)
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        {
            this.Numero = numero;
            this.DateAchat = dateAchat;
            this.Photo = photo;
            this.IdEtat = idEtat;
            this.Id = idDocument;
<<<<<<< HEAD
            this.Libelle = libelle;
=======
<<<<<<< HEAD
            this.Libelle = libelle;
=======
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        }

    }
}
