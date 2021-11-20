using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollision : MonoBehaviour
{
 bool   isColliding;
public GameMngr GameMngr_Script;

    // Start is called before the first frame update
    void Start()
    {
  GameMngr_Script = GameObject.Find("GameMngr").GetComponent<GameMngr>();
    }

    // Update is called once per frame
    void Update()
    {
isColliding = false;

    }

    private void OnTriggerExit(Collider other)
    {
        //-----------------------------------------------------------------------------------------------
        if(isColliding) return;
        isColliding = true;
        //https://answers.unity.com/questions/738991/ontriggerenter-being-called-multiple-times-in-succ.html
        
        
        Destroy(gameObject);

        if (gameObject.CompareTag("Point_Item"))
        {GameMngr_Script.score+=5; }

        if (gameObject.CompareTag("Time_Item"))
        {GameMngr_Script.score+=10; }

        if (gameObject.CompareTag("Speed_Item"))
        {GameMngr_Script.score+=15; }
    }



}
