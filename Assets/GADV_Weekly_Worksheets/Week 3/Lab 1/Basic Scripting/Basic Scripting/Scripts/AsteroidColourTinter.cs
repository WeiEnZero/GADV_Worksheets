using System.Runtime.CompilerServices;
using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    private bool isBlue = false;
    void Update()
    { 
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Access the SpriteRenderer component
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

            // Change the color to blue
            if (isBlue == false)
            {
                spriteRenderer.color = Color.blue;
                isBlue = true;
            }
            else
            {
                spriteRenderer.color = Color.white;
                isBlue = false;
            }
        }
    }
}
/*public class AsteroidColourTinter : MonoBehaviour
{
    private bool isBlue = false;
    private Color originalColor;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isBlue == false)
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                originalColor = spriteRenderer.color;
                spriteRenderer.color = Color.blue;
                isBlue = true;
            }
            else
            {

                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.color = originalColor;
                isBlue = false;
            }
        }
    }
}
*/