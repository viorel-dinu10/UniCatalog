using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCatalog.Models
{
    public class Grupa 
    {
        [Key]
        public String Name { get; set; }
        private char C;
        private char F = 'F';
        private char P;
        private char A;
        private char Contor;
        public List<Student>? Student { get; set; }
        public Grupa() { }
        //public Grupa(int start,int nrGrupe, List<Student> Admisi)
        //{
        //    Student = new List<Student>();
        //  //  if (Admisi[0].CicluDeInvatamant == CicluDeInvatamant.Licenta)
        //    {
        //        C = 'L';
        //    }
        //    else
        //    {
        //        C = 'M';
        //    }

        //  //  P = Admisi[0].Cod;
        //   // A = Admisi[1].Cod;
        //    foreach (var student in Admisi)
        //    {
        //        Student.Add(student);
                
        //    }

        //    Contor = (start+1).ToString()[0];
        //    char[] charArray = { '4',C, F, P, A, Contor };

        //    Name = new string(charArray);
        //}



    }
}
