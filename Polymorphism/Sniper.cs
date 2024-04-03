using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Archer
{
    public override void Class()
    {
        base.Class();
        Debug.Log("Job 2: Sniper");
    }
}