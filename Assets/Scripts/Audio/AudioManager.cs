using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : IAudioManager
{

    public void DestroySound()
    {
        Debug.Log("Sound Destroyed");
    }

    public override void PlaySound()
    {
        Debug.Log("Sound Played");
    }
}
