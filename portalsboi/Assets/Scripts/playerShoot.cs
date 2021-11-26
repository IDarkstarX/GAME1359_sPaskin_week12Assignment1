using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{

    [SerializeField]
    GameObject leftPortal;

    [SerializeField]
    GameObject rightPortal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            Debug.Log("Left portal shot!");

            if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100))
            {
                if(hit.transform != null && hit.transform.tag == "walls")
                {
                    //Debug.Log("hit normal: " + hit.point);
                    leftPortal.transform.position = hit.point;
                    leftPortal.transform.rotation = Quaternion.FromToRotation(Vector3.back, hit.normal);
                    //Debug.Log("Left portal location: " + rightPortal.transform.position);
                }
            }
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            RaycastHit hit;

            Debug.Log("Right portal shot!");

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 100))
            {
                if (hit.transform != null && hit.transform.tag == "walls")
                {
                    //Debug.Log("hit normal: " + hit.point);
                    rightPortal.transform.position = hit.point;
                    rightPortal.transform.rotation = Quaternion.FromToRotation(Vector3.back, hit.normal);
                    //Debug.Log("Right portal location: " + rightPortal.transform.position);
                }
            }
        }
    }
}
