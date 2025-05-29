using UnityEngine;

public class ExplodingItem : Explodable
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Explode();
            GetComponent<Explodable>()?.Explode();
        }
    }
}