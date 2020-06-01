using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershooting : MonoBehaviour
{

    [SerializeField] private GameObject fpscam;

    private LayerMask enemylayer;

    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") )
        {
            RaycastHit hit;
            if (Physics.Raycast(fpscam.transform.position,fpscam.transform.forward,out hit))
            {
                print(hit.transform.name);
                animallife _animallife = hit.transform.GetComponent<animallife>();
                if (_animallife != null)
                {
                    _animallife.takedamage(damage);
                }
            }
        }
    }
}
