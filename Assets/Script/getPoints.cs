using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getPoints : MonoBehaviour
{
    public float score = 0;
    public float speed;
    // private bool bTrigger = false;
    public Text showScore;
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(Time.time + ":OnTriggerEnter£º" + other.gameObject.name);
        if (other.tag == "food")
        {
            Destroy(other.gameObject);
            score++;
            Debug.Log(score);
            showScore.text = "score:" + score;

        }
    
    }
    void OnTriggerStay(Collider other)    
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        
    }
}
