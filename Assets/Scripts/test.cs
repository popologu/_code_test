using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public int a = 1;
    public int b = 2;
    public int c = 3;

    private bool test11 = false;

    // Use this for initialization
    void Start () {
        if (a == 2) {
            Debug.Log (a);
        }else if (b == 1) {
            Debug.Log ("엘스이프");
        }if (c == 1) {
            Debug.Log (c);
        }else if (a == 1) {
            Debug.Log ("에이");
        }




        //if (test11) {
        //    Debug.Log ("참");
        //} else {
        //    Debug.Log ("거짓");
        //}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
