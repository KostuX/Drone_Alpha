using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public GameObject Cube_Description;
     public GameObject Drone_Model;
     public TextMeshProUGUI Cube_Top_Score;

     


    string scene = "MainMenu";



    public void start()
    {
        GameMngr.alive = true;
        SceneManager.LoadScene(scene);
   
    }
    public static void start(string scene_temp) {Time.timeScale = 1f; SceneManager.LoadScene(scene_temp); }

    public void cube_Scene()
    {
        scene = "Cube";

        Cube_Description.gameObject.SetActive(true);
        Drone_Model.gameObject.SetActive(false);

         Cube_Top_Score.text = "Top score is: " + GameMngr.TopScore;

        

    }


    public void race_Scene()
    {
        scene = "MainMenu";
      //  scene = "Race";
        Cube_Description.gameObject.SetActive(false);
        Drone_Model.gameObject.SetActive(true);
    }

    public void freeRun_Scene()
    {
        scene = "MainMenu";
     //   scene = "FreeRun";
     Drone_Model.gameObject.SetActive(true);
        Cube_Description.gameObject.SetActive(false);
    }


}




