using System;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        //Player player = new Player(10);
        //player.TakeDamage(3);

        Projectile projectile = new Projectile(1f);
        projectile.Fire();
        
    }

}
