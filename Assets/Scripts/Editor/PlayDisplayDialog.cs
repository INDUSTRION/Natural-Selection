using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using System.Linq;

public class PlayDisplayDialog : MonoBehaviour
{
    [MenuItem ("Custom Menu/Play")]

    public static void Play(){
       bool playOutput= EditorUtility.DisplayDialog("Evolve", "The force that initiates evolution is ______ A. Variation B. Mutation", "A", "B");
       if (playOutput)
            //EditorApplication.EnterPlaymode();
            EditorUtility.DisplayDialog("Sucess", "You have evolved to the next level", "Ok");

       else
            EditorUtility.DisplayDialog("Fail", "You have failed to evolve to the next level", "Ok");

    }

    public Transform contentWindow;
    public GameObject recallTextObject;


    void Start (){

         //get the file fromk dir
         string readFromFilePath = "/Resources/"+ "quizzes";

         List<string> fileLines= File.ReadAllLines(readFromFilePath).ToList();

         foreach(string line in fileLines){

              Instantiate(recallTextObject, contentWindow);
              recallTextObject.GetComponent<Text>().text= line;
         }

    }
}
