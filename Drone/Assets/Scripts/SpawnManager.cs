using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] checkPoints;
    public GameObject boxSize;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("randomSpawn", 2 , 0.5f);

        for(int i = 0; i < 10; i++){ randomSpawn();}
    }

    // Update is called once per frame
    void Update()
    {
 
    }

void randomSpawn()
{
    int i = ((int) boxSize.transform.localScale.x/2)-10; 
    
            int checkPointIndex = Random.Range(0, 3);
            int randomX = Random.Range(-i, i);
            int randomY = Random.Range(-i, i);
            int randomZ = Random.Range(-i, i);

            Instantiate(checkPoints[checkPointIndex], new Vector3(randomX, randomY, randomZ), checkPoints[checkPointIndex].transform.rotation);
}








}
