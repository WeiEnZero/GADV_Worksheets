using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public virtual void Unlock()
    {
        Debug.Log("TreasureChest: Unlock");
    }

    public void Shake()
    {
        Debug.Log("You hear something rattle inside the chest");
    }
}
