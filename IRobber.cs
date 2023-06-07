using System;

namespace heist{
public interface IRobber
{
    string Name { get; set; }
    int SkillLevel { get; set; }
    int PercentageCut { get; set; }

    string Role { get;}

    void PerformSkill(Bank bank);

}

}