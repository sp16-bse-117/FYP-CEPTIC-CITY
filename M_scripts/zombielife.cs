﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombielife : MonoBehaviour
{
    public float life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takedamege(float amount)
    {
        life -= amount;
        if (life<=0)
        {    
           GetComponent<ZombieAnimationController>().death();
        }
    }
}
