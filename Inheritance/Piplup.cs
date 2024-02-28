using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piplup : Pokemon
{
    void Start()
    {
        pokeName = "Piplup";
        pokeCate = "Penguin Pokemon";

        ability = Ability.Torrent;
        gender = Gender.Male;
        type = Type.Water;

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
