using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVELSELECTM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void firstmission()
    {
        SceneManager.LoadScene(2);
    }

    public void secondmission()
    {
        SceneManager.LoadScene(3);
    }

    public void thirdmission()
    {
        SceneManager.LoadScene(4);
    }

    public void backbutton()
    {
        SceneManager.LoadScene(0);
    }
}
