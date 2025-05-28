using JetBrains.Annotations;
using System;
using System.Runtime.CompilerServices;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering;

public class Main : MonoBehaviour
{ 
    public MagicChest chest;

    void Start()
    {
        //Player player = new Player(10);
        //player.TakeDamage(3);

        //Health health = new Health();
        //health.GetHealth();
        //health.TakeDamage(300);
        //health.GetHealth();
        //Projectile projectile = new Projectile(1f);
        //projectile.Fire();
        //ScoreTracker scoreTracker = new ScoreTracker();
        //scoreTracker.GetScore();

        chest.Unlock();
        chest.Shake();
        
    }

}