using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shinx : Pokemon
{
    void Start()
    {
        pokeName = "Shinx";
        pokeCate = "Flash Pokemon";

        ability = Ability.Rivalry;
        gender = Gender.Male;
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
