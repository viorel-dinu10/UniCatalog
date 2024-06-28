using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UniCatalog.Models;

namespace UniCatalog.Models;
public class Student 
{
    [Key]
    public string NrMatricol { get; set; }
    [Required]
    [DisplayName("Nume")]
    
    public string Name { get; set; }
    [Required]
    [DisplayName("Prenume")]
  
    public string Prenume { get; set; }
    [Required]
    [DisplayName("Data")]
    public DateTime DataInscrierii { get; set; }
    [Required]
    [DisplayName("Medie")]
    public double MedieAdmitere { get; set; }

    [ForeignKey("Plan")]
    public int PlanId { get; set; }
    public string? GrupaName { get; set; }
    public Grupa? Grupa { get; set; }

    [Required]
    [DisplayName("Cnp")]
    [MaxLength(13)]
    public string CNP { get; set; }

    public PlanDeInvatamant? PlanDeInvatamant { get; set; }


    //public CicluDeInvatamant? CicluDeInvatamant { get; set; }
}