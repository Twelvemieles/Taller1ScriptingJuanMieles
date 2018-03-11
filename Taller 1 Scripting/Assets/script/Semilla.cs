using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Semilla : MonoBehaviour {
    private ParentDiana objetivo;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        IEnemy diana = collision.gameObject.transform.GetComponent<IEnemy>();
        if (diana != null)
        {

            diana.GolpeBala();
            diana.Morir();
            // Destroy(gameObject);
            if (collision.gameObject.tag == "borde")
            {
                Destroy(gameObject);
                Debug.Log("VEEEERGAAA");
            }
        }
        

        


    }
    // if (collision.gameObject.transform.parent == objetivo)

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
