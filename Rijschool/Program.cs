namespace Rijschool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.Run();
        }
    
        void Run()
        {

            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "volvo"
            };

            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };

            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,

                tijd = 1130
            };

            LesPakket lesPakket = new LesPakket
            {
                urenGekocht = 17,
                urenVerbruikt = 6,
                examenPogingen = 2,
                automaat = true
            };

            TheorieTest theorieTest = new TheorieTest
            {
                aantalFouten = 4,
                gehaald = true,
                afnameDatum = DateTime.Now
            };

            RijTest rijTest = new RijTest
            {
                gehaald = false,
                afnameDatum = DateTime.Now.AddMonths(2)
            };

            Student student1 = new Student
            {
                naam = "Ilias",
                leeftijd = 16,
                LesPakket = lesPakket,
                RijLeraar = rijLeraar,
                auto = auto1
            };

            LesUur lesUur1 = new LesUur
            {
                tijd = 14,
                student = student1,
                rijLeraar = rijLeraar,
                auto = auto1
            };

            LesUur lesUur2 = new LesUur
            {
                tijd = 13,
                student = student1,
                rijLeraar = rijLeraar,
                auto = auto2
            };

            Dag dag1 = new Dag
            {
                datum = DateTime.Now,
                lesuren = new LesUur[] { lesUur1, lesUur2 }
            };




            Student student2 = new Student
            {
                naam = "Sterre",
                leeftijd = 18,
                LesPakket = lesPakket,
                RijLeraar = rijLeraar,
                TheorieTest = theorieTest,
                RijTest = rijTest
            };

            LesUur lesUur3 = new LesUur
            {
                tijd = 9,
                student = student2,
                rijLeraar = rijLeraar,
                auto = auto1
            };

            Dag dag2 = new Dag
            {
                datum = DateTime.Now.AddDays(1),
                lesuren = new LesUur[] { lesUur3 }
            };
        }

    }

}