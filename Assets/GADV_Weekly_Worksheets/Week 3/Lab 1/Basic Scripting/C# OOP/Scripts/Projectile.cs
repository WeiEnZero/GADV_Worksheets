
using UnityEngine;

public class Projectile
{
    private float speed = 100;

    public Projectile(float speed)
    {
        this.speed = speed;
    }

    public void Fire()
    {
        if (speed > 0)
        {
            Debug.Log("Firing projectile at speed " + speed);
        }
        else
        {
            //Debug.Log("Cannot fire: speed too low.");
            AutoFire();
        }
    }

    private void AutoFire()
    {
        Debug.Log("Speed was Zero. AutoFire set speed to 100 and launched");
     }
}
