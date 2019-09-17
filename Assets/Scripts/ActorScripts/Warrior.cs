using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Warrior : People
{
    private 
    protected Warrior(int strength, bool sex, int age, int wealth, int health, int weaponSkill, ArrayList weaponProficiencies)
    {
        this.strength = strength;
        this.sex = sex;
        this.age = age;
        this.wealth = wealth;
        this.health = health;
        this.weaponSkill = weaponSkill;
        this.weaponProficiencies = weaponProficiencies;
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

    protected override int getTruthChance()
    {
        return 0;
    }

    protected override bool getTruthCheck()
    {
        return false;
    }

    protected override int getWeaponSkill()
    {
        return weaponSkill;
    }

    protected void setWeaponSkill(int weaponSkill)
    {
        this.weaponSkill = weaponSkill;
    }

    protected void setWeaponProficiencies(ArrayList weaponProficiencies)
    {
        this.weaponProficiencies = weaponProficiencies;
    }

    protected override ArrayList getWeaponProficiencies()
    {
        return weaponProficiencies;
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
