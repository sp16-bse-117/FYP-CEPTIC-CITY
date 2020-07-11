using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ZombieAnimationController : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public static ZombieAnimationController instance;

    public static int count;
    public GameObject healobj;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
      //  anim = GetComponent<Animator>();
        instance = GetComponent<ZombieAnimationController>();
    }

    // Update is called once per frame
    void Update()
    {    
   
    }

    public void walk()
    {
      anim.SetBool(ZombieAnimation.walk,true); 
      anim.SetBool(ZombieAnimation.run,false);
    }

    public void run()
    {
        anim.SetBool(ZombieAnimation.run,true);
        anim.SetBool(ZombieAnimation.walk,false);
    }

    public void attack()
    {
        anim.SetTrigger(ZombieAnimation.attack);
        anim.SetBool(ZombieAnimation.run,false);
        anim.SetBool(ZombieAnimation.walk,false);


    }

    public void death()
    {
       
        anim.SetBool(ZombieAnimation.death,true);
        anim.SetBool(ZombieAnimation.walk,false);
        anim.SetBool(ZombieAnimation.run,false);
        zombie1 _zombie1 = GetComponent<zombie1>();
        if (_zombie1 != null)
        {
           
            _zombie1.die = true;
           // Invoke("destroyZombie",4);
        }
      
    }

   
    public IEnumerator destroy()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);     
    }

    public void Hzombieidle()
    {
        anim.SetBool(healingzombie.idle,true);
    }
    public void Hzombiewalk()
    {
        anim.SetBool(healingzombie.idle,false);
    }

    public void healplayer()
    {
        count ++;
        if (count >= 3)
        {
            print(count);
            Instantiate(healobj, transform.position, healobj.transform.rotation);
            resetcount();
        }
    }

    void resetcount()
    {
        count = 0;
    }
}
