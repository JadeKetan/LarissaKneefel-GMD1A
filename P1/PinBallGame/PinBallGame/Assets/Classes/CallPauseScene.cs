using UnityEngine;
using System.Collections;

public class CallPauseScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            Time.timeScale = 0;
            Application.LoadLevelAdditive(1);

        }
	
	}


}
