using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Villager : People
{
    protected Villager(int strength, int age, bool sex, int wealth, int health)
    {
        this.strength = strength;
        this.age = age;
        this.sex = sex;
        this.wealth = wealth;
        this.health = health;
    }

    protected override float getGreed()
    {
        return greed;
    }

    protected override int getIntelligence()
    {
        return intelligence;
    }

    protected override float getLeadership()
    {
        return leadership;
    }

    protected override int getTruthChance()
    {
        return truthChance;
    }

    protected override bool getTruthCheck()
    {
        return truthCheck;
    }

    protected override int getWeaponSkill()
    {
        return weaponSkill;
    }

    protected override ArrayList getWeaponProficiencies()
    {
        return null;
    }

    protected override ArrayList getTalkingLines()
    {
        return null;
    }

    protected override Dictionary<string, string> getVillageInfo()
    {
        return null;
    }
}
