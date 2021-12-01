using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{

    [SerializeField]
    Image bar;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHUD();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("HP: "+gameManager.instance.health);
        //Debug.Log("Lives: " + gameManager.instance.lives);
        UpdateHUD();
    }

    private void FixedUpdate()
    {
        if(gameManager.instance.health <= 0)
        {
            gameManager.instance.RestartOrDie();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Respawn")
        {
            gameManager.instance.RestartOrDie();
        } else if (other.transform.GetComponent<NOTSCRIPT_ammo>())
        {
            //gameManager.instance.ammo += 3;

            Destroy(other.gameObject);         
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.transform.GetComponent<NOTSCRIPT_hurt>())
        {
            gameManager.instance.health-=0.05f;
            UpdateHUD();
        }
    }

    void UpdateHUD()
    {
        bar.fillAmount = gameManager.instance.health / 100.0f;
    }
}
