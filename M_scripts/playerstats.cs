using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct serializableVector3
{
    public float x;
    public float y;
    public float z;
    

    public Vector3 getpos()
    {
        return new Vector3(x,y,z);
    }
}

[System.Serializable]
public class stats
{
    public int goatkillcount;
    public int healcount;
    public float life;

    public int scenenumber;
    public serializableVector3 mypos;




}
 