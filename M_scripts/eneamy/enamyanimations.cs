using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enamyanimations : MonoBehaviour
{
    
    public Animator anim;
    public enemy_Ai _instance;
    public  static enamyanimations instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = GetComponent<enamyanimations>();
        anim = GetComponentInChildren<Animator>();
    }

    public void shootandrun()
    {
        anim.SetTrigger(AnimationTags.shootandrun);
        lookandwalk(false);
    }

    public void standandshoot()
    {
        anim.SetTrigger(AnimationTags.shoottriger);
    }

    public void lookandwalk(bool value)
    {
        anim.SetBool(AnimationTags.lookandwalk,value);
    }

    public void death()
    {
        anim.SetTrigger(AnimationTags.death);
    }

    public void reload()
    {
        anim.SetTrigger(AnimationTags.reload);
        anim.SetBool(AnimationTags.reloading,true);
    }
    public void reloading()
    {
        _instance.reloading=false;
        anim.SetBool(AnimationTags.reloading,false);
    }
}
