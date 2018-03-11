using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour {
    public float distanceCam;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distanceCam;
        var yMove = Camera.main.ScreenToWorldPoint(mousePosition).y;


        if (yMove <= 4.84 && yMove >= 0.76)
        {
            transform.position = new Vector3(transform.position.x, yMove +2f , transform.position.z);
        }
    }
}
