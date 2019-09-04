using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{

    //public Vector3 targetPos;
    //public float rowing;
    //public float moveDist = -15f;
    //public float turnSpeed = 0.1f;
    // closer to 1: more intense row
    // closer to 0: less intense row
    //public float t = 0.1f;
    //public float steerboard;
    //public GameObject boatObj;

    //private Rigidbody boatRB;

    public float steerboard;
    public float rowing;
    public float moveDist = 10f;
    public float turnSpeed = 15f;

    // Use this for initialization
    void Start()
    {
        //targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                //moving the target position 10 units forward
                targetPos = new Vector3(transform.position.x + moveDist, transform.position.y, transform.position.z);
            }
            else
            {
                targetPos = new Vector3(transform.position.x - moveDist, transform.position.y, transform.position.z);

            }
        }*/

        //transform.position = Vector3.Lerp(transform.position, targetPos, t);

        rowing = Input.GetAxis("Vertical");
        steerboard = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * Time.deltaTime * moveDist * rowing);
        transform.Rotate(Vector3.forward, Time.deltaTime * turnSpeed * steerboard);
    }
}