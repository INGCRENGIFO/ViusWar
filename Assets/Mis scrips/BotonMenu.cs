using UnityEngine;
using System.Collections;

public class BotonMenu : MonoBehaviour {

	public GameObject pauseScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Jugar(){
		Application.LoadLevel(1); //se puede cambiar por el numero de la escena de file-builsetting 		
	}

	public void Salir(){
		Application.Quit ();
	}

	public void Pausa()
	{
		Time.timeScale = 0;
		
		if (pauseScreen!=null) {
			pauseScreen.SetActive (true);
		}
		
	}
	
	public void UnPause()
	{
		Time.timeScale = 1;
		
		if (pauseScreen!=null) {
			pauseScreen.SetActive (false);
		}
	}
}
