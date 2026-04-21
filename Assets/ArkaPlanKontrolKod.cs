using UnityEngine;

public class ArkaPlanKontrolKod : MonoBehaviour
{
    public Transform Arkaplan;
    public float ArkaplanHiz = 0.1f;

    public Transform Yildizlar;
    public float YildizHizi = 0.2f;

    public Transform Gezegen;
    public float GezegenHizi = 0.02f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Arkaplan.position += Vector3.left * ArkaplanHiz * Time.deltaTime;
        Yildizlar.position += Vector3.left * YildizHizi * Time.deltaTime;
        Gezegen.position += Vector3.left * GezegenHizi * Time.deltaTime;
    }
}
