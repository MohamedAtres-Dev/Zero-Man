using UnityEngine;
using UnityEngine.Events;


public class PlayerCollider : MonoBehaviour
{
    public static event UnityAction<int> onCoinCollected = delegate { };

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            onCoinCollected.Invoke(1);
            other.GetComponent<IPickUp>().WhenItIsTriggered();
        }
    }
}
