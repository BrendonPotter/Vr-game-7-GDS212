using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPart : MonoBehaviour
{   
    public GameObject square;
    public GameObject circle;
    public GameObject capsuale;

    public GameObject squarePrefab;
    public GameObject circlePrefab;
    public GameObject capsualPrefab;

    // Start is called before the first frame update
    void Start()
    {  
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawner()
    {
        if(square.activeSelf == true)
        {
            Instantiate(squarePrefab, transform.position, transform.rotation);
            Debug.Log("Spawned the cube");
        }
        else if(circle.activeSelf == true)
        {
            Instantiate (circlePrefab, transform.position, transform.rotation);
            Debug.Log("Spawned the sphere");

        }
        else if(capsuale.activeSelf == true)
        {
            Instantiate(capsualPrefab, transform.position, transform.rotation);
            Debug.Log("Spawned the capsual");
        }
    }

}
