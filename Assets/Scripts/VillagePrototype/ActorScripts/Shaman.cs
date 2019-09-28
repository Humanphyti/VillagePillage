using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class Shaman : People
{

    private int truthChance;
    private bool truthCheck;


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
}
