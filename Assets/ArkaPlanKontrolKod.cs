using UnityEngine;

public class ArkaPlanKontrolKod : MonoBehaviour
{
    public Transform Arkaplan;
    public float ArkaplanHiz = 0.1f;

    public Transform Yildizlar;
    public float YildizHizi = 0.2f;
    public AudioSource muzik;
    public Transform Gezegen;
    public Transform Gezegen2;
    public float GezegenHizi = 0.02f;
    public Transform Sinir;
    public Transform SinirGezegen;
    public Transform Spawn;
    public Transform SpawnGezegen;
    void Start()
    {
        muzik.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Arkaplan.position += Vector3.left * ArkaplanHiz * Time.deltaTime;
        Yildizlar.position += Vector3.left * YildizHizi * Time.deltaTime;
        Gezegen.position += Vector3.left * GezegenHizi * Time.deltaTime;
        Gezegen2.position += Vector3.left * GezegenHizi * Time.deltaTime;

        if (Arkaplan.position.x <= Sinir.transform.position.x)
        {
            Arkaplan.position = Spawn.position;
        }
        if (Yildizlar.position.x <= Sinir.transform.position.x)
        {
            Yildizlar.position = Spawn.position;
        }
        if (Gezegen.position.x <= SinirGezegen.transform.position.x)
        {
            Gezegen.position = SpawnGezegen.position;
        }
        if (Gezegen2.position.x <= SinirGezegen.transform.position.x)
        {
            Gezegen2.position = SpawnGezegen.position;
        }
    }
}
