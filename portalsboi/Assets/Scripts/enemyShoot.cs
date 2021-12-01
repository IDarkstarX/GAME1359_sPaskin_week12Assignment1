using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    GameObject gunSource;

    [SerializeField]
    float bulletSpeed;

    [SerializeField]
    public bool canShoot = false;

    [SerializeField]
    float fireRate = 1;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        //gunSource = FindObjectOfType<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Can I shoot? > " + canShoot);
        timer += Time.deltaTime;
        if (canShoot && timer >= fireRate)
        {
            timer = 0;
            Vector3 bulletDirection = transform.forward * bulletSpeed;
            GameObject b = Instantiate(bullet, gunSource.transform.position, transform.rotation);
            b.GetComponent<Rigidbody>().velocity = bulletDirection;
        }
    }
}
