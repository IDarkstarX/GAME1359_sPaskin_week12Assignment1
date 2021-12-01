using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIUsePortals : MonoBehaviour
{
    [SerializeField]
    GameObject AIBody;

    [SerializeField]
    GameObject LPortal;

    [SerializeField]
    GameObject RPortal;

    // AIBody.GetComponent<EnemyController>().currentTargetLocation

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(AIBody.transform.position, FindObjectOfType<playerMovement>().transform.position) > Vector3.Distance(AIBody.transform.position, LPortal.transform.position) + Vector3.Distance(RPortal.transform.position, FindObjectOfType<playerMovement>().transform.position))
        {
            AIBody.GetComponent<EnemyController>().currentTargetLocation = LPortal.transform.position;
            Debug.Log("Its closer to the LEFT portal!");

        } else if (Vector3.Distance(AIBody.transform.position, FindObjectOfType<playerMovement>().transform.position) > Vector3.Distance(AIBody.transform.position, RPortal.transform.position) + Vector3.Distance(LPortal.transform.position, FindObjectOfType<playerMovement>().transform.position))
        {
            AIBody.GetComponent<EnemyController>().currentTargetLocation = RPortal.transform.position;
            Debug.Log("Its closer to the RIGHT portal!");
        } else
        {
            AIBody.GetComponent<EnemyController>().currentTargetLocation = FindObjectOfType<playerMovement>().transform.position;
            Debug.Log("Its closer to the Player's location!");
        }
    }
}
