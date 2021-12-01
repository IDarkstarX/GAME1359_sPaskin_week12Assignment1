using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    [SerializeField]
    float bulletLifetime = 5;

    float elapsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if(elapsed >= bulletLifetime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            //gameManager.instance.score += 1;

            //Destroy(collision.gameObject.transform.parent.gameObject);

            gameManager.instance.health -= 5;
            Debug.Log("I hit the player!");
            Destroy(gameObject);
        } else if (collision.transform.tag == "walls")
        {
            Debug.Log("I hit the wall!");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            //gameManager.instance.score += 1;

            //Destroy(collision.gameObject.transform.parent.gameObject);

            gameManager.instance.health -= 5;
            Debug.Log("I hit the player!");
            Destroy(gameObject);
        }
        else if (collision.transform.tag == "walls")
        {
            Debug.Log("I hit the wall!");
            Destroy(gameObject);
        }   
    }
}
