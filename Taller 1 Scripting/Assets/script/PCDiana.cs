using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCDiana : MonoBehaviour {
    [SerializeField]
    private int balas;
    public bool CanShoot;
	// Use this for initialization
	void Start () {
        CanShoot = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(balas > 0)
        {
            CanShoot = true;
        }
	}
}
