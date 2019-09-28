using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Warrior : People
{
    

    //warrior constructor
    protected Warrior(int strength, bool sex, int age, int wealth, int health, int weaponSkill, ArrayList weaponProficiencies)
    {
        this.strength = strength;
        this.sex = sex;
        this.age = age;
        this.wealth = wealth;
        this.health = health;
        //this.weaponSkill = weaponSkill;
        //this.weaponProficiencies = weaponProficiencies;
    }
}
