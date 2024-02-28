using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riolu : Pokemon
{
    void Start()
    {
        pokeName = "Riolu";
        pokeCate = "Emanation Pokemon";

        ability = Ability.Steadfast;
        gender = Gender.Female;
        type = Type.Fighting;

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
