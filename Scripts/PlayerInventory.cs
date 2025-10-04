using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int gemsCollected = 0;

    public void AddGem(int amount)
    {
        gemsCollected += amount;
        Debug.Log("Gemas: " + gemsCollected);
    }
}
