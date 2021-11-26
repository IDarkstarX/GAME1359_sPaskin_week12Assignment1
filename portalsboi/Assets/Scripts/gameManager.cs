using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;

    public float lives;
    public float health;

    [SerializeField]
    float ammoRespawn = 5;

    float timer = 0;

    [SerializeField]
    GameObject pickup;

    [SerializeField]
    Vector3[] pickups;

    void Start()
    {
        
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            RestartOrDie();
        }

        timer = timer + Time.deltaTime;

        //Debug.Log(timer);

        if(timer >= ammoRespawn)
        {
            Debug.Log("Respawn time!");
            timer = 0;
            for(int i = 0; i < pickups.Length; i++)
            {
                Instantiate(pickup, pickups[i], Quaternion.identity);
            }
        }
        /*
        if(score >= 3 && SceneManager.GetActiveScene().buildIndex != 2)
        {
            goToScene(2);
        }
        */
    }

    public void goToScene(int scene)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(scene);
    }

    public void RestartOrDie()
    {
        if (lives > 0)
        {
            /*
            ammo = 3;
            score = 0;
            */
            health = 100;
            lives -= 1;
            goToScene(1);
        } else if(SceneManager.GetActiveScene().buildIndex != 3)
        {
            goToScene(3);
        }
    }
}