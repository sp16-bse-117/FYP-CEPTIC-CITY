using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiocoltroller : MonoBehaviour
{
    [SerializeField] private AudioSource asoure;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    private void Update()
    {
        asoure = GetComponent<AudioSource>();
        int canplay=  PlayerPrefs.GetInt("music");
        if (canplay==0)
        {
            asoure.mute = true;
        }
        else
        {
            asoure.mute = false;
        }
    }
}
