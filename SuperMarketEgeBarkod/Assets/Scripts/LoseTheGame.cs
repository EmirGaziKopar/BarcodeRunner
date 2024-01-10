using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseTheGame : MonoBehaviour
{
    //Oyunu kaybedince kamera titreþimi ve effect koy kesinlikle 

    public int currentScene;
    public Image fill;
    public Image frame;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Bottle")
        {
            Debug.Log("Girdi");
            SceneManager.LoadScene(currentScene, LoadSceneMode.Single);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (isGroundedControl.collidedOnBasket && fill.fillAmount < 1f) 
        {
            fill.gameObject.SetActive(true);
            frame.gameObject.SetActive(true);
            fill.fillAmount += 0.01f;
        }
        else //collidedOnBasket == false ise yani potayla temas halinde deðilse bar azalmaya baþlasýn
        {
            if(fill.fillAmount > 0)
            {
                fill.fillAmount -= 0.01f;
            }
            else
            {
                fill.gameObject.SetActive(false);
                frame.gameObject.SetActive(false);
            }
            
        }

        if (fill.fillAmount >= 1f)
        {
            SceneManager.LoadScene(currentScene, LoadSceneMode.Single);
        }
        
    }
}
