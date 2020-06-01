using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showtext : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string fullstring;
   public string currentstring="";
    [SerializeField] private AudioSource adsource;
    [SerializeField] private AudioClip keypoordclick;

    [SerializeField] private int index;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startshowingtext());
    }

    // Update is called once per frame
    IEnumerator startshowingtext()
    {
        for (int i = 0; i < fullstring.Length; i++)
        {
            print("am called");
            index = i;
            this.GetComponent<Text>().text = currentstring;
            currentstring = fullstring.Substring(0, i);
            adsource.PlayOneShot(keypoordclick);
            yield return new WaitForSeconds(speed);
            if (i==fullstring.Length-1)
            {
                Scenamanager.instance.play();
            }
        }
    }
}
