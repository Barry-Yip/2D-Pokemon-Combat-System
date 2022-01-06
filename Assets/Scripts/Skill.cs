using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "ScriptableObjects/Skill", order = 2)]
public class Skill : ScriptableObject
{
    public string skillName;
    public int skillDamage;

    [Header("Effect")]
    public ParticleSystem effect;

    [Header("Types")]
    public bool Normal;
    public bool Fire;
    public bool Water;
    public bool Grass;
    public bool Electric;
}