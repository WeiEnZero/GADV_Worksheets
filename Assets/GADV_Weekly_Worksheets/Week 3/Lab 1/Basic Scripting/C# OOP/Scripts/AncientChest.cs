using UnityEngine;

public class AncientChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("AncientChest unlocked with a key");
    }
}
