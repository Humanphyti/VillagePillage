using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Jarl : People
{
    //private float leadership;
    protected Jarl(int strength, bool sex, int age, int wealth, float leadership, float greed, ArrayList talkingLines, Dictionary<string, string> villageInfo)
    {
        this.strength = strength;
        this.sex = sex;
        this.age = age;
        this.wealth = wealth;
        this.leadership = leadership;
        this.greed = greed;
        this.talkingLines = talkingLines;
        this.villageInfo = villageInfo;
    }

    protected void setGreed(float greed)
    {
        this.greed = greed;
    }

    protected override float getGreed()
    {
        return greed;
    }

    protected override int getIntelligence()
    {
        return 0;
    }

    protected void setLeadership(float leadership)
    {
        
    }

    protected override float getLeadership()
    {
        return leadership;
    }

    protected override int getTruthChance()
    {
        return 0;
    }

    protected override bool getTruthCheck()
    {
        return false;
    }

    protected override ArrayList getWeaponProficiencies()
    {
        return null;
    }

    protected override ArrayList getTalkingLines()
    {
        return talkingLines;
    }

    protected override int getWeaponSkill()
    {
        return 0;
    }

    protected override Dictionary<string, string> getVillageInfo()
    {
        return villageInfo;
    }
}
