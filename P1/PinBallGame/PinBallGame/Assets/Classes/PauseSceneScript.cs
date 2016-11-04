using UnityEngine;
using System.Collections;

public class PauseSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Resume()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
    }
}
