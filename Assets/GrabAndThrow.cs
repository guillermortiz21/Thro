using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAndThrow : MonoBehaviour{
    public GameObject player;
    public Transform playerCam;
    private Transform parent;
    private float rationX;
    private float rationY;
    private float rationZ;
    bool inHands = false;
    Vector3 foodPos;
    Vector3 foodRotation;
    public float throwForce = 200;

    // Start is called before the first frame update
    void Start(){
        foodPos = this.transform.position;
        parent = this.transform.parent;
        rationX = this.transform.eulerAngles.x;
        foodRotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetButtonDown("Fire1")){
            if(!inHands){
                this.transform.SetParent(player.transform);
                this.transform.localPosition = new Vector3(0f,-0.12f, 0.4f);
                inHands = true;
            }else{
                //throw ball!!!
                this.GetComponent<GrabAndThrow>().enabled = false;
                this.transform.SetParent(null);
                inHands = false;
                this.GetComponent<Rigidbody>().isKinematic = false;
                this.GetComponent<Rigidbody>().AddForce(playerCam.transform.forward * throwForce);
            }
        }
    }
}
