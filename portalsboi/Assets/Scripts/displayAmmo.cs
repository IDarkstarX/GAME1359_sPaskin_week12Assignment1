using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayAmmo : MonoBehaviour
{
    [SerializeField]
    Text livesText;

    void Start()
    {
        livesText.text = "Lives: " + gameManager.instance.lives;
    }

    void Update()
    {
        livesText.text = "Lives: " + gameManager.instance.lives;
    }
}