using UnityEngine;

public class switching : MonoBehaviour
{
    [SerializeField] private GameObject[] btns;
    [SerializeField] private GameObject[] cam;
    [SerializeField] private GameObject dummycar;

    [SerializeField] private Vector3 offset;
    [SerializeField] private GameObject[] role;

    // Start is called before the first frame update
    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("doctor"))
        {
            // gameObject.GetComponent<Collider>().enabled = false;
            btns[0].SetActive(true); //enter car
            btns[1].SetActive(false); //exit
        }

        if (other.gameObject.CompareTag("Car"))
        {
            print("am car");
            btns[0].SetActive(false); //enter car
            btns[1].SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("doctor"))
        {
            // gameObject.GetComponent<Collider>().enabled = false;
            btns[0].SetActive(false); //enter car
            btns[1].SetActive(false); //exit
        }

        if (other.gameObject.CompareTag("Car"))
        {
            btns[0].SetActive(false); //enter car
            btns[1].SetActive(false);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void entercar()
    {
        dummycar.SetActive(false);
        role[0].SetActive(false); //doctor
        cam[0].SetActive(false); //doc cam
        role[1].SetActive(true); //car
        cam[1].SetActive(true); //car cam

        btns[0].SetActive(false);
    }

    public void exitcar()
    {
        role[0].transform.position = role[1].transform.position + offset;
        dummycar.transform.position = role[1].transform.position;
        
        role[1].SetActive(false); //car
        cam[1].SetActive(false); //car cam
        dummycar.SetActive(true);
        role[0].SetActive(true); //dector
        cam[0].SetActive(true); //doc cam
        
    }
}