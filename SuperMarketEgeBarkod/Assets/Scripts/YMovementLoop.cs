using System.Collections.Generic;
using UnityEngine;

public class YMovementLoop : MonoBehaviour
{
    public float hareketMesafesi = 2.0f; // Y ekseninde hareket edilecek mesafe
    public float hareketHizi = 1.0f; // Hareket hýzý

    private List<ConfigurableJoint> jointList = new List<ConfigurableJoint>();

    void Start()
    {
        FindJoints();
        StartCoroutine(HareketDongusu());
    }

    void FindJoints()
    {
        // Eðer joint'larý elle atamadýysanýz, bu kod parçasý kullanýlabilir.
        jointList.AddRange(GetComponentsInChildren<ConfigurableJoint>());

        // Eðer joint'larý elle atadýysanýz, aþaðýdaki gibi kullanabilirsiniz.
        //jointList.Add(joint1);
        //jointList.Add(joint2);
        // Diðer joint'larý da ekleyin...

        // Eðer joint sayýsý deðiþken ise, joint'larý elle eklemek yerine otomatik olarak ekleyebilirsiniz.
        //jointList.AddRange(GetComponentsInChildren<ConfigurableJoint>());
    }

    System.Collections.IEnumerator HareketDongusu()
    {
        while (true)
        {
            yield return YukariHareketEt();
            yield return AsagiHareketEt();
        }
    }

    System.Collections.IEnumerator YukariHareketEt()
    {
        foreach (ConfigurableJoint joint in jointList)
        {
            Vector3 jointPosition = joint.connectedBody.transform.localPosition;

            while (jointPosition.y < hareketMesafesi)
            {
                jointPosition.y += Time.deltaTime * hareketHizi;
                joint.connectedBody.transform.localPosition = jointPosition;
                yield return null;
            }
        }
    }

    System.Collections.IEnumerator AsagiHareketEt()
    {
        foreach (ConfigurableJoint joint in jointList)
        {
            Vector3 jointPosition = joint.connectedBody.transform.localPosition;

            while (jointPosition.y > -hareketMesafesi)
            {
                jointPosition.y -= Time.deltaTime * hareketHizi;
                joint.connectedBody.transform.localPosition = jointPosition;
                yield return null;
            }
        }
    }
}
