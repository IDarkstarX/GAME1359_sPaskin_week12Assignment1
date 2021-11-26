using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenuButtons : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressedStart()
    {
        gameManager.instance.lives = 2;
        gameManager.instance.goToScene(1);
    }

    public void pressedQuit()
    {
        Application.Quit();
    }
}
