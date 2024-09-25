using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance; 
    private List<GameObject> enemies = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 敵を追加するメソッド
    public void AddEnemy(GameObject enemy)
    {
        enemies.Add(enemy);
    }

    // 敵を削除するメソッド
    public void RemoveEnemy(GameObject enemy)
    {
        enemies.Remove(enemy);
    }

    // 敵リストを取得するメソッド
    public GameObject[] GetEnemies()
    {
        return enemies.ToArray();
    }
}
