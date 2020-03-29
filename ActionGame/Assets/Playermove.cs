using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playermove : MonoBehaviour
{
    public Rigidbody rb;
    //GaolText text scr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce(0,0,5);
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce(0,0,-5);
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(5,0,0);
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-5,0,0);
        }

        if(transform.position.y < -10){
            transform.position = new Vector3(0,4,0);
            rb.velocity = Vector3.zero; // 3Dの場合
        }
    }

    void OnCollisionStay(Collision hit){
        if(hit.gameObject.tag == "Enemy"){
            transform.position = new Vector3(0,4,0);
            rb.velocity = Vector3.zero; // 3Dの場合
        }
    }
}
