using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMngr : MonoBehaviour
{
    public TextMeshProUGUI score_Text;
    public TextMeshProUGUI time_Text;
    public int score;
    public float time;
     public static GameObject playZone;
    // Start is called before the first frame update
    void Start()
    {
        playZone = GameObject.Find("PlayZone");
        score = 0;
        time = 0;

        score_Text.text = "Score: " + score;
        time_Text.text = "Time: " + time;
    }

    // Update is called once per frame
    void Update()
    {
        time_Text.text = "Time: " + (((int) playZone.transform.localScale.x /10));//((int) playZone_Size/10 - (int) Time.time);
        score_Text.text = "Score: " + score;
    }
}
