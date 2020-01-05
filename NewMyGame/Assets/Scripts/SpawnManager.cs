using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _platformPrefab;

    //[SerializeField]
    //private GameObject _platformContainer;
    
    private bool _stopSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPlatformRoutine());
    }

IEnumerator SpawnPlatformRoutine()
    {
        while (_stopSpawning == false)
        {
            float x = Random.Range(1.22f, -1.22f);
            Vector3 spawnPos = new Vector3(x, -2.03f, -9.76f);

            GameObject newEnemy = Instantiate(_platformPrefab, spawnPos, Quaternion.identity);
            //newEnemy.transform.SetParent(_platformContainer.transform);

            // wait for 0.5 seconds
            yield return new WaitForSeconds(0.5f);
        }
    }

}
