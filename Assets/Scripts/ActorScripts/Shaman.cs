using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class Shaman : People
{
    protected Shaman(int strength, bool sex, int age, int wealth, int health, bool truthCheck, int truthChance)
    {
        this.strength = strength;
        this.sex = sex;
        this.age = age;
        this.wealth = wealth;
        this.health = health;
        this.truthCheck = truthCheck;
        this.truthChance = truthChance;
    }

    protected override float getGreed()
    {
        return 0;
    }

    protected override int getIntelligence()
    {
        return 0;
    }

    protected override float getLeadership()
    {
        return 0;
    }

    protected override ArrayList getTalkingLines()
    {
        return null;
    }

    protected void setTruthChance(int truthChance)
    {
        truthChance = Random.Range(0, 1000000);
    }
    
    protected override int getTruthChance()
    {
        return truthChance;
    }

    protected void setTruthCheck(bool truthCheck)
    {
        if ((truthChance % 3) != 0)
        {
            truthCheck = true;
        }
        else
        {
            truthCheck = false;
        }

        this.truthCheck = truthCheck;
    }

    protected override bool getTruthCheck()
    {
        return truthCheck;
    }

    protected override Dictionary<string, string> getVillageInfo()
    {
        return null;
    }

    protected override ArrayList getWeaponProficiencies()
    {
        return null;
    }

    protected override int getWeaponSkill()
    {
        return 0;
    }
}
