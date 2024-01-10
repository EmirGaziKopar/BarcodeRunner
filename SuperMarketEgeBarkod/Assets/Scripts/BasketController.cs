using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketController : MonoBehaviour
{
    public static bool lvlComplated;
    public float Timer;
    public float requiredTimer;
    public int currentLevel;


    public void CompleteLevel(int levelNumber)
    {
        PlayerPrefs.SetInt("LevelCompleted", levelNumber);
        PlayerPrefs.Save(); // De�i�iklikleri kaydet
    }

    private void OnTriggerStay2D(Collider2D collision)
    {      
        //Layer ayarlamalar� yap�lm�� m� bak ? 

        if(collision.gameObject.tag == "Patato" && ColliderControl.CollisionDetected) //E�er sa�l�kl� �al��mazsa enter ile giri� ve ��k�� yapt��� aral�ktaki de�eri bul
        {
            isGroundedControl.collidedOnBasket = false; //E�er trigger k�sm�na kadar geldiyse basket de�eri false kalmal�
            Timer += Time.deltaTime;
            Debug.Log("Timer : "+Timer);
            if (Timer > requiredTimer)
            {
                lvlComplated = true;
                Debug.Log("Level Ba�ar�l�");
                CompleteLevel(currentLevel);
                SceneManager.LoadScene(currentLevel+1, LoadSceneMode.Single);
                
            }
        }
        /*
        else
        {
            Timer += Time.deltaTime;
            if (Timer > requiredTimer)
            {
                lvlComplated = true;
                Debug.Log("Level Ba�ar�s�z");
                SceneManager.LoadScene(currentLevel, LoadSceneMode.Single);
            }
        }
        */
    }
    // Start is called before the first frame update
    void Start()
    {
        lvlComplated = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
