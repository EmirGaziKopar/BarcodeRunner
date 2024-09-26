using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveSystem : MonoBehaviour
{
    public Button button;
    public Button button1;
    public Button button2;
    public Button button3;


    int numberOfLevel;
    Color colorGray;
    
    

    public int LoadNumber()
    {
        // E�er "SavedNumber" anahtar�na ait bir de�er yoksa, varsay�lan olarak 0 d�nd�r�r
        return PlayerPrefs.GetInt("LevelCompleted", 0);

    }
    

    //mevcutta bir tane level de�i�keni olacak ve bu level e�i�kenine kaydedilen de�erin bir �st leveline girilebilecek
    // Start is called before the first frame update
    void Start()
    {

        //PlayerPrefs.DeleteAll();
        numberOfLevel = LoadNumber();
        Debug.Log("Kacinci : " + numberOfLevel);
        if (LoadNumber() == 0)
        {
            Debug.Log("Buraya girdi");
            button.interactable = true;
            button1.interactable = true;
            button2.interactable = false;
            button3.interactable = false;
        }
        if(LoadNumber() == 1)
        {
            button.interactable = true;
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = false;
        }
        if(LoadNumber() == 2)
        {
            button.interactable = true;
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
