using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cursor = UnityEngine.WSA.Cursor;

public class preycount : MonoBehaviour
{
    [SerializeField] private Text countxt;
    public static int count;

    private void Start()
    {
        
        count = 0;
    }

    private void Update()
    {
        countxt.text = count.ToString();
    }
}
