using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10.0f;
    public float destroyTime = 3.0f;
    public float hitRadius = 1f; 

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        CheckDistance();
    }

    void CheckDistance()
    {
        GameObject[] enemies = EnemyManager.Instance.GetEnemies();

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < hitRadius)
            {
                EnemyManager.Instance.RemoveEnemy(enemy);
                Destroy(enemy);
                Destroy(gameObject);
                break; 
            }
        }
    }
}
