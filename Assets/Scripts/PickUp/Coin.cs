using UnityEngine;

public class Coin : MonoBehaviour, IPickUp
{

    public void WhenItIsTriggered()
    {
        gameObject.SetActive(false);
    }
}
