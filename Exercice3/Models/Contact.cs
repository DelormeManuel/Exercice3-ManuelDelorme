using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
namespace Exercice3.Models
{
	public class Contact
	{
		[Required(ErrorMessage = "Le nom est obligatoire")]
		public string Nom { get; set; }
		[DisplayName("Prénom")]
		[Required(ErrorMessage = "Le prénom est obligatoire")]
		public string Prenom { get; set; }
		[Required(ErrorMessage = "Le couriel est obligatoire")]
		[EmailAddress]
		public string Couriel { get; set; }
		[DisplayName("Date de naissance")]
		public DateTime DateNaissance { get; set; }
		[DisplayName("Numéro Téléphone domicile")]
		public string TelephoneDomicile { get; set; }
		[DisplayName("Numéro Téléphone mobile")]
		public string TelephoneMobile { get; set; }
		[Range(1000000, 9999999, ErrorMessage = "Le numéro de DA doit être composé de 7 chiffres")]
		public int DA { get; set; }
		[DisplayName("Site web")]
		public string Site { get; set; }
		[DisplayName("Couleur préférée")]
		public string Couleur { get; set; }
		[DisplayName("Programme d'études")]
		public string Programme { get; set; }
		[DisplayName("Sexe")]
		public string Sexe { get; set; }
	}
}

