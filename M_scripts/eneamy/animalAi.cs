using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animalAi : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private float patroltimer;
    [SerializeField] private float patroltimermax;
    [SerializeField] private float minradius;
    [SerializeField] private float maxradius;

    private GameObject target;

    [SerializeField] private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        target=GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distoplayer = Vector3.Distance(transform.position, target.transform.position);
        if (target!=null)
        {
            if (distoplayer<7)
            {
                
                anim.SetBool("run", true);
                agent.speed = 2.5f;
               
            }
            else if (distoplayer>20)
            {
                anim.SetBool("run",false);
                agent.speed = 1.5f;

            }
            
        }
        patroltimer -= Time.deltaTime;
        if (patroltimer<=0)
        {
            setnewdistination();
            patroltimer = patroltimermax;    
        }
    }

    void setnewdistination()
    {
        float randomradius = Random.Range(minradius, maxradius);
        Vector3 ranDir = Random.insideUnitSphere * randomradius;
        NavMeshHit navhit;
        NavMesh.SamplePosition(ranDir, out navhit, randomradius, -1);
        agent.SetDestination(navhit.position);
    }
}
