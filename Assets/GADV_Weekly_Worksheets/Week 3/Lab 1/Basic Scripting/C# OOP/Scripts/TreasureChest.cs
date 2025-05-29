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

    public virtual void Unlock(bool HasKey, bool HasToken)
    {
        if (HasKey == true && HasToken == true)
        {
            Debug.Log("TreasureChest: Unlock with bonus gift");
        }
        else
        {
            Debug.Log("TrasureChest: Unlock");
        }
    }
}
