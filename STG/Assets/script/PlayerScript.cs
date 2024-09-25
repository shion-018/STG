using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bulletPrefab; // ’e‚ÌPrefab
    public float bulletSpeed = 10.0f; // ’e‚ÌƒXƒs[ƒh
    public Transform bulletSpawnPoint; // ’e‚ª”­Ë‚³‚ê‚éˆÊ’u
    public float speed = 5.0f;
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
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = Vector2.up * bulletSpeed; // ’e‚ğã•ûŒü‚É”ò‚Î‚·
    }
}
