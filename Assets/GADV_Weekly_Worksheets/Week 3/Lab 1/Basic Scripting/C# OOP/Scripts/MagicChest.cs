using UnityEngine;

public class MagicChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("MagicChest unlocked with a spell");
    }
}
