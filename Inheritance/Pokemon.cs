using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    [Header("Pokemon Name and Category")]
    public string pokeName;
    public string pokeCate;

    [Header("Abilities")]
    public Ability ability;

    [Header("Gender")]
    public Gender gender;

    [Header("Typing")]
    public Type type;

    [Header("Base Stats")]
    public int hp;
    public int atk;
    public int def;
    public int spAtk;
    public int spDef;
    public int speed;

}
