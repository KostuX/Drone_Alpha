using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameMngr : MonoBehaviour
{

    public Button gitHub_Button;
    public GameObject game_Over;
    public static GameObject playZone;
    public static bool alive;
    public int score, time, health;
    public static int TopScore = 3;

      float current_Time;
    float countDown_Time = 4;
    public TextMeshProUGUI countDown_Text;


    // Start is called before the first frame update
    void Start()
    {

 playZone = GameObject.Find("PlayZone");   

  current_Time = (int)countDown_Time;

        alive = true;
        score = 0;
        time = 0;
        health = 100;
        isTimeTo_Play();

    }

    // Update is called once per frame
    void Update()
    {
      if(alive && isTimeTo_Play()) { time = (((int)playZone.transform.localScale.x / 10) - 3);}

      isTimeTo_Play();
    }

    public void deduct_Health()
    {
        if (health > 5) { health -= 5; }
        else
        {
            health = 0;
            gameOver();
            alive = false;
        }
    }

    public void gameOver() { game_Over.gameObject.SetActive(true);}

    public void restart_Game() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }

    public void link_GitHub() { Application.OpenURL("https://github.com/KostuX/Drone_Alpha"); }
    public void link_WebGL() { Application.OpenURL("http://Kostas.fun"); }

    public void MainMenu_Scene() { SceneManager.LoadScene(0); }
    public void cube_Scene() { SceneManager.LoadScene(1); }
    public void freeRun_Scene() { SceneManager.LoadScene(2); }

        public bool isTimeTo_Play()
    {
        if (current_Time < -1) { countDown_Text.text = ""; }          // destry obj instead
        if (current_Time < 0 && current_Time > -3) { countDown_Text.text = "GO!!!"; }
        if (current_Time < 4 && current_Time > 0) { countDown_Text.text = current_Time.ToString("0"); }
        if (current_Time > 3){ countDown_Text.text = "Ready?!"; }

        current_Time -= 1 * Time.deltaTime;

        return current_Time < 0 ? true : false;
    }

}
