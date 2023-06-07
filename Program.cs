using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Defining the homies
            Muscle muscleman = new Muscle(){Name = "Mustleman", SkillLevel = 50, PercentageCut = 10};
            Muscle mrt = new Muscle(){Name = "Mr. T", SkillLevel = 70, PercentageCut = 10};
            LockSmith hannibal = new LockSmith(){Name = "Hannibal", SkillLevel = 50, PercentageCut = 15};
            LockSmith mordecai = new LockSmith(){Name = "Mordecai", SkillLevel = 55, PercentageCut = 15};
            Hacker animoose = new Hacker(){Name = "Animoose", SkillLevel = 55, PercentageCut = 20};
            Hacker rigby = new Hacker(){Name = "Rigby", SkillLevel = 55, PercentageCut = 20};

            //New IRobber List called Rolodex.
            List<IRobber> rolodex = new List<IRobber>(){
                muscleman, mrt, hannibal, mordecai, animoose, rigby
            };

            Console.WriteLine($"{rolodex.Count} is the number of guys in the crew.");
            Console.WriteLine($"Enter new member's name:");
            string newCrewName = Console.ReadLine();
            System.Console.WriteLine($"What is {newCrewName}'s Skill Level?");
            int newCrewSkillLevel = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine($"What is {newCrewName}'s Percentage Cut?");
            int newCrewPercentageCut = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine($"Is {newCrewName} a Hacker, Muscle, or LockSmith?");
            string newCrewSpecality = Console.ReadLine().ToLower();
            switch(newCrewSpecality){
            case "hacker":
            //if hacker
            System.Console.WriteLine($"You chose Hacker");

            break;
            case "muscle":
            //if mustle
            System.Console.WriteLine($"You chose Mustle");

            break;
            case "locksmith":
            //if locksmith
            System.Console.WriteLine($"You chose LockSmith");

            break;
            default:
            System.Console.WriteLine($"That is NOT a specality.");
            break;
            }

            System.Console.WriteLine($"{newCrewName} is {newCrewSkillLevel} skilled, with a {newCrewPercentageCut} cut, and is an experienced {newCrewSpecality}.");


        }
    }

    //failsafe in case we need it
    //if(newCrewSpecality != "hacker" || newCrewSpecality != "muscle" || newCrewSpecality != "locksmith"){}
}
