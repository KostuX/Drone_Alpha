using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    string scene = "Cube";

public void start(){ SceneManager.LoadScene(scene);}

public void cube_Scene(){ scene = "Cube"; }
public void race_Scene(){ scene = "Race"; }
public void freeRun_Scene(){ scene = "FreeRun"; }


}




