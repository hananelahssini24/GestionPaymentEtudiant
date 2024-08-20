using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionPaymentsEtudients.Models.Entities
{
    public class Student
    {
        [Key] // Identifie cette propriété comme la clé primaire
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le prénom est requis.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le nom est requis.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "L'email est requis.")]
        [EmailAddress(ErrorMessage = "Adresse email non valide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le code étudiant est requis.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Le programme est requis.")]
        public string ProgramId { get; set; }

        public string Photo { get; set; } // La photo peut être optionnelle
    }
}
