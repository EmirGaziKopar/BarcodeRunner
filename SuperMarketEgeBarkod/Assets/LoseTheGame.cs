using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseTheGame : MonoBehaviour
{
    //Oyunu kaybedince kamera titreþimi ve effect koy kesinlikle 

    public int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Patato")
        {
            SceneManager.LoadScene(currentScene, LoadSceneMode.Single);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
