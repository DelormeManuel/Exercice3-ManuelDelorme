// ContactController.cs
using System.Drawing;
using Exercice3.Models;
using Microsoft.AspNetCore.Mvc;

public class ContactController : Controller
{
    public IActionResult Create() //Affiche le formulaire de contact
    {
        return View();
    }


    [HttpPost]
    public IActionResult Create(Contact contact) //Traite le formulaire de contact
    {
      return Content(
        "Nom : "  + contact.Nom 
        + "\nPrénom : " + contact.Prenom
        + "\nEmail : " + contact.Couriel
        + "\nDate de naissance : " + contact.DateNaissance 
        + "\nTéléphone domicile : " + contact.TelephoneDomicile 
        + "\nTéléphone mobile : " + contact.TelephoneMobile 
        + "\nDA : " + contact.DA 
        + "\nSite : " + contact.Site 
        + "\nCouleur : " + contact.Couleur 
        + "\nSexe : " + contact.Sexe 
        + "\nEtudes : " + contact.Programme);
    }
}