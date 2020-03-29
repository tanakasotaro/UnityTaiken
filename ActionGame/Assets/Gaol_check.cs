using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaol_check : MonoBehaviour
{
    public GameObject panel;
    public GameObject GoalText;
    public GameObject FlashingText;
    public GameObject time;
    Timer t;
    // Start is called before the first frame update
    void Start()
    {
        t=time.GetComponent<Timer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision hit){

        if(hit.gameObject.tag == "Player"){
            panel.SetActive(true);
            GoalText.SetActive(true);
            FlashingText.SetActive(true);
            t.setFlagGoal();
        }
    }
}
