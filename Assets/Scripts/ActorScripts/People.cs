using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class People : MonoBehaviour
{
    protected int strength, wealth, age, weaponSkill, health, intelligence, truthChance;
    protected float greed, leadership;
    protected bool sex, truthCheck;
    protected ArrayList weaponProficiencies;
    protected ArrayList talkingLines;
    protected Dictionary<String, String> villageInfo;


    protected People()
    {
        strength = 45;
        sex = false;
        wealth = 600;
        age = 30;
        health = 100;
    }

    //strength setter and getter
    public void setStrength(int strength)
    {
        this.strength = strength;
    }

    public int getStrength()
    {
        return strength;
    }

    //health setter and getter
    public void setHealth(int health)
    {
        this.health = health;
    }

    public int getHealth()
    {
        return health;
    }

    //sex setter and getter
    public void setSex(bool sex)
    {
        this.sex = sex;
    }

    public bool getSex()
    {
        return sex;
    }

    //wealth setter and getter
    public void setWealth(int wealth)
    {
        this.wealth = wealth;
    }

    public int getWealth()
    {
        return wealth;
    }

    //age setter and getter
    public void setAge(int age)
    {
        this.age = age;
    }

    public int getAge()
    {
        return age;
    }

    //leadership setter and getter
    protected abstract float getLeadership();

    //greed setter and getter
    protected abstract float getGreed();

    //weaponSkill setter and getter
    protected abstract int getWeaponSkill();

    //intelligence setter and getter
    protected abstract int getIntelligence();

    //truthChance setter and getter
    protected abstract int getTruthChance();

    //truthCheck setter and getter
    protected abstract bool getTruthCheck();

    //weaponProficiencies getter
    protected abstract ArrayList getWeaponProficiencies();

    //talkingLines getter
    protected abstract ArrayList getTalkingLines();

    //dictionary getter
    protected abstract Dictionary<string, string> getVillageInfo();
}
