using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionPaymentsEtudients.Models.Entities
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public PaymentType Type { get; set; }

        public PaymentStatus Status { get; set; }

        public string File { get; set; }

        public Guid StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
    public enum PaymentStatus
    {
        CREATED, VALIDATED, REJECTED
    }

    public enum PaymentType
    {
        CASH, CHECK, TRANSFER, DEPOT
    }
}
