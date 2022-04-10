using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEditor;

public class UserAccountsManager : MonoBehaviour
{


    public static UserAccountsManager Instance;

    void Awake()
    {

        Instance = this;
    }


    public void CreateAccount(string username, string emailAddress, string password)
    {

        PlayFabClientAPI.RegisterPlayFabUser(
            new RegisterPlayFabUserRequest()
            {
                Email = emailAddress,
                Password = password,
                Username = username,
                RequireBothUsernameAndEmail = true
            },

            reponse =>
            {
                 //playerprefs
                //PlayerPrefs.SetString("email",emailAddress);
                //PlayerPrefs.SetString("username",username);
               // PlayerPrefs.SetString("password",password);


                Debug.Log($"Successful Account Creation: {username}, {emailAddress}");
                Debug.Log($"player prefs: {PlayerPrefs.GetString("username")}");
                
                
               


            },

             error =>
             {
                 EditorUtility.DisplayDialog("Error", "Unsuccessful Account Creation:+ " + username + emailAddress +"\n"+ error.ErrorMessage, "Ok");
                 Debug.Log($"Unsuccessful Account Creation: {username}, {emailAddress}\n {error.ErrorMessage}");

             }
        );

    }
}
