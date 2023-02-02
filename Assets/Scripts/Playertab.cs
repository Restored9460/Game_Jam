using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playertab : MonoBehaviour
{
   
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            SceneManager.LoadScene("Menu when pressed", LoadSceneMode.Single);

    }
}
