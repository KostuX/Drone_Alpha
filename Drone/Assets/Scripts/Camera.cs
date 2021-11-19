using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

public GameObject drone;
Vector3 cameraOffSet =  new Vector3(0 ,5, -15);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //TODO Camere moved to Drone OBJ to solve rotation problem




      // transform.position =  drone.transform.position + cameraOffSet;
      //   float  horisontalInput = Input.GetAxis("Horizontal");
      // transform.Rotate(Vector3.up * Time.deltaTime * 100 * horisontalInput); 
}}
