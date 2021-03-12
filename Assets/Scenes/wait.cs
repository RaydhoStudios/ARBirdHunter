using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait : MonoBehaviour
  
{
    public float waittime = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait_for_intro());


    }

    private IEnumerator Wait_for_intro()
    {
        yield return new WaitForSeconds(waittime);

        SceneManager.LoadScene(1);
    }
}
/*{
public class BirdData
{
    public GameObject prefab;
    public int chancesToSpawn;
}
[SerializeField] private Transform[] _lanesStartPoint;
[SerializeField] private List<BirdData> _BirdDataList = new List<BirdData>();
public List<GameObject> DeletedBirds = new List<GameObject>();
private Coroutine _BirdSpawningCoroutine;
private int StartIndex;
public int numOfBirdsInAWave;
public float WaitTimeInEachWave;
public float decreamentInTimeAfterAWave;

public bool isFalling = false;

private int totalChances;
private void Awake()
{
    StartIndex = UnityEngine.Random.Range(0, _lanesStartPoint.Length);
    totalChances = 0;
    for (int i = 0; i < _BirdDataList.Count; i++)
    {
        totalChances += _BirdDataList[i].chancesToSpawn;
    }
}

private void Start()
{
    _BirdSpawningCoroutine = StartCoroutine(BirdSpawn());
}*/
/*
IEnumerator BirdSpawn()
{
    while (true)
    {
        if (isFalling)
        {
            for (int i = 0; i < numOfBirdsInAWave; i++)
            {
                GameObject TempBirds;
                if (DeletedBirds != null && DeletedBirds.Count > 0)
                {
                    TempBirds = DeletedBirds[0];
                    DeletedBirds.RemoveAt(0);
                    TempBirds.transform.position = _lanesStartPoint[StartIndex].position;
                    TempBirds.SetActive(true);
                }
                else
                {
                    TempBirds = Instantiate(_BirdDataList[RandomWeighted()].prefab, _lanesStartPoint[StartIndex]);
                }

                if (StartIndex >= _lanesStartPoint.Length / 2)
                {
                    StartIndex = UnityEngine.Random.Range(0, StartIndex);
                }
                else if (StartIndex < _lanesStartPoint.Length / 2)
                {
                    StartIndex = UnityEngine.Random.Range(StartIndex + 1, _lanesStartPoint.Length);
                }

                //yield return new WaitForSeconds(0.2f);
            }
            yield return new WaitForSeconds(DecWithTime());
        }
        yield return new WaitForEndOfFrame();

    }
}

private float DecWithTime()
{
    print(WaitTimeInEachWave);
    if (WaitTimeInEachWave <= 1) return 1;
    WaitTimeInEachWave -= decreamentInTimeAfterAWave;
    return WaitTimeInEachWave;
}

public void StopSpawning()
{
    StopCoroutine(_BirdSpawningCoroutine);
}

int RandomWeighted()
{
    int result = 0;
    int total = 0;
    int randVal = UnityEngine.Random.Range(0, totalChances);
    for (result = 0; result < _BirdDataList.Count; result++)
    {
        total += _BirdDataList[result].chancesToSpawn;
        if (total > randVal) break;
    }
    return result;
}
}*/