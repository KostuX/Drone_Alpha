using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     transform.localScale = new Vector3(transform.localScale.x /1.001f ,transform.localScale.x /1.001f,transform.localScale.x /1.001f);//transform.localScale *Time.deltaTime * 0.1f ; 
    
    }
}
