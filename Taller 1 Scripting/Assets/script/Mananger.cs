using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mananger : MonoBehaviour {
    public Text ScoreText;
    private int score;
    public GameObject ripSound;
    [SerializeField]
    private GameObject gameOverText;
    [SerializeField]
    private GameObject PerderText;
   [SerializeField]
    private GameObject[] enemigos;
    private bool noPerder = false;


    // Use this for initialization
    void Start () {
        gameOverText.SetActive(false);
        PerderText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        ripSound = GameObject.FindGameObjectWithTag("ripCastorS");
        if (score >= 400)
        {
            enemigos = GameObject.FindGameObjectsWithTag("enemigos");
            foreach (GameObject ene in enemigos)
            {
                Destroy(ene);
            }
            
            GameOver();
        }
	}

    public void SumarPuntaje(int value)
    {
        
        score += value;
        UpdateScore();
        
        ripSound.GetComponent<AudioSource>().Play();
    }

    void UpdateScore()
    {
        ScoreText.text = "" + score;
    }

    public void GameOver() //esto hace aparecer el menú de ganar
    {
        gameOverText.SetActive(true);
        noPerder = true;
        
    }
    public void Perder()
    {
        if (noPerder == false)
        {
            PerderText.SetActive(true);
        } 
    }
}

