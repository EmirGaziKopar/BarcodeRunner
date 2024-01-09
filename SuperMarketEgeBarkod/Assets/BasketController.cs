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
    

    private void OnTriggerStay2D(Collider2D collision)
    {      
        //Layer ayarlamalar� yap�lm�� m� bak ? 
        if(collision.gameObject.tag == "Patato" && ColliderControl.CollisionDetected) //E�er sa�l�kl� �al��mazsa enter ile giri� ve ��k�� yapt��� aral�ktaki de�eri bul
        {
            Timer += Time.deltaTime;
            Debug.Log("Timer : "+Timer);
            if (Timer > requiredTimer)
            {
                lvlComplated = true;
                Debug.Log("Level Ba�ar�l�");
                SceneManager.LoadScene(currentLevel + 1, LoadSceneMode.Single);
            }
        }
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
