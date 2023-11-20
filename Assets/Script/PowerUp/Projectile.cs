using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : PowerUp, Interactiv
{
    public override string skillName => "Burst";
    public float NweDamage = 5f;
    public void Action(GameObject player)
    {
        Debug.Log("Skill logic Burst");
        player.GetComponent<Player>().ShootPowerUp(NweDamage);
    }
}
