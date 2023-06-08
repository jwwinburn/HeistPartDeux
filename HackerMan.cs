using System;

namespace heist
{
    public class Hacker : IRobber
    {
        public string Name { get ; set ; }
        public int SkillLevel { get ; set ; }
        public int PercentageCut { get ; set ; }

        public string Role { get;}  = "Hacker Man";


        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore- SkillLevel;
            
            if(bank.AlarmScore <=0){
                Console.WriteLine($"{Name} hacked the alarm.");
            }else{
                Console.WriteLine($"{Name} is hacking the alarm, decreased security by {SkillLevel}.");
            }
        }
    }
}