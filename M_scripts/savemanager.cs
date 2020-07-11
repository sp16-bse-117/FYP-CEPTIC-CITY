using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class savemanager : MonoBehaviour
{
    public playershooting _playerstat;
   

    private void Awake()
    {
        
        _playerstat = GameObject.FindObjectOfType<playershooting>();

        load();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void save()
    {
        FileStream file=new FileStream(Application.persistentDataPath + "/player.dat",FileMode.OpenOrCreate);
        BinaryFormatter formatter=new BinaryFormatter();
        formatter.Serialize(file,_playerstat.mystats);
        file.Close();
        
    }

    public void load()
    {
        FileStream file=new FileStream(Application.persistentDataPath + "/player.dat",FileMode.Open);
        BinaryFormatter formatter=new BinaryFormatter();
          _playerstat.mystats= (stats) formatter.Deserialize(file);    
      file.Close();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F5))
        {
            save();
        }
    }

    
}    
