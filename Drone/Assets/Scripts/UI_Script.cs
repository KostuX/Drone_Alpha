using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class UI_Script : MonoBehaviour
{

    public TextMeshProUGUI score_Text, time_Text, health_Text;
    public TextMeshProUGUI end_Game_Title, end_Game_Score, end_Game_Time, end_Game_Total_Score, Top_Score;

    public GameMngr GameMngr_Script;

    // Start is called before the first frame update
    void Start()
    {
        GameMngr_Script = GameObject.Find("GameMngr").GetComponent<GameMngr>();

        score_Text.text = "Score: " + GameMngr_Script.score;
    }

    // Update is called once per frame
    void Update()
    {
        update_HUD();

        if (!GameMngr.alive || GameMngr_Script.survived) { update_End_Game_Pan(); }
    }



    void update_HUD()
    {
        time_Text.text = "Time: " + GameMngr_Script.time;
        score_Text.text = "Score: " + GameMngr_Script.score;
        health_Text.text = "Health: " + GameMngr_Script.health;
    }

    void update_End_Game_Pan()
    {
         end_Game_Title.text = GameMngr_Script.survived ? "Survived":"Game Over";

        end_Game_Score.text = "Score: " + GameMngr_Script.score;
        end_Game_Time.text = "Time: " + -GameMngr_Script.time;
        end_Game_Total_Score.text = "Total: " + (GameMngr_Script.score + -GameMngr_Script.time);

        if ((GameMngr_Script.score + -GameMngr_Script.time) > GameMngr.TopScore)
        {
            GameMngr.TopScore = (GameMngr_Script.score + -GameMngr_Script.time);
        }

        Top_Score.text = "Top Score: " + GameMngr.TopScore;
    }


    public void restart_Game() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
    public void load_Main_Menu_Scene() {  Menu.start("MainMenu"); }

    
}

