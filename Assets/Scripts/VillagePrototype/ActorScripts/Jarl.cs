using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Random.Range;

class Jarl : People
{
    //jarl specific variables
    private ArrayList talkingLines;
    private Dictionary<string, string> villageInfo;
    private float greed, leadership;

    //jarl constructor
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
}
