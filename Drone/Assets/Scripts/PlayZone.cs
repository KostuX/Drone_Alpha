using UnityEngine;

public class PlayZone : MonoBehaviour
{
private SpawnManager spawnManager_Script;

    public float min_zone_Size;
    // Start is called before the first frame update
    void Start()
    {
         min_zone_Size = 30f;
        spawnManager_Script = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.localScale.x > min_zone_Size)
        {
         transform.localScale = new Vector3(
                                            transform.localScale.x /1.001f,
                                            transform.localScale.x /1.001f,
                                            transform.localScale.x /1.001f
                                             );
        }
        else{ spawnManager_Script.CancelInvoke();}
    }
}
