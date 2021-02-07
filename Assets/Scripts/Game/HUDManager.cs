using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HUDManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText = default;

    [SerializeField] private PlayerData playerData = default;
    // Start is called before the first frame update


    private void OnEnable()
    {
        PlayerCollider.onCoinCollected += UpdateHUD;
    }

    private void OnDisable()
    {
        PlayerCollider.onCoinCollected -= UpdateHUD;
    }
    

    void Start()
    {
        playerData.CollectedCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateHUD(int coinCollected)
    {
        playerData.CollectedCoins += coinCollected;
        coinsText.text = playerData.CollectedCoins.ToString();
        Debug.Log("Coin Collected");
    }
}
