using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody drone_RB;
public GameObject checkPoint;


    public float speed = 500f;
    public float turnSpeed = 200;
  


    // Start is called before the first frame update
    void Start()
    {
         drone_RB = GetComponent<Rigidbody>();

         Physics.gravity *= 0;//gravityModifier; 
       

    }

    // Update is called once per frame
    void Update()
    {



 

        checkedInput();

        // ToDO tilt drone when turning 


 
    }



    public void checkedInput()
    {





        // forward / backward
        if (Input.GetKey(KeyCode.W))
             {transform.Translate(Vector3.forward * Time.deltaTime * speed); }
             //  {drone_RB.AddForce(Vector3.forward * 10, ForceMode.Impulse);}


        if (Input.GetKey(KeyCode.S))
             { transform.Translate(Vector3.forward * Time.deltaTime * (-speed));}

        //left / right
        if (Input.GetKey(KeyCode.D))
             { transform.Translate(Vector3.right * Time.deltaTime * turnSpeed); }
        if (Input.GetKey(KeyCode.A))
            { transform.Translate(Vector3.right * Time.deltaTime * (-turnSpeed)); }

        // up / down
        if (Input.GetKey(KeyCode.UpArrow))
             { transform.Translate(Vector3.up * Time.deltaTime * turnSpeed); }
        if (Input.GetKey(KeyCode.DownArrow))
             { transform.Translate(Vector3.up * Time.deltaTime * (-turnSpeed));}

        //left / right
        if (Input.GetKey(KeyCode.RightArrow))
            { transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed/2) ; }
        if (Input.GetKey(KeyCode.LeftArrow))
            { transform.Rotate(Vector3.up * Time.deltaTime * (-turnSpeed/2) );}

    }

private void OnTriggerExit(Collider other) 
{
  transform.Translate(Vector3.forward * Time.deltaTime * -speed); 
}





}
