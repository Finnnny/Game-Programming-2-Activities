using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : Archer
{
    public override void Class()
    {
        base.Class();
        Debug.Log("Job 2: Crossbow");
    }
}
