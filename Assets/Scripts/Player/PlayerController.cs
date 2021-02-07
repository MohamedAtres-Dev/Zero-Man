using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    private IAudioManager _audioManager;

    [Inject]
    public void Setup(IAudioManager audioManager)
    {
        _audioManager = audioManager;
    }

    private void Start()
    {
        _audioManager.PlaySound();
        
    }
}
