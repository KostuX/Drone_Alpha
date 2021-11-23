using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Cube_Description;
     public GameObject Drone_Model;
    string scene = "MainMenu";



    public void start()
    {
        GameMngr.alive = true;
        SceneManager.LoadScene(scene);
   //     Cube_Description = GameObject.Find("Cube_Description");
    }
    public static void start(string scene_temp) {Time.timeScale = 1f; SceneManager.LoadScene(scene_temp); }

    public void cube_Scene()
    {
        scene = "Cube";

        Cube_Description.gameObject.SetActive(true);
        Drone_Model.gameObject.SetActive(false);

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




