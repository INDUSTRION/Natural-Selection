using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class UICreateAccount : MonoBehaviour
{
    string username, password, emailAddress;
    bool check = true;

    public void updateUsername (string _username){

        username= _username;
    }

    public void updatePassword (string _password){

        password= _password;

    }

    public void updateEmailAddress (string _emailAddress){

        emailAddress= _emailAddress;
    }

    public void playmode()
    {

         SceneManager.LoadScene(2);
    }

    public void CreateAccount(){

    UserAccountsManager.Instance.CreateAccount (username , emailAddress , password);
    }

    void Update(){
        
            //playmode();
    }
}



