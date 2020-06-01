using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_Ai : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform target;
    public  bool reloading;
    [SerializeField] private int bullets;
    [SerializeField] private int reloadbullets;

    private void Awake()
    {
        bullets = reloadbullets;
        agent = GetComponent<NavMeshAgent>();
    }

    private float distance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position);

        if (reloading==false)
        {
            
            if (distance > 20 && !reloading)
            {
                
                chase();
            }


            if (distance < 20 && distance > 10 && !reloading)
            {
transform.LookAt(target);
                runandshoot();
            }

            if (distance < 10 && !reloading)
            {
                transform.LookAt(target);
                agent.stoppingDistance = 9f;
                shoot();
            }
        }

        

    }

    private void FixedUpdate()
    {
        if (bullets<2)
        {
            reloading = true;
            reloading = true;
            reload();  
        }
    }

    void shoot()
    {
        if (!reloading)
        {
            transform.LookAt(target);
            enamyanimations.instance.standandshoot();
        }
    }


    void chase()
    {
        if (!reloading)
        {
            agent.SetDestination(target.position);
            enamyanimations.instance.lookandwalk(true);
        }
    }

    void runandshoot()
    {
        if (!reloading)
        {
            agent.SetDestination(target.position);
            transform.LookAt(target);
            // lookat.instance.lookplayer();
            enamyanimations.instance.shootandrun();
        }
    }

    public void reload()
    {  reloading = true;
        bullets = reloadbullets;
      
        enamyanimations.instance.reload();
    }

    public void bulletsmanager()
    {
        if (bullets>0)
        {
            bullets--;
        }
    }

   
}
