using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour {
    public GameObject soundShoot;

    public float distanceCam;
    [SerializeField]
    private GameObject semilla;
    [SerializeField]
    private GameObject pico;
    public float forceShoot;
    [SerializeField]
    private int constante = 35;
    private bool sumar = true; 
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        soundShoot = GameObject.FindGameObjectWithTag("disparoS");

        Vector3 mousePosition = Input.mousePosition;
       mousePosition.z = distanceCam;
        var yMove = Camera.main.ScreenToWorldPoint(mousePosition).y;


        if (yMove <= 4.84 && yMove >= 0.76)
        {               
                transform.position = new Vector3(-2.779999f, -yMove + 5f, 0);
        }
        

        //animación de la fuerza
        if (forceShoot >= 120)
        {
            sumar = false;
        }
        if (forceShoot <= 50)
            {
            sumar = true;
        }
        if (sumar == false)
        {
            forceShoot -= constante * Time.deltaTime;
        }
        if (sumar == true)
        {
            forceShoot += constante * Time.deltaTime;
        }


        
        //shoot
        if (Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
	}

    public void Shooting ()
    {
        soundShoot.GetComponent<AudioSource>().Play();
        var bullet = Instantiate(semilla, pico.transform.position, pico.transform.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(-bullet.transform.right * forceShoot, ForceMode2D.Force);
    }
}
