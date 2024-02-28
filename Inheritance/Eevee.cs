using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eevee : Pokemon
{
    void Start()
    {
        pokeName = "Eevee";
        pokeCate = "Evolution Pokemon";

        ability = Ability.Anticipation;
        gender = Gender.Male;
        type = Type.Normal;

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
