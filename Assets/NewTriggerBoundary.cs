using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTriggerBoundary : MonoBehaviour
{



    public GameObject QuestionPanel;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider colides)
    {
        
        if (colides.gameObject.tag == "Player")
        {
            QuestionPanel.SetActive(true);
            
           
           
        }
        
    }

    void OnTriggerExit(Collider colides)
    {
        
        if (colides.gameObject.tag == "Player")
        {
            QuestionPanel.SetActive(false);
            
           
           
        }
        
    }










}
