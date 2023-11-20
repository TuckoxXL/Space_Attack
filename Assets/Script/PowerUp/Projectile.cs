using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : PowerUp, Interactiv
{
    public override string skillName => "Burst";
    public float NewDamage = 5f;
    public void Action(GameObject player)
    {
        player.GetComponent<Player>().ShootPowerUp(NewDamage);
    }
}
