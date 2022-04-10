using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
//using TMPro;

public class quiz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       ReadString();
      
    }

    public void ReadString(){


        string path= "Assests/Resources/quizzes";
        StreamReader reader = new StreamReader(path);

        bool endOfFile= false;
        while(!endOfFile){

            string datastring= reader.ReadLine();
            if (datastring == null){
                endOfFile =true;
                break;

            }

            

            Debug.Log(datastring);

        
        }
    
        //Debug.Log("erroooooor");
        reader.Close();
    }

}

 
