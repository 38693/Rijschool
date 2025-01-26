namespace Rijschool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    internal class Auto
    {
        internal bool automaat;
        internal string merk;
        internal string kenteken;
        internal int kilometerStand;
    }

    internal class RijLeraar
    {
        internal string naam;
        internal int leeftijd;
        internal bool zzp;
    }

    internal class Student
    {
        internal string naam;
        internal int leeftijd;
        internal LesPakket lesPakket;
        internal RijLeraar leraar;
        internal TheorieTest theorieTest;
        internal RijTest rijTest;
    }

    internal class LesPakket
    {
        internal string naam;
        internal int leeftijd;
        internal bool zzp;
    }

    internal class RijTest
    {
        internal bool gehaald;
        internal DateTime afnameDatum;
    }

    internal class TheorieTest
    {
        internal int aantalFouten;
        internal bool gehaald;
        internal DateTime afnameDatum;
    }

    internal class Dag
    {
        internal DateTime datum;
        internal LesUur[] lesuren;
    }

    internal class LesUur
    {
        internal int tijd;
        internal Student student;
        internal RijLeraar rijLeraar;
        internal Auto auto;
    }
}
