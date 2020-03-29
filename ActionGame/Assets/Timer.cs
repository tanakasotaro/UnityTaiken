using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text t;
    float time = 0;
    private int flag =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag==0){
            time += Time.deltaTime;
        }else{
            if(Input.GetMouseButtonDown(0)){
                SceneManager.LoadScene("StartScene");
            }
        }

        t.text = time.ToString("F2");
        
    }

    public void setFlagGoal(){
        Debug.Log("flag");
        flag++;
    }
}
