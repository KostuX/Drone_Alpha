using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody drone_RB;
    public GameObject checkPoint;

    public GameObject playZone;
    public GameObject drone_OBJ;
    public float speed = 500f;
    public float turnSpeed = 100;



    // Start is called before the first frame update
    void Start()
    {
        drone_RB = GetComponent<Rigidbody>();
        drone_OBJ = GameObject.Find("Drone_OBJ");

        Physics.gravity *= 0;//gravityModifier; 
    }

    // Update is called once per frame
    void Update()
    {
        checkedInput();
        know_Your_Limits();
    }



    public void checkedInput()
    {

        // forward / backward
        if (Input.GetKey(KeyCode.W))
        { transform.Translate(Vector3.forward * Time.deltaTime * speed); }
        //  {drone_RB.AddForce(Vector3.forward * 10, ForceMode.Impulse);}


        if (Input.GetKey(KeyCode.S))
        { transform.Translate(Vector3.forward * Time.deltaTime * (-speed)); }

        //left / right
        if (Input.GetKey(KeyCode.D))
        { transform.Translate(Vector3.right * Time.deltaTime * turnSpeed); }
        if (Input.GetKey(KeyCode.A))
        { transform.Translate(Vector3.right * Time.deltaTime * (-turnSpeed)); }

        // up / down
        if (Input.GetKey(KeyCode.UpArrow))
        { transform.Translate(Vector3.up * Time.deltaTime * turnSpeed); }
        if (Input.GetKey(KeyCode.DownArrow))
        { transform.Translate(Vector3.up * Time.deltaTime * (-turnSpeed)); }

        //left / right
        if (Input.GetKey(KeyCode.RightArrow))
        { transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed / 2); }
        if (Input.GetKey(KeyCode.LeftArrow))
        { transform.Rotate(Vector3.up * Time.deltaTime * (-turnSpeed / 2)); }

    }

    private void OnTriggerExit(Collider other)
    {

    }

    void know_Your_Limits()
    {
        float half_Of_playZone = playZone.transform.localScale.x / 2;
        if (drone_OBJ.CompareTag("Drone_OBJ"))
        {
            if (gameObject.transform.position.x > half_Of_playZone)
            {
                transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
            }
            if (gameObject.transform.position.x < -half_Of_playZone)
            {
                transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            }

            if (gameObject.transform.position.y > half_Of_playZone)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            }
            if (gameObject.transform.position.y < -half_Of_playZone)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            }

            if (gameObject.transform.position.z > half_Of_playZone)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            }
            if (gameObject.transform.position.z < -half_Of_playZone)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            }


        }

    }
}
