using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : PowerUp
{
    public override string skillName => "Burst"; 
    public override void Activate()
    {
        Debug.Log("Skill logic Burst");
    }
}
