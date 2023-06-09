﻿using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
<<<<<<< HEAD
using System;
=======
<<<<<<< HEAD
using System;
=======
<<<<<<< HEAD
using System;
=======
<<<<<<< HEAD
using System;
=======
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
<<<<<<< HEAD
    public class FrmMediatekController
=======
<<<<<<< HEAD
    public class FrmMediatekController
=======
<<<<<<< HEAD
    public class FrmMediatekController
=======
    class FrmMediatekController
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocument">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocument)
        {
            return access.GetExemplairesRevue(idDocument);
        }

        /// <summary>
<<<<<<< HEAD
=======
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

>>>>>>> b3f0f02960a7e8706371a49f0b9db53b58f7202c
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// getter sur les suivis
        /// </summary>
        /// <returns>Liste d'objets Suivi</returns>
        public List<Suivi> GetAllSuivis()
        {
            return access.GetAllSuivis();
        }

        /// <summary>
        /// récupère les commandes d'un document
        /// </summary>
        /// <param name="idDocument"></param>
<<<<<<< HEAD
        /// <returns>Liste d'objets CommandeDocument</returns>
=======
<<<<<<< HEAD
        /// <returns>Liste d'objets CommandeDocument</returns>
=======
<<<<<<< HEAD
        /// <returns>Liste d'objets CommandeDocument</returns>
=======
<<<<<<< HEAD
        /// <returns>Liste d'objets CommandeDocument</returns>
=======
<<<<<<< HEAD
        /// <returns>Liste d'objets CommandeDocument</returns>
