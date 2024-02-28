using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaymin : Pokemon
{
    void Start()
    {
        pokeName = "Shaymin (Land Forme)";
        pokeCate = "Gratitude Pokemon";

        ability = Ability.Steadfast;
        gender = Gender.Unknown;
        type = Type.Grass;

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
