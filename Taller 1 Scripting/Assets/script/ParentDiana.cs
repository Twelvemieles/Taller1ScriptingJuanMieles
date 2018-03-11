using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ParentDiana : MonoBehaviour,IEnemy {
    
    [SerializeField]
    private int puntosDados;
    [SerializeField]
    protected Transform  muertoCabeza;
    [SerializeField]
    protected Transform muertoHoja;

    protected Mananger contador;
    [SerializeField]
    protected Enemigos enemigos;

    public int PuntosDados       
    {
        get
        {
            return puntosDados;
        }

        set
        {
            puntosDados = value;
        }
    }

    
// Use this for initialization
void Start () {
       
    }
    //public abstract void GolpeRuma();
    public abstract void GolpeBala();
    public abstract void Morir();

    // Update is called once per frame
    void Update () {
		
	}
}
