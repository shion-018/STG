using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab; 
    public float spawnTimer = 2.0f;
    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.0f, spawnTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        GameObject enemy  = Instantiate(enemyPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
        
        EnemyManager.Instance.AddEnemy(enemy);
    }
}