=======
<<<<<<< HEAD
        /// <returns>Liste d'objets CommandeDocument</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public List<CommandeDocument> GetCommandesDocument(string idDocument)
        {
            return access.GetCommandesDocument(idDocument);
        }

        /// <summary>
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// récupère les abonnements d'une revue
        /// </summary>
        /// <param name="idDocument"></param>
        /// <returns>Liste d'objets Abonnement</returns>
        public List<Abonnement> GetAbonnementRevue(string idDocument)
        {
            return access.GetAbonnementRevue(idDocument);
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <summary>
        /// récupère les abonnements qui prennent fin dans 30 jours
        /// </summary>
        /// <returns></returns>
        public List<Abonnement> GetAbonnementsEcheance()
        {
            return access.GetAbonnementsEcheance();
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <summary>
        /// récupère les exemplaires d'un document
        /// </summary>
        /// <param name="idDocument"></param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesDocument(string idDocument)
        {
            return access.GetExemplairesDocument(idDocument);
        }

        /// <summary>
        /// récupère les états
        /// </summary>
        /// <returns>Liste d'objets Etat</returns>
        public List<Etat> GetAllEtatsDocument()
        {
            return access.GetAllEtatsDocument();
        }

        /// <summary>
<<<<<<< HEAD
=======
=======

        /// <summary>
=======

        /// <summary>
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
>>>>>>> b3f0f02960a7e8706371a49f0b9db53b58f7202c
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
<<<<<<< HEAD
        public bool CreerExemplaireRevue(string id, int numero, DateTime dateAchat, string photo, string idEtat)
        {
            return access.CreerExemplaireRevue(id, numero, dateAchat, photo, idEtat);
=======
<<<<<<< HEAD
        public bool CreerExemplaireRevue(string id, int numero, DateTime dateAchat, string photo, string idEtat)
        {
            return access.CreerExemplaireRevue(id, numero, dateAchat, photo, idEtat);
=======
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        }

        /// <summary>
        /// Crée un document dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Titre"></param>
        /// <param name="Image"></param>
        /// <param name="IdGenre"></param>
        /// <param name="IdPublic"></param>
        /// <param name="IdRayon"></param>
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool CreerDocument(string Id, string Titre, string Image, string IdRayon, string IdPublic, string IdGenre)
        {
            return access.CreerDocument(Id, Titre, Image, IdRayon, IdPublic, IdGenre);
        }

        /// <summary>
        /// Modifie un document dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Titre"></param>
        /// <param name="Image"></param>
        /// <param name="IdGenre"></param>
        /// <param name="IdPublic"></param>
        /// <param name="IdRayon"></param>
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool ModifierDocument(string Id, string Titre, string Image, string IdGenre, string IdPublic, string IdRayon)
        {
            return access.ModifierDocument(Id, Titre, Image, IdGenre, IdPublic, IdRayon);
        }

        /// <summary>
        /// Supprime un document dans la bdd
        /// </summary>
        /// <param name="Id"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool SupprimerDocument(string Id)
        {
            return access.SupprimerDocument(Id);
        }

        /// <summary>
        /// Crée un livre dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Isbn"></param>
        /// <param name="Auteur"></param>
        /// <param name="Collection"></param>
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool CreerLivre(string Id, string Isbn, string Auteur, string Collection)
        {
            return access.CreerLivre(Id, Isbn, Auteur, Collection);
        }

        /// <summary>
        /// Modifie un livre dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Isbn"></param>
        /// <param name="Auteur"></param>
        /// <param name="Collection"></param>
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool ModifierLivre(string Id, string Isbn, string Auteur, string Collection)
        {
            return access.ModifierLivre(Id, Isbn, Auteur, Collection);
        }

        /// <summary>
        /// Suppression d'un livre en bdd
        /// </summary>
        /// <param name="Id"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool SupprimerLivre(string Id)
        {
            return access.SupprimerLivre(Id);
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 1ee813cacc8c25908f393b6cdd67297fa722d644
>>>>>>> b3f0f02960a7e8706371a49f0b9db53b58f7202c
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <summary>
        /// Créé un Dvd dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Synopsis"></param>
        /// <param name="Realisateur"></param>
        /// <param name="Duree"></param>
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool CreerDvd(string Id, string Synopsis, string Realisateur, int Duree)
        {
            return access.CreerDvd(Id, Synopsis, Realisateur, Duree);
        }

        /// <summary>
        /// Modifie un dvd dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Synopsis"></param>
        /// <param name="Realisateur"></param>
        /// <param name="Duree"></param>
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool ModifierDvd(string Id, string Synopsis, string Realisateur, int Duree)
        {
            return access.ModifierDvd(Id, Synopsis, Realisateur, Duree);
        }

        /// <summary>
        /// Supprimme un dvd dans la bdd
        /// </summary>
        /// <param name="Id"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool SupprimerDvd(string Id)
        {
            return access.SupprimerDvd(Id);
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> b3f0f02960a7e8706371a49f0b9db53b58f7202c
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <summary>
        /// Crée une revue dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Periodicite"></param>
        /// <param name="DelaiMiseADispo"></param>
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la création a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool CreerRevue(string Id, string Periodicite, int DelaiMiseADispo)
        {
            return access.CreerRevue(Id, Periodicite, DelaiMiseADispo);
        }

        /// <summary>
        /// Modifie une revue dans la bdd
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Periodicite"></param>
        /// <param name="DelaiMiseADispo"></param>
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la modification a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool ModifierRevue(string Id, string Periodicite, int DelaiMiseADispo)
        {
            return access.ModifierRevue(Id, Periodicite, DelaiMiseADispo);
        }

        /// <summary>
        /// Supprime une revue dans la bdd
        /// </summary>
        /// <param name="Id"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool SupprimerRevue(string Id)
        {
            return access.SupprimerRevue(Id);
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <summary>
        /// Créé une commande dans la bdd
        /// </summary>
        /// <param name="commande"></param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommande(Commande commande)
        {
            return access.CreerCommande(commande);
        }

        /// <summary>
        /// Créé une commande de document dans la bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nbExemplaire"></param>
        /// <param name="idLivreDvd"></param>
        /// <param name="idSuivi"></param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommandeDocument(string id, int nbExemplaire, string idLivreDvd, string idSuivi)
        {
            return access.CreerCommandeDocument(id, nbExemplaire, idLivreDvd, idSuivi);
        }

        /// <summary>
        /// Modifie l'étape de suivi d'une commande dans la bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nbExemplaire"></param>
        /// <param name="idLivreDvd"></param>
        /// <param name="idSuivi"></param>
        /// <returns>True si la modification a pu se faire</returns>
        internal bool ModifierSuiviCommandeDocument(string id, int nbExemplaire, string idLivreDvd, string idSuivi)
        {
            return access.ModifierSuiviCommandeDocument(id, nbExemplaire, idLivreDvd, idSuivi);
        }

        /// <summary>
        /// Supprimme une commande de livre dans la bdd
        /// </summary>
<<<<<<< HEAD
        /// <param name="commandesDocument"></param>
=======
<<<<<<< HEAD
        /// <param name="commandesDocument"></param>
=======
<<<<<<< HEAD
        /// <param name="commandesDocument"></param>
=======
<<<<<<< HEAD
        /// <param name="commandesDocument"></param>
=======
        /// <param name="commandesdocument"></param>
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <returns>True si la suppression a pu se faire</returns>
        public bool SupprimerCommandeDocument(CommandeDocument commandesDocument)
        {
            return access.SupprimerCommandeDocument(commandesDocument);
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <summary>
        /// Crée un abonnement de revue dans la bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dateFinAbonnement"></param>
        /// <param name="idRevue"></param>
        /// <returns>True si l'insertion pu se faire</returns>
        public bool CreerAbonnementRevue(string id, DateTime dateFinAbonnement, string idRevue)
        {
            return access.CreerAbonnementRevue(id, dateFinAbonnement, idRevue);
        }

        /// <summary>
        /// Supprimme un abonnement de revue dans la bdd
        /// </summary>
        /// <param name="abonnement"></param>
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
<<<<<<< HEAD
        /// <returns>True si la suppression a pu se faire</returns>
=======
        /// <returns></returns>
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        public bool SupprimerAbonnementRevue(Abonnement abonnement)
        {
            return access.SupprimerAbonnementRevue(abonnement);
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
        /// <summary>
        /// Modifie l'état d'un exemplaire d'un document dans la bdd
        /// </summary>
        /// <param name="exemplaire"></param>
        /// <returns>True si la modification a pu se faire</returns>
        public bool ModifierEtatExemplaireDocument(Exemplaire exemplaire)
        {
            return access.ModifierEtatExemplaireDocument(exemplaire);
        }

        /// <summary>
        /// Supprime un exemplaire d'un document dans la bdd
        /// </summary>
        /// <param name="exemplaire"></param>
        /// <returns>True si la suppression a pu se faire</returns>
        public bool SupprimerExemplaireDocument(Exemplaire exemplaire)
        {
            return access.SupprimerExemplaireDocument(exemplaire);
        }


<<<<<<< HEAD
=======
=======
<<<<<<< HEAD


=======
=======

<<<<<<< HEAD
=======
=======

<<<<<<< HEAD
=======
=======


=======
>>>>>>> eeb80674616daa3efcacc9a227a3ebb9a6d80851
>>>>>>> 1ee813cacc8c25908f393b6cdd67297fa722d644
>>>>>>> b3f0f02960a7e8706371a49f0b9db53b58f7202c
>>>>>>> 919e8a5233d0cdd3744693ffe2540055c3cdbfbe
>>>>>>> f16e063c975dcb1ae6c01ea169eb422f534e527e
>>>>>>> f37c5fcd58707e8568a3f20ed691055d28c03125
>>>>>>> eb8fae79a684c51588f7bf9df5359bc32f9a1b6a
>>>>>>> 157ddf1d131a0a9eec010647b6ea06f318480a72
>>>>>>> 57669e51f2da208af589e215345a9afb8c3e8666
    }
}
