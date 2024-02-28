using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glaceon : Pokemon
{
    void Start()
    {
        pokeName = "Glaceon";
        pokeCate = "Fresh Snow Pokemon";

        ability = Ability.Anticipation;
        gender = Gender.Female;
        type = Type.Ice;

        hp = 100;
        atk = 100;
        def = 100;
        spAtk = 100;
        spDef = 100;
        speed = 100;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
