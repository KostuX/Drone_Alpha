using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameMngr : MonoBehaviour
{
    public TextMeshProUGUI score_Text, time_Text, health_Text;
    public Button gitHub_Button;
    public GameObject game_Over;
    public static bool alive;



    public int score, time, health;
    public static GameObject playZone;
    // Start is called before the first frame update
    void Start()
    {
        
        playZone = GameObject.Find("PlayZone");
        score = 0;
        time = 0;
        health = 100;
        alive = true;
        score_Text.text = "Score: " + score;

        //  time_Text.text = "Time: " + time;
    }

    // Update is called once per frame
    void Update()
    {
        if( GameMngr.alive){
        time_Text.text = "Time: " + (((int)playZone.transform.localScale.x / 10) - 3);
        score_Text.text = "Score: " + score;
        health_Text.text = "Health: " + health;
        }
    }

    public void deduct_Health()
    {
        if (health > 5) { health -= 5; }
        else
        {
            health = 0;
            gameOver();
            GameMngr.alive = false;
        }
    }

    public void gameOver(){game_Over.gameObject.SetActive(true);}

    public void restart_Game(){ SceneManager.LoadScene(SceneManager.GetActiveScene().name);}

    public void link_GitHub(){Application.OpenURL("https://github.com/KostuX/Drone_Alpha");}
    public void link_WebGL(){Application.OpenURL("http://Kostas.fun");}

    public void MainMenu_Scene(){SceneManager.LoadScene(0);}
    public void cube_Scene(){SceneManager.LoadScene(1);}
    public void freeRun_Scene(){SceneManager.LoadScene(2);}




}
