using System;
using System.Runtime.CompilerServices;
using UnityEditor.SearchService;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        //Player player = new Player(10);
        //player.TakeDamage(3);

        Health health = new Health();
        health.GetHealth();
        health.TakeDamage(100);
        health.GetHealth();
        Projectile projectile = new Projectile(1f);
        projectile.Fire();
        
    }

}

public class Health
{
    private int health = 100;

    public void TakeDamage(int damage)
    {
        if (health > 0)
        {
            health-=100;
        }
    }      

    public void GetHealth()
    {
        Debug.Log("Your health is " + health);
    }


}