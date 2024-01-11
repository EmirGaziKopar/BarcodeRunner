using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManagerSystem : MonoBehaviour
{

    public void lvl0()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void lvl1()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void lvl2()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
    public void lvl3()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

    public void ReturnLevelPanel()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(5, LoadSceneMode.Single);
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
