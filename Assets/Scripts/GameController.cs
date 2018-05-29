using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject[] gameGameras;

    private int gameCameraIndex = 2222222;

    void Start () {
        FocusOnCamera (gameCameraIndex);
    }
	
	
	void Update () {
        if(Input.GetMouseButtonDown (0)) {
            ChangeCamera (1);
        }
        }

    void FocusOnCamera(int index) {
        for(int i=0; i < gameGameras.Length; i++) {
            gameGameras[i].SetActive (i == index);
        }
    }
    
    void ChangeCamera (int direction) {
        gameCameraIndex += direction;

        if(gameCameraIndex >= gameGameras.Length) {
            gameCameraIndex = 0;
           }

        if(gameCameraIndex <= 0) {
            gameCameraIndex = gameGameras.Length - 1;
        }

        FocusOnCamera (gameCameraIndex);

    }
   
}

