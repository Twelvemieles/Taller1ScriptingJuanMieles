using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour {
    [SerializeField]
    private Transform[] respawn;
    
  
    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform  final;
    private Vector3 inicial;
    private float elapsedTime;
    [SerializeField]
    private float time;
    // Use this for initialization
    void Start () {
        RespawnearEnemy();

    }

  
    // Update is called once per frame
    void Update () {
        elapsedTime += Time.deltaTime;
        transform.position = Vector3.Slerp(inicial, final.position, elapsedTime / time);
        //new Vector3 (0f,Vector3.Slerp(inicial, final.position, elapsedTime / time).y,0f);
        if (transform.position == final.position)
        {
            RespawnearEnemy();
        }
        //   float step = speed * Time.deltaTime;
        //   transform.position = Vector3.MoveTowards(transform.position, puntoSeguidor.position, step);
    }

    public void RespawnearEnemy ()
    {
        elapsedTime = 0;
        int numero = Random.Range(0,respawn.Length);
        Transform punto = respawn[numero];
        inicial = (punto.position);
        transform.position = punto.position;
    }
}
