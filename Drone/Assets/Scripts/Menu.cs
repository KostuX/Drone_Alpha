using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Cube_Description;
    string scene = "MainMenu";



    public void start()
    {
        SceneManager.LoadScene(scene);
        Cube_Description = GameObject.Find("Cube_Description");
    }
    public static void start(string scene_temp) { SceneManager.LoadScene(scene_temp); }

    public void cube_Scene()
    {
        scene = "Cube";

        Cube_Description.gameObject.SetActive(true);

    }


    public void race_Scene()
    {
        scene = "Race";
        Cube_Description.gameObject.SetActive(false);
    }

    public void freeRun_Scene()
    {
        scene = "FreeRun";
        Cube_Description.gameObject.SetActive(false);
    }


}




