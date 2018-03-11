using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DianaMedia : ParentDiana {

	// Use this for initialization
	void Start () {
        
        contador = GameObject.Find("Main Camera").GetComponent<Mananger>();
        
        
    }
    public override void GolpeBala()
    {
      contador.SumarPuntaje(PuntosDados);
   }

    public override void Morir()
    {
        Instantiate(muertoHoja, transform.position, transform.rotation);
        enemigos.RespawnearEnemy();
        
        
        
    }
    
    // Update is called once per frame
    void Update () {
		
	}
}
