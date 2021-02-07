using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Player Data", menuName ="Data/Player")]
public class PlayerData : ScriptableObject
{
    #region fields
    [SerializeField] private int collectedCoins = 0;

    #endregion
    public int CollectedCoins { get => collectedCoins; set => collectedCoins = value; }
}
