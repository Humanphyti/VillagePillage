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
}
