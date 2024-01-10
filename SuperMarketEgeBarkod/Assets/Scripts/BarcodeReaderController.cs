using UnityEngine;

public class BarcodeReaderController : MonoBehaviour
{
    public float daireYar��ap� = 2.0f; // Dairenin yar��ap�
    public float d�nmeH�z� = 30.0f; // D�nme h�z� (derece/saniye)
   
    public Vector3 ba�lang��Pozisyonu;
    private float a�� = 0.0f;

    public Collider2D collider;
    

    void Start()
    {
        ba�lang��Pozisyonu = transform.position;    
    }
    
    void Update()
    {
        if (ColliderControl.CollisionDetected == false)
        {
            // Daire etraf�nda d�nme a��s�n� hesapla
            a�� += d�nmeH�z� * Time.deltaTime; //Mevcut a��lar� al�yoruz

            // Yeni pozisyonu hesapla
            //Burada her bir a�� de�eri i�in x,y de�erlerinin cos ve sin de�erleri ile x,y olarak her a�� de�eri i�in dairedeki pozisyonlar� buluyoruz
            float x = Mathf.Cos(a�� * Mathf.Deg2Rad) * daireYar��ap�;
            float y = Mathf.Sin(a�� * Mathf.Deg2Rad) * daireYar��ap�;
            Vector3 yeniPozisyon = ba�lang��Pozisyonu + new Vector3(x, y, 10);

            // GameObject'in pozisyonunu g�ncelle
            transform.position = yeniPozisyon;

            // GameObject'i kendi rotasyonunda sabit tut
            transform.rotation = Quaternion.identity;
        }
       
    }
}
