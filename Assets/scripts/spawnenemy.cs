using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class spawnenemy : MonoBehaviour
{
    public GameObject zoombie;
    public float SpawnTime = 4f;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", SpawnTime, SpawnTime);
        
    }
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(zoombie, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
