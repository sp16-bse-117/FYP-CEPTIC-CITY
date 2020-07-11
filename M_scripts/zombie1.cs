using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie1 : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private float minradius, maxradius;

    [SerializeField] private Transform player;

    public bool die=false;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (die == false)
        {


            if (Vector3.Distance(transform.position, player.position) <= 2)
            {
                //attack
                attack();
            }
            else if (Vector3.Distance(transform.position, player.position) > 2 &&
                     Vector3.Distance(transform.position, player.position) < 15f)
            {
                // chasing
                chase();
            }
            else if (Vector3.Distance(transform.position, player.position) > 30)
            {
                //patrolling
                patroll();

            }
        }
        else
        {
            agent.updatePosition = false;
        }

    }

    void patroll()
    {
        agent.speed = .5f;
        float randradius = Random.Range(minradius, maxradius);
        Vector3 randir = Random.insideUnitSphere * randradius;
        NavMeshHit navhit;
        NavMesh.SamplePosition(randir, out navhit, randradius, -1);
        agent.SetDestination(navhit.position); 
        GetComponent<ZombieAnimationController>().walk();


    }

    void chase()
    {
        agent.speed = .75f;
        GetComponent<ZombieAnimationController>().run();

        agent.SetDestination(player.position);
        transform.LookAt(new Vector3(player.position.x,transform.position.y,player.position.z));
    }

   
       
    
    
    void attack()
    {
        GetComponent<ZombieAnimationController>().attack();

    }
        
}
