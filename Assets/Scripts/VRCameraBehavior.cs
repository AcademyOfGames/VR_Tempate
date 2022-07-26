using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCameraBehavior : MonoBehaviour
{
    bool movementFrozen = false;
    Vector3 freezePos;
    public GameObject cam;
    Vector3 lastPos;
    //public GameObject roomCenter;
    private void OnCollisionStay(Collision collision)
    {

    }

    private void OnCollisionExit(Collision collision)
    {
    }

    private void OnTriggerExit(Collider other)
    {
        movementFrozen = false;
        print(movementFrozen);

    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("walls"))
        {
            //transform.position = lastPos;
           // cam.transform.position = transform.position;

            //cam.transform.position = Vector3.forward+ cam.transform.position;
            //movementFrozen = true;

        }
    }

    // Start is called before the first frame update

    void Start()
    {

    }


    private void LateUpdate()
    {
        if (movementFrozen)
        {
        }
        else
        {
            //transform.position = cam.transform.position;

        }

        //cam.transform.position = Vector3.forward + cam.transform.position;
        //cam.transform.position = freezePos;
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
