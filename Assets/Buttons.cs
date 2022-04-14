using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

 
    public GameObject Boundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void correctAns()
    {   

       Destroy(Boundary);


    }


    public void IncorrectAns() 
    {
      SceneManager.LoadScene("NaturalSelection");
    }
}
