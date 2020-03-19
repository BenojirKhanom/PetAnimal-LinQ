using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_linq
{    
    class pet
    { 
        public int PetID { set; get; }
        public String PetName { set; get; }
        public String PetType { set; get; }
        public int PetAge { set; get; }
        public int OnwerID { set; get; }




    };
    class HospitalProcedure
    {
        public int ProcedureID { set; get; }
        public string ProcedureName { set; get; }
    };
    class Onwer
    {
        public int OnwerID { set; get; }
        public string OnwerName { set; get; }
    };
    class PetProcedure
    {
        public int PetID { set; get; }
        public int ProcedureID { set; get; }

        public string VisitDate { set; get; }

        public string NextVisitDate { set; get; }


    };
    class Program
    {     
        static void Main(string[] args)
        {
            Onwer[] oArry = new Onwer[]
           {
               new Onwer() { OnwerID = 1, OnwerName = "Sam cook"},
               new Onwer() { OnwerID = 2, OnwerName = "Terry kim"},
               new Onwer() { OnwerID = 3, OnwerName = "Jone sharp"},
               new Onwer() { OnwerID = 4, OnwerName = "Murach smith"},
               new Onwer() { OnwerID = 5, OnwerName = "herry potter"},
               new Onwer() { OnwerID = 6, OnwerName = "George orwell"},
               new Onwer() { OnwerID = 7, OnwerName = "Jane ustan"},
               new Onwer() { OnwerID = 8, OnwerName = "Samuel backet"},
               new Onwer() { OnwerID = 9, OnwerName = "Alex willson"},
               new Onwer() { OnwerID = 10, OnwerName = "Emliy Browen"},
           };
            pet[] pArry = new pet[]
            {
                new pet (){ PetID = 1, PetName = "Rover" , PetType = "Dog" , PetAge = 2, OnwerID = 1},
                new pet (){ PetID = 2, PetName = "dill" ,  PetType = "Dog" , PetAge = 3, OnwerID = 2},
                new pet (){ PetID = 3, PetName = "tom" ,   PetType = "cat" , PetAge = 2, OnwerID = 3},
                new pet (){ PetID = 4, PetName = "jerry" , PetType = "Cat" , PetAge = 1, OnwerID = 4},
                new pet (){ PetID = 5, PetName = "spot" ,  PetType = "Rabics" , PetAge = 1, OnwerID = 5},
                new pet (){ PetID = 6, PetName = "tweddy" ,PetType = "Rabics" , PetAge = 2, OnwerID = 6},
                new pet (){ PetID = 7, PetName = "Morich" ,PetType = "hen" , PetAge = 3, OnwerID = 7},
                new pet (){ PetID = 8, PetName = "dimm" ,  PetType = "hen" , PetAge = 1, OnwerID = 8},
                new pet (){ PetID = 9, PetName = "tummy" , PetType = "Cow" , PetAge = 4, OnwerID = 9},
                new pet (){ PetID = 10, PetName = "pammy", PetType = "Cow" , PetAge = 3, OnwerID = 10}
            };
            HospitalProcedure[] hpArry = new HospitalProcedure[]
            {
                new HospitalProcedure(){ ProcedureID = 1 , ProcedureName = "Rabics Vaccination"},
                new HospitalProcedure(){ ProcedureID = 2 , ProcedureName = "Treat Wound"},
                new HospitalProcedure(){ ProcedureID = 3 , ProcedureName = "Heart Worm Test"},
                new HospitalProcedure(){ ProcedureID = 4 , ProcedureName = "Tatanus Vaccination"},
                new HospitalProcedure(){ ProcedureID = 5 , ProcedureName = "Annual Cheak UP "},
                 new HospitalProcedure(){ ProcedureID = 6 , ProcedureName = "Eye Wash"}
            };
           
            PetProcedure[] ppArry = new PetProcedure[]
            {
                new PetProcedure(){ PetID = 1, ProcedureID = 16, VisitDate = "01/05/2019", NextVisitDate = "01/10/2019"},
                new PetProcedure(){ PetID = 2, ProcedureID = 6, VisitDate = "02/05/2019", NextVisitDate = "02/10/2019"},
                new PetProcedure(){ PetID = 3, ProcedureID = 5, VisitDate = "03/05/2019", NextVisitDate = "03/10/2019"},
                new PetProcedure(){ PetID = 4, ProcedureID = 1, VisitDate = "04/05/2019", NextVisitDate = "04/10/2019"},
                new PetProcedure(){ PetID = 5, ProcedureID = 6, VisitDate = "05/05/2019", NextVisitDate = "05/10/2019"},
                new PetProcedure(){ PetID = 6, ProcedureID = 5, VisitDate = "06/05/2019", NextVisitDate = "06/10/2019"},
                new PetProcedure(){ PetID = 7, ProcedureID = 4, VisitDate = "07/05/2019", NextVisitDate = "07/10/2019"},
                new PetProcedure(){ PetID = 8, ProcedureID = 3, VisitDate = "08/05/2019", NextVisitDate = "08/10/2019"},
                new PetProcedure(){ PetID = 9, ProcedureID = 2, VisitDate = "09/05/2019", NextVisitDate = "09/10/2019"},
                new PetProcedure(){ PetID = 10, ProcedureID = 1, VisitDate = "10/05/2019", NextVisitDate = "10/10/2019"},
                new PetProcedure(){ PetID = 1, ProcedureID = 5, VisitDate = "11/05/2019", NextVisitDate = "11/10/2019"},
                new PetProcedure(){ PetID = 2, ProcedureID = 4, VisitDate = "12/05/2019", NextVisitDate = "12/10/2019"},
                new PetProcedure(){ PetID = 3, ProcedureID = 4, VisitDate = "13/05/2019", NextVisitDate = "13/10/2019"},

                new PetProcedure(){ PetID = 4, ProcedureID = 1, VisitDate = "14/05/2019", NextVisitDate = "14/10/2019"},
                new PetProcedure(){ PetID = 5, ProcedureID = 6, VisitDate = "15/05/2019", NextVisitDate = "15/10/2019"},
                new PetProcedure(){ PetID = 6, ProcedureID = 5, VisitDate = "16/05/2019", NextVisitDate = "16/10/2019"},
                new PetProcedure(){ PetID = 7, ProcedureID = 4, VisitDate = "17/05/2019", NextVisitDate = "17/10/2019"},
                new PetProcedure(){ PetID = 8, ProcedureID = 3, VisitDate = "18/05/2019", NextVisitDate = "18/10/2019"},
                new PetProcedure(){ PetID = 9, ProcedureID = 2, VisitDate = "19/05/2019", NextVisitDate = "19/10/2019" },
                new PetProcedure(){ PetID = 10, ProcedureID = 1, VisitDate = "20/05/2019", NextVisitDate = "20/10/2019"},
                new PetProcedure(){ PetID = 1, ProcedureID = 3, VisitDate = "21/05/2019", NextVisitDate = "21/10/2019"},
                new PetProcedure(){ PetID = 2, ProcedureID = 3, VisitDate = "22/05/2019", NextVisitDate = "22/10/2019"},
                new PetProcedure(){ PetID = 3, ProcedureID = 2, VisitDate = "23/05/2019", NextVisitDate = "23/10/2019"},
                new PetProcedure(){ PetID = 4, ProcedureID = 2, VisitDate = "24/05/2019", NextVisitDate = "24/10/2019"},
                new PetProcedure(){ PetID = 5, ProcedureID = 6, VisitDate = "25/05/2019", NextVisitDate = "25/10/2019"},
                new PetProcedure(){ PetID = 6, ProcedureID = 5, VisitDate = "26/05/2019", NextVisitDate = "26/10/2019"},
                new PetProcedure(){ PetID = 7, ProcedureID = 4, VisitDate = "27/05/2019", NextVisitDate = "27/10/2019"},
                new PetProcedure(){ PetID = 8, ProcedureID = 3, VisitDate = "28/05/2019", NextVisitDate = "28/10/2019"},
                new PetProcedure(){ PetID = 9, ProcedureID = 2, VisitDate = "29/05/2019", NextVisitDate = "29/10/2019"},
                new PetProcedure(){ PetID = 10, ProcedureID = 1, VisitDate = "30/05/2019", NextVisitDate = "30/10/2019"}


                

            };
            var result = from oArr in oArry
                         join pArr in pArry on
      oArr.OnwerID equals pArr.OnwerID
                         join ppArr in ppArry on
                         pArr.PetID equals ppArr.PetID
                         join hpArr in hpArry on
                         ppArr.ProcedureID equals hpArr.ProcedureID
                         select new
                         {
                             OnwerName = oArr.OnwerName,
                             PetID = pArr.PetID,
                             PetName = pArr.PetName,
                             PetType = pArr.PetType,
                             PetAge = pArr.PetAge,
                             ProcedureName = hpArr.ProcedureName,
                             VisitDate = ppArr.VisitDate,
                             NextVisitDate = ppArr.NextVisitDate
                         };
            foreach (var a in result)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
               



        }
    }
}