using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noDupes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.GetComponent<NOTSCRIPT_ammo>())
        {
            Destroy(other.gameObject);
        }
    }
}
