using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Play()
    {
        Debug.Log("Press Start Button");
        SceneManager.LoadScene("Scenes_Game");
    }

    
    public void OnClick_Exit()
    {
        Debug.Log("Press Exit Button. it only works at Phone!");
        //Only works at phone
        Application.Quit();
        

    }
}
