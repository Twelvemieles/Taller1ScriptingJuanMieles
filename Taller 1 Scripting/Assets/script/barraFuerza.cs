using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barraFuerza : MonoBehaviour {
    private float escala;
    [SerializeField]
    private MovimientoPlayer scriptMov1lvl;
    [SerializeField]
    private MovimientoPlayerBeatEm scriptMov2lvl;
    public float Escala
    {
        get
        {
            return escala;
        }

        set
        {
            escala = value + 0.5f;
        }
    }

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        
        if(scriptMov1lvl != null)
        {
            escala = (120f - scriptMov1lvl.forceShoot) * (0.4f / 70f) + 0.2f;
        }
        else
        {
            escala = (120f - scriptMov2lvl.forceShoot) * (0.4f / 70f) + 0.2f;
        }
            
        
        
        //Debug.Log(scriptMov.forceShoot);
        transform.localScale = new Vector3(escala,escala,escala);
	}
}


