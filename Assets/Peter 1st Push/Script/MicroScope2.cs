using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MicroScope2 : MonoBehaviour
{
     public GameObject StartPanel;

    public bool Prezz = false;


    void Start()
    {
        Time.timeScale = 1;
    }


    void Update()
    { 
        if(Prezz == true)
        {
            Press();
        }

    }


    void OnTriggerEnter(Collider colides)
    {


        if (colides.gameObject.tag == "Player")
        {
            StartPanel.SetActive(true);
            Prezz = true;
           
           
        }



    }

    void OnTriggerExit(Collider colides)
    {


        if (colides.gameObject.tag == "Player")
        {
            StartPanel.SetActive(false);

            Prezz = false;
        }



    }



    void Press()
    {
        if (Input.GetKey(KeyCode.E))

        {


            SceneManager.LoadScene(3);


            // Scene.SceneManger.......

        }
    }
}
