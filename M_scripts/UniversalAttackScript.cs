using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalAttackScript : MonoBehaviour
{
    [SerializeField] private float radius;
    [SerializeField] private LayerMask layer;
    public Camera maincam;
    
    // Start is called before the first frame update
    void Start()
    {
        maincam.GetComponent<CameraFilterPack_AAA_Blood>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        detectcollision();
    }

    void detectcollision()
    {
        Collider[] hitobj = Physics.OverlapSphere(transform.position, radius, layer);
        if (hitobj.Length>0)
        {
            if (hitobj[0].CompareTag("Player"))
            {
             Playerlife _playerlife=hitobj[0].GetComponent<Playerlife>();
             if (_playerlife !=null)
             {
                 _playerlife.takedamage(0.05f);
                 maincam.GetComponent<CameraFilterPack_AAA_Blood>().enabled = true;
                Invoke("turnofffilter",.5f);
              //  turnofffilter();
             }
            }
            gameObject.SetActive(false);
        }
    }

    public void turnofffilter()
    {
        maincam.GetComponent<CameraFilterPack_AAA_Blood>().enabled = false;

    }
}
