using UnityEngine;

public class BarcodeReaderController : MonoBehaviour
{
    public float daireYarýÇapý = 2.0f; // Dairenin yarýçapý
    public float dönmeHýzý = 30.0f; // Dönme hýzý (derece/saniye)
   
    public Vector3 baþlangýçPozisyonu;
    private float açý = 0.0f;

    public Collider2D collider;
    

    void Start()
    {
        baþlangýçPozisyonu = transform.position;    
    }
    
    void Update()
    {
        if (ColliderControl.CollisionDetected == false)
        {
            // Daire etrafýnda dönme açýsýný hesapla
            açý += dönmeHýzý * Time.deltaTime; //Mevcut açýlarý alýyoruz

            // Yeni pozisyonu hesapla
            //Burada her bir açý deðeri için x,y deðerlerinin cos ve sin deðerleri ile x,y olarak her açý deðeri için dairedeki pozisyonlarý buluyoruz
            float x = Mathf.Cos(açý * Mathf.Deg2Rad) * daireYarýÇapý;
            float y = Mathf.Sin(açý * Mathf.Deg2Rad) * daireYarýÇapý;
            Vector3 yeniPozisyon = baþlangýçPozisyonu + new Vector3(x, y, 10);

            // GameObject'in pozisyonunu güncelle
            transform.position = yeniPozisyon;

            // GameObject'i kendi rotasyonunda sabit tut
            transform.rotation = Quaternion.identity;
        }
       
    }
}
