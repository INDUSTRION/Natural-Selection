using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public static BGMusic music;

    private void Awake()
    {
        if(music != null && music != this)
        {
            Destroy(gameObject);
            return;
        }

        music = this;
        DontDestroyOnLoad(this);
    }
}
