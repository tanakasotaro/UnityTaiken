using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.AudioSource;

public class Flashing2 : MonoBehaviour
{
    public Text text;
    //public AudioSource click;
    private int flamenum = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //click.stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (text.enabled)
        {
            if(flamenum==10){
                text.enabled = false;
            }
        }
 
        // 表示
        else
        {
            if(flamenum==20){
                text.enabled = true;
                flamenum=0;
            }
        }
        flamenum++;
    }
}
