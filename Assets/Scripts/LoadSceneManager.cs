﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour {

    // Use this for initialization
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToTermsOfUse()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToLoadingScreen()
    {
        SceneManager.LoadScene(3);
    }

    public static void GoToNewbie()
    {
        SceneManager.LoadScene(4);
    }

    public void FeatureOnMEA() 
    {
    Application.OpenURL("https://www.heraldic.cloud/MEA/get-featured-on-mea/");
    }

    public void FacebookPage()
    {
        Application.OpenURL("https://www.facebook.com/HeraldicClouds/");
    }

    public void TwitterPage()
    {
        Application.OpenURL("https://twitter.com/HeraldicClouds/");
    }


    public void startEleet()
    {
        InAppBrowser.OpenURL("https://www.heraldic.cloud/MEA/eleet/");
    }

}
