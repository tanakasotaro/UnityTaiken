using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_sound : MonoBehaviour
{
    public AudioSource clicksound;
    // Start is called before the first frame update
    void Start()
    {
        clicksound.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            DontDestroyOnLoad(clicksound);
            clicksound.Play();
        }
        
    }
}
