using System;

namespace heist
{
    public class Muscle : IRobber
    {
        public string Name { get ; set ; }
        public int SkillLevel { get ; set ; }
        public int PercentageCut { get ; set ; }
        public string Role { get;}  = "Muscle";

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            
            if(bank.SecurityGuardScore <=0){
                Console.WriteLine($"{Name} 'wiffled' the guard.");
            }else{
                Console.WriteLine($"{Name} has injured the guard by {SkillLevel} points.");
            }
        }
    }
}