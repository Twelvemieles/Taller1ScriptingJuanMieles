using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Botones : MonoBehaviour {

    public string actualScene;
    public string DianaScene;
    public string BeatEmScene;
    public string HomeScene;
    public string InfoScene;



    public void BotonRepetir ()
    {
        SceneManager.LoadScene(actualScene);

    }


    public void BotonDiana()
    {
        SceneManager.LoadScene(DianaScene);
    }
    public void BotonInfo()
    {
        SceneManager.LoadScene(InfoScene);
    }


    public void BotonBeatEm()
    {
        SceneManager.LoadScene(BeatEmScene);
    }

    public void BotonHome()
    {
        SceneManager.LoadScene(HomeScene);
    }




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
