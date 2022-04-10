using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class UICreateAccount : MonoBehaviour
{
    string username, password, emailAddress;

    public void updateUsername (string _username){

        username= _username;
    }

    public void updatePassword (string _password){

        password= _password;

    }

    public void updateEmailAddress (string _emailAddress){

        emailAddress= _emailAddress;
    }

    public void playmode(){

         SceneManager.LoadScene(1);
    }

    public void CreateAccount(){

    UserAccountsManager.Instance.CreateAccount (username , emailAddress , password);
    }

    void Update(){
        if (Input.GetKey(KeyCode.UpArrow)){

            playmode();
        }

    }
}



