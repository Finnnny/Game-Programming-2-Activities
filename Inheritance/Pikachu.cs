using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : Pokemon
{
    void Start()
    {
        pokeName = "Pikachu";
        pokeCate = "Mouse Pokemon";

        ability = Ability.Static;
        gender = Gender.Female;
        type = Type.Electric;

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
