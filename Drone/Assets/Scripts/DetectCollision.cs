using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
                            // destroy object when collected
        Destroy(gameObject);

        if (gameObject.CompareTag("Point_Item"))
           { Debug.Log("Points_Item");}

        if (gameObject.CompareTag("Time_Item"))
           { Debug.Log("Time_Item");}

       if (gameObject.CompareTag("Speed_Item"))
           { Debug.Log("Speed_Item");}
    }



}
