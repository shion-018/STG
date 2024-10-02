using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float bulletSpeed = 10.0f; 
    public Transform bulletSpawnPoint; 
    public float speed = 5.0f;
    [SerializeField] float bulletBurst = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0);
        transform.position += movement * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(IsShoot());
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = Vector2.up * bulletSpeed;
        Debug.Log("shoot!");
    }


    IEnumerator IsShoot()
    {
        Shoot();
        yield return new WaitForSeconds(bulletBurst);
        Shoot();
    }
}
