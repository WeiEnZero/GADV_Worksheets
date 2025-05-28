using UnityEngine;

public class Health
{
    private int health = 2000;

    public void TakeDamage(int damage)
    {
        if ((health - damage) < 0)
        {
            health = 0;
        }
        else if((health - damage) > 0)
        {
            health -= damage;
        }
    }

    public void GetHealth()
    {
        Debug.Log("Your health is " + health);
    }


}