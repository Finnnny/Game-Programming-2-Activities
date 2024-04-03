using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Adventurer
{
    public override void Class()
    {
        base.Class();
        Debug.Log("Job 1: Swordsman");
    }
}
