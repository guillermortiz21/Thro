using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour {

    public GameObject ball;
    public GameObject myHand;

    bool inHand = false;
    Vector3 ballPos;

    // Start is called before the first frame update
    void Start() {
        ballPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire1")){
            if(!inHand){
                ball.transform.SetParent(myHand.transform);
                ball.transform.localPosition = new Vector3(-0.014f,-0.34f,0.259f);
                inHand = true;
            }else{
                this.GetComponent<PlayerGrab>().enabled = false;
                ball.transform.SetParent(null);
                ball.transform.localPosition = ballPos;
                inHand = false;
            }
        }
    }
}