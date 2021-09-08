using System;
using System.IO;
using System.Collections.Generic;



//vstupny subor sa nachadza v debug zlozke
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input file(EncodedMessage.txt): ");
            var input = Console.ReadLine();

            Console.Write("Initial triplet(QVH): ");
            var triplet = Console.ReadLine();
            
            /*
            var input = "EncodedMessage.txt";
            var triplet = "QVH";
            */

            var flag = 0;

            List<string> Encrypted = new List<string>();

            //nacitanie trojic do listu s tym ze poslednu trojicu automaticky otacam 
            var lines = File.ReadLines(input);
            foreach (var line in lines)
                Encrypted.Add(line[..6] + line[8] + line[7] + line[6]);


            // cyklus co najde trojicu, vypise prislusne pismeno a zmeni hladanu trojicu na dalsiu, ak trojicu nenajde tak cyklus konci
            while (true){
                foreach (var triplets in Encrypted){
                    if (triplets[..3] == triplet){
                        Console.Write(triplets[4]);
                        triplet = triplets[6..];
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    break;
                    
            }
            
        }
    }
}
