using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinderace : Pokemon
{
    void Start()
    {
        pokeName = "Cinderace";
        pokeCate = "Striker Pokemon";

        ability = Ability.Blaze;
        gender = Gender.Male;
        type = Type.Fire;

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
