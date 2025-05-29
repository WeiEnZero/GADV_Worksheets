using NUnit.Framework.Constraints;
using UnityEngine;

public class MagicChest : TreasureChest
{
    public override void Unlock(bool Key, bool HasToken)
    {
        //Debug.Log("MagicChest unlocked with a spell");
    }   
}
