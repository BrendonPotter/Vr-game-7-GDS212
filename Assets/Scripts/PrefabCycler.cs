using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCycler : MonoBehaviour
{
    public GameObject square;
    public GameObject circle;
    public GameObject capsual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonPressed()
    {       
        if(square.activeSelf == false && circle.activeSelf == false && capsual.activeSelf == false)
        {
            square.SetActive(true);
            Debug.Log("Button Pressed Checking none active");
        }
        else if (square.activeSelf == true)
        {
            square.SetActive(false);
            circle.SetActive(true);
            Debug.Log("Button Pressed Checking sqaure active");
        }
        else if (circle.activeSelf == true)
        {
            circle.SetActive(false);
            capsual.SetActive(true);
            Debug.Log("Button Pressed Checking circle active");
        }
        else if (capsual.activeSelf == true)
        {
            capsual.SetActive(false);
            square.SetActive(true);
            Debug.Log("Button Pressed Checking caspual active");
        }

        Debug.Log("Button Pressed Checking");
    }
}
