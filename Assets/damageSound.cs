using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageSound : MonoBehaviour
{
    public static damageSound clip;
    public AudioSource audio;
    public AudioClip pressed;
    private void Awake()
    {
        if (clip != null && clip != this)
        {
            Destroy(this.gameObject);
            return;
        }

        clip = this;
        DontDestroyOnLoad(this);
    }
}
