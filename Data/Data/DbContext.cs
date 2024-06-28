using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniCatalog.Models;
namespace UniCatalog.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<PlanDeInvatamant> PlanuriDeInvatamant { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Disciplina> Discipline { get; set; }
        public DbSet<CadruDidactic> CadreDidactice { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CadruDidactic>().HasData(
                new CadruDidactic{MarcaAngajat = "13ef1",DisciplinaId = "15ab1", Nume = "Popescu", Prenume = "Ion", Post = Post.Asistent, Titlu = "Dr."},
                new CadruDidactic { MarcaAngajat = "13ef2", DisciplinaId = "15ab2", Nume = "Georgescu", Prenume = "Marius", Post = Post.Profesor, Titlu = "Dr. Ing." },
                new CadruDidactic { MarcaAngajat = "13ef3", DisciplinaId = "15ab3", Nume = "Ion", Prenume = "Elena", Post = Post.Profesor, Titlu = "Dr." },
                new CadruDidactic { MarcaAngajat = "13ef4", DisciplinaId = "15ab4", Nume = "Radu", Prenume = "Constantin", Post = Post.Asistent, Titlu = "Dr." },
                new CadruDidactic { MarcaAngajat = "13ef5", DisciplinaId = "15ab5", Nume = "Pop", Prenume = "Carmen", Post = Post.CDA, Titlu = "Dr.Ing." },
                new CadruDidactic { MarcaAngajat = "13ef6", DisciplinaId = "15ab6", Nume = "Dan", Prenume = "Alexandra", Post = Post.Conferentiar, Titlu = "Dr." },
                new CadruDidactic { MarcaAngajat = "13ef7", DisciplinaId = "15ab7", Nume = "Ionescu", Prenume = "Maria", Post = Post.Profesor, Titlu = "Dr." }
                );

            modelBuilder.Entity<Disciplina>().HasData(
                new Disciplina{Cod = "15ab1", Acronim = "TS",Name = "Teoria Sistemelor", Credite = 4, PlanId = 2 },
                new Disciplina { Cod = "15ab2", Acronim = "F", Name = "Fizica", Credite = 5, PlanId = 2 },
                new Disciplina { Cod = "15ab3", Acronim = "MS", Name = "Matematici Speciale", Credite = 6, PlanId = 2 },
                new Disciplina { Cod = "15ab4", Acronim = "E", Name = "Electrotehnica", Credite = 3 , PlanId = 2 },
                new Disciplina { Cod = "15ab5", Acronim = "ALGAD", Name = "Algebra Liniara", Credite = 6, PlanId = 1 },
                new Disciplina { Cod = "15ab6", Acronim = "PCLP", Name = "Programarea Calclatoarelor", Credite = 5 , PlanId = 1 },
                new Disciplina { Cod = "15ab7", Acronim = "POO", Name = "Programare orientata pe obiect", Credite = 4, PlanId = 1 }
                );

            modelBuilder.Entity<PlanDeInvatamant>().HasData(
                new PlanDeInvatamant{Id = 1,An = 1, CicluDeInvatamant = CicluDeInvatamant.Licenta,Cod = '2',Name = "AIA", },
                new PlanDeInvatamant {Id = 2,  An = 2, CicluDeInvatamant = CicluDeInvatamant.Master, Cod = '3', Name = "AIA" }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student { NrMatricol = "10917/4lf422019", Name = "Snow", Prenume = "Jon", DataInscrierii = DateTime.Now, MedieAdmitere = 7.5, CNP = "5030610211245", PlanId = 1},
                new Student { NrMatricol = "10918/4lf422019", Name = "Stark", Prenume = "Arya", DataInscrierii = DateTime.Now, MedieAdmitere = 8.1, CNP = "5040710211234", PlanId = 1 },
                new Student { NrMatricol = "10919/4lf422019", Name = "Lannister", Prenume = "Tyrion", DataInscrierii = DateTime.Now, MedieAdmitere = 8.7, CNP = "5030810211256", PlanId = 1 },
                new Student { NrMatricol = "10920/4lf422019", Name = "Targaryen", Prenume = "Daenerys", DataInscrierii = DateTime.Now, MedieAdmitere = 9.0, CNP = "5030910211267", PlanId = 2},
                new Student { NrMatricol = "10921/4lf422019", Name = "Baratheon", Prenume = "Robert", DataInscrierii = DateTime.Now, MedieAdmitere = 7.8, CNP = "5031010211278", PlanId = 2 },
                new Student { NrMatricol = "10922/4lf422019", Name = "Greyjoy", Prenume = "Theon", DataInscrierii = DateTime.Now, MedieAdmitere = 7.3, CNP = "5031110211289", PlanId = 1 },
                new Student { NrMatricol = "10923/4lf422019", Name = "Mormont", Prenume = "Jorah", DataInscrierii = DateTime.Now, MedieAdmitere = 8.5, CNP = "5031210211290", PlanId = 2 },
                new Student { NrMatricol = "10924/4lf422019", Name = "Tyrell", Prenume = "Margaery", DataInscrierii = DateTime.Now, MedieAdmitere = 8.9, CNP = "5031310211301", PlanId = 2 },
                new Student { NrMatricol = "10925/4lf422019", Name = "Sand", Prenume = "Oberyn", DataInscrierii = DateTime.Now, MedieAdmitere = 8.2, CNP = "5031410211312", PlanId = 1 },
                new Student { NrMatricol = "10926/4lf422019", Name = "Martell", Prenume = "Ellaria", DataInscrierii = DateTime.Now, MedieAdmitere = 8.3, CNP = "5031510211323", PlanId = 2 },
                new Student { NrMatricol = "10927/4lf422019", Name = "Tarly", Prenume = "Samwell", DataInscrierii = DateTime.Now, MedieAdmitere = 7.9, CNP = "5031610211334", PlanId = 1 },
                new Student { NrMatricol = "10928/4lf422019", Name = "Bolton", Prenume = "Ramsay", DataInscrierii = DateTime.Now, MedieAdmitere = 7.2, CNP = "5031710211345", PlanId = 2 },
                new Student { NrMatricol = "10929/4lf422019", Name = "Baelish", Prenume = "Petyr", DataInscrierii = DateTime.Now, MedieAdmitere = 8.4, CNP = "5031810211356", PlanId = 1 },
                new Student { NrMatricol = "10930/4lf422019", Name = "Clegane", Prenume = "Sandor", DataInscrierii = DateTime.Now, MedieAdmitere = 8.0, CNP = "5031910211367", PlanId = 2 }
                );
        }
       
    }
}