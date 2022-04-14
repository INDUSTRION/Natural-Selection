using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroVideoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(starts());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public IEnumerator starts()
  
  { 
       yield return new WaitForSeconds(6f);

       SceneManager.LoadScene(1);

      

  }

   


}
