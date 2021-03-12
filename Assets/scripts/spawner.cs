using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class spawner : MonoBehaviour
{
    //public Transform[] SpawnPoints;
    public GameObject[] Birds;
    public int xpos;
    public int zpos;
    public float spawntime = 15;
    private int count = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
        
 
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(5);
        if (Time.timeSinceLevelLoad <= 25f)
        {
            for (int i = 0; i < 2; i++)
            {
                xpos = Random.Range(-2, 2);
                zpos = Random.Range(3, 10);
                // Instantiate(Birds[i], SpawnPoints[i].position, Quaternion.Inverse(transform.rotation));
                GameObject newGO = Instantiate(Birds[i], new Vector3(xpos, Random.Range(-1,1), zpos), Quaternion.identity) as GameObject;
                Destroy(newGO, 12f);


            }
        }
        if (Time.timeSinceLevelLoad > 25f && Time.timeSinceLevelLoad <= 60f)
        {
            for (int i = 0; i < 4; i++)
            {
                xpos = Random.Range(-2, 2);
                zpos = Random.Range(3, 10);
                // Instantiate(Birds[i], SpawnPoints[i].position, Quaternion.Inverse(transform.rotation));
                GameObject newGO = Instantiate(Birds[i], new Vector3(xpos, Random.Range(-1,1), zpos), Quaternion.identity) as GameObject;
                Destroy(newGO, 12f);


            }
        }
        if (Time.timeSinceLevelLoad > 60f && Time.timeSinceLevelLoad <= 90f)
        {
            for (int i = 0; i < 5; i++)
            {
                xpos = Random.Range(-2, 2);
                zpos = Random.Range(3, 10);
                // Instantiate(Birds[i], SpawnPoints[i].position, Quaternion.Inverse(transform.rotation));
                GameObject newGO = Instantiate(Birds[i], new Vector3(xpos, Random.Range(-1,1), zpos), Quaternion.identity) as GameObject;
                Destroy(newGO, 12f);


            }
        }
        if (Time.timeSinceLevelLoad > 90f && Time.timeSinceLevelLoad <= 120f)
        {
            for (int i = 0; i < 6; i++)
            {
                xpos = Random.Range(-2, 2);
                zpos = Random.Range(3, 10);
                // Instantiate(Birds[i], SpawnPoints[i].position, Quaternion.Inverse(transform.rotation));
                GameObject newGO = Instantiate(Birds[i], new Vector3(xpos, Random.Range(-1,1), zpos), Quaternion.identity) as GameObject;
                Destroy(newGO, 12f);


            }
        }
        if (Time.timeSinceLevelLoad > 120f)
        {
            for (int i = 0; i < 6; i++)
            {
                xpos = Random.Range(-2, 2);
                zpos = Random.Range(3, 10);
                // Instantiate(Birds[i], SpawnPoints[i].position, Quaternion.Inverse(transform.rotation));
                GameObject newGO = Instantiate(Birds[i], new Vector3(xpos, Random.Range(-1,1), zpos), Quaternion.identity) as GameObject;
                Destroy(newGO, 12f);


            }
           // count++;
        }
        
        StartCoroutine(StartSpawning());
    }
 
  
}
