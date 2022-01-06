using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unit", menuName = "ScriptableObjects/Unit", order = 1)]
public class Unit : ScriptableObject
{
    [Header("Basic Information")]
    public GameObject unit;
    public string unitName;
    public int unitLevel;
    public int maxHP;
    public int attack;
    public int defense;
    public int speed;

    [Header("Types")]
    public bool Normal;
    public bool Fire;
    public bool Water;
    public bool Grass;
    public bool Electric;

    [Header("Skill")]
    public Skill[] skills;
}
