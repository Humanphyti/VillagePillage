using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchMode : MonoBehaviour
{

    public GameObject boat;

    public GameObject boatCamera;

    public GameObject player;

    public GameObject playerStartPos;

    public bool fpmode = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //toggle boat mode
        if (Input.GetKeyDown(KeyCode.V))
        {
            boat.GetComponent<BoatController>().enabled = true;
            player.GetComponent<MeshRenderer>().enabled = true;
            player.GetComponent<CharacterController>().enabled = false;
            fpmode = false;
            boatCamera.SetActive(true);
            player.SetActive(false);
        }
        //Toggle FP mode
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            boat.GetComponent<BoatController>().enabled = false;
            player.GetComponent<MeshRenderer>().enabled = false;
            fpmode = true;
            boatCamera.SetActive(false);
            player.SetActive(true);
            player.transform.position = playerStartPos.transform.position;
        }
        
        
    }
}
