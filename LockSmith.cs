using System;

namespace heist
{
    public class LockSmith : IRobber
    {
        public string Name { get ; set ; }
        public int SkillLevel { get ; set ; }
        public int PercentageCut { get ; set ; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore =- SkillLevel;
            
            if(bank.VaultScore <=0){
                Console.WriteLine($"{Name} unlocked the vault.");
            }else{
                Console.WriteLine($"{Name} is unlocking the vault, vault security decreased by {SkillLevel} points.");
            }
        }
    }
}