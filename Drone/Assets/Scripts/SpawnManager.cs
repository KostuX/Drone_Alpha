using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] checkPoints;
    public GameObject playZone;

    float half_Of_playZone;




    // Start is called before the first frame update
    void Start()
    {
        playZone = GameObject.Find("PlayZone");
        InvokeRepeating("randomSpawn", 2, 1f);


        for (int i = 0; i < 10; i++) { randomSpawn(); }
    }

    // Update is called once per frame
    void Update()
    {
        half_Of_playZone = playZone.transform.localScale.x / 2;

        destroy_FN();


    }

    void randomSpawn()
    {
        int i = ((int)playZone.transform.localScale.x / 2) - 10;

        int checkPointIndex = Random.Range(0, 3);
        int randomX = Random.Range(-i, i);
        int randomY = Random.Range(-i, i);
        int randomZ = Random.Range(-i, i);

        Instantiate(checkPoints[checkPointIndex], new Vector3(randomX, randomY, randomZ), checkPoints[checkPointIndex].transform.rotation);
    }



    void destroy_FN()
    {

        if (gameObject.CompareTag("Point_Item") || gameObject.CompareTag("Time_Item") || gameObject.CompareTag("Speed_Item"))
        {

            if (gameObject.transform.position.x > half_Of_playZone) { Destroy(gameObject); }
            if (gameObject.transform.position.x < -half_Of_playZone) { Destroy(gameObject); }

            if (gameObject.transform.position.y > half_Of_playZone) { Destroy(gameObject); }
            if (gameObject.transform.position.y < -half_Of_playZone) { Destroy(gameObject); }

            if (gameObject.transform.position.z > half_Of_playZone) { Destroy(gameObject); }
            if (gameObject.transform.position.z < -half_Of_playZone) { Destroy(gameObject); }

        }

    }




}
