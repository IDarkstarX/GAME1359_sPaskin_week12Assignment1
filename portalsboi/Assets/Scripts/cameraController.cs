using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField]
    float rotSpeed = 150;

    [SerializeField]
    Transform lookvertical;

    [SerializeField]
    float angleLimit = 90f;

    float headRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        //Debug.Log(lookvertical.localRotation.x);

        headRotation += y;
        headRotation = Mathf.Clamp(headRotation, -angleLimit, angleLimit);

        transform.Rotate(new Vector3(0, x*rotSpeed*Time.deltaTime, 0));

        lookvertical.localEulerAngles = new Vector3(-headRotation, 0f, 0f);

    }
}
