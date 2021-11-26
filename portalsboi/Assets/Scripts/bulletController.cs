using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    [SerializeField]
    float bulletLifetime;

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
        if(collision.transform.tag == "Target")
        {
            //gameManager.instance.score += 1;

            Destroy(collision.gameObject.transform.parent.gameObject);
            
            Destroy(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
}
