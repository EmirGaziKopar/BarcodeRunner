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
        PlayerPrefs.Save(); // Deðiþiklikleri kaydet
    }

    private void OnTriggerStay2D(Collider2D collision)
    {      
        //Layer ayarlamalarý yapýlmýþ mý bak ? 

        if(collision.gameObject.tag == "Patato" && ColliderControl.CollisionDetected) //Eðer saðlýklý çalýþmazsa enter ile giriþ ve çýkýþ yaptýðý aralýktaki deðeri bul
        {
            isGroundedControl.collidedOnBasket = false; //Eðer trigger kýsmýna kadar geldiyse basket deðeri false kalmalý
            Timer += Time.deltaTime;
            Debug.Log("Timer : "+Timer);
            if (Timer > requiredTimer)
            {
                lvlComplated = true;
                Debug.Log("Level Baþarýlý");
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
                Debug.Log("Level Baþarýsýz");
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
