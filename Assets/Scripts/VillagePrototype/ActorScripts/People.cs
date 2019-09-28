using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class People : MonoBehaviour
{
    protected int strength, wealth, age, health, battleIntelligence, maxHealth;
    protected bool sex, truthCheck;
    protected string jarlInfo, shamanTruth;

    protected People()
    {
        strength = 45;
        sex = false;
        wealth = 600;
        age = 30;
        health = 100;
    }
}
