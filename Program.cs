using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Hello World!");

            //Defining the homies
            Muscle muscleman = new Muscle() { Name = "Mustleman", SkillLevel = 50, PercentageCut = 10 };
            Muscle mrt = new Muscle() { Name = "Mr. T", SkillLevel = 70, PercentageCut = 10 };
            LockSmith hannibal = new LockSmith() { Name = "Hannibal", SkillLevel = 50, PercentageCut = 15 };
            LockSmith mordecai = new LockSmith() { Name = "Mordecai", SkillLevel = 55, PercentageCut = 15 };
            Hacker animoose = new Hacker() { Name = "Animoose", SkillLevel = 55, PercentageCut = 20 };
            Hacker rigby = new Hacker() { Name = "Rigby", SkillLevel = 55, PercentageCut = 20 };

            //New IRobber List called Rolodex.
            List<IRobber> rolodex = new List<IRobber>(){
                muscleman, mrt, hannibal, mordecai, animoose, rigby
            };

            Console.WriteLine($"{rolodex.Count} is the number of guys in the crew.");
            bool keepLooping = true;
            while (keepLooping)
            {


                Console.WriteLine($"Enter new member's name:");
                string newCrewName = Console.ReadLine();
                System.Console.WriteLine($"What is {newCrewName}'s Skill Level?");
                int newCrewSkillLevel = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine($"What is {newCrewName}'s Percentage Cut?");
                int newCrewPercentageCut = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine($"Is {newCrewName} a Hacker, Muscle, or LockSmith?");
                string newCrewSpecality = Console.ReadLine().ToLower();
                switch (newCrewSpecality)
                {
                    case "hacker":
                        //if hacker
                        //System.Console.WriteLine($"You chose Hacker");
                        Hacker Adam = new Hacker() { Name = newCrewName, SkillLevel = newCrewSkillLevel, PercentageCut = newCrewPercentageCut };
                        rolodex.Add(Adam);

                        break;
                    case "muscle":
                        //if mustle
                        //System.Console.WriteLine($"You chose Mustle");
                        Muscle Jerry = new Muscle() { Name = newCrewName, SkillLevel = newCrewSkillLevel, PercentageCut = newCrewPercentageCut };
                        rolodex.Add(Jerry);

                        break;
                    case "locksmith":
                        //if locksmith
                        //System.Console.WriteLine($"You chose LockSmith");
                        LockSmith Dan = new LockSmith() { Name = newCrewName, SkillLevel = newCrewSkillLevel, PercentageCut = newCrewPercentageCut };
                        rolodex.Add(Dan);

                        break;
                    default:
                        System.Console.WriteLine($"That is NOT a specality.");
                        break;
                }

                System.Console.WriteLine($"{newCrewName} is {newCrewSkillLevel} skilled, with a {newCrewPercentageCut} cut, and is an experienced {newCrewSpecality}.");
                Console.WriteLine("Would you like to add another member? Yes or No?");
                string newMemberAnswer = Console.ReadLine().ToLower();
                if (newMemberAnswer == "no")
                {
                    keepLooping = false;
                }
                else
                {
                    keepLooping = true;
                }
            }
            Console.WriteLine($"{rolodex.Count} is the number of guys in the crew.");

            int alarmScore = new Random().Next(0, 100);
            int vaultScore = new Random().Next(0, 100);
            int securityGuardScore = new Random().Next(0, 100);
            int cashOnHand = new Random().Next(50000, 1000000);

            Bank meanBank = new Bank()
            {
                AlarmScore = alarmScore,
                VaultScore = vaultScore,
                SecurityGuardScore = securityGuardScore,
                CashOnHand = cashOnHand,
            };

            void mostSecure(Bank bank)
            {
                Dictionary<string, int> bankScores = new Dictionary<string, int>() { { "Alarm", bank.AlarmScore }, { "Vault", bank.VaultScore }, { "SecurityGuard", bank.SecurityGuardScore } };
                string lowestScore = bankScores.OrderBy(x => x.Value).First().Key;
                string highestScore = bankScores.OrderByDescending(x => x.Value).First().Key;
                Console.WriteLine($"{highestScore} is the most secure system and {lowestScore} is the least secure system");

            }

            mostSecure(meanBank);
             bool keepadding = true;

            void availableCrew(List<IRobber> mylist){
                bool findSomeone = false;
                int totalPercent = 0;
                foreach(IRobber myFam in mylist){
                    totalPercent += myFam.PercentageCut;
                }
                Console.WriteLine(totalPercent);
                foreach (IRobber crew in rolodex)
            {
                if((!mylist.Contains(crew)) && (crew.PercentageCut+totalPercent<100)){
                    findSomeone =true;
                    System.Console.WriteLine($"{rolodex.IndexOf(crew) + 1} {crew.Name} is a {crew.Role} they have a skill level of {crew.SkillLevel}. They make {crew.PercentageCut}% of spoils");
                }
                
            }
                if(findSomeone == false){
                    Console.WriteLine("You cant add anymore people");
                    keepadding =false;
                }
            }
           

            List<IRobber> myCrew = new List<IRobber>();
             availableCrew(myCrew);

           

            // List<int> myCrewIndex =new List<int>();

            while (keepadding)
            {
                System.Console.WriteLine("Pick your family by selecting the number to the left of the person.");

                int familyselection = Int32.Parse(Console.ReadLine()) - 1;
                // myCrewIndex.Add(familyselection);

                
                myCrew.Add(rolodex[familyselection]);

                

                availableCrew(myCrew);

                System.Console.WriteLine("Do you want to add another user? Yes or No?");

                var userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "no")
                {
                    keepadding = false;

                }
            }
            
        }
    }

    //failsafe in case we need it
    //if(newCrewSpecality != "hacker" || newCrewSpecality != "muscle" || newCrewSpecality != "locksmith"){}
}
