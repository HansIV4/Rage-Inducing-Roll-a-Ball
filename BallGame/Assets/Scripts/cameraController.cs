using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
     
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
        if (player.transform.position.y < -10)
        {
            player.transform.position =new Vector3(0,5,0);
            //transform.position = startPosition;
            
        }
	}
}
