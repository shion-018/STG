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

    // �G��ǉ����郁�\�b�h
    public void AddEnemy(GameObject enemy)
    {
        enemies.Add(enemy);
    }

    // �G���폜���郁�\�b�h
    public void RemoveEnemy(GameObject enemy)
    {
        enemies.Remove(enemy);
    }

    // �G���X�g���擾���郁�\�b�h
    public GameObject[] GetEnemies()
    {
        return enemies.ToArray();
    }
}
