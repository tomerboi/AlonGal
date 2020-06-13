using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Name Tomer = new Name("Tomer", "Tomer");
            Name Chen = new Name("Chen", "Chen");
            Name Lidor = new Name("Lidor", "Lidor");
            Name TomerB = new Name("Tomer", "Tomer");
            Name Gal = new Name("Gal", "Gal");
            
            Address Lantos = new Address("Lantos", "Lantos");
            Address Herzel = new Address("Herzel", "Herzel");
            Address Lavi = new Address("Lavi", "Lavi");
            Address LantosB = new Address("Lantos", "Lantos");
            Address Eshkol = new Address("Eshkol", "Eshkol");

            Person B = new Person(Chen,Lantos);//B
            Person A = new Person(Chen, Herzel);//A
            Person D = new Person(Lidor, Lantos);//D
            Person C = new Person(Gal, Herzel);//C
            Person E = new Person(Gal,Lavi);//E
            Person F = new Person(Tomer,Lantos);//F

            PersonRelationsFinder finder = new PersonRelationsFinder();
            Person[] arr = new Person[6]{A,B,C,D,E,F};
            finder.Init(arr);
            int x = finder.FindMinLevel(B, C);

        }
    }
}
