using UnityEngine;

public class DusmanUretici : MonoBehaviour
{
    public GameObject Gezegen;
    [SerializeField] float uretimHizi = 10f;

    void Start()
    {

        InvokeRepeating("DusmanOlustur", 1f, uretimHizi);
    }

    void DusmanOlustur()
    {

        float rastgeleY = Random.Range(-0.7f, 0.8f);
        float rastgeleX = Random.Range(2F, 3f);
        Vector3 olusmaYeri = new Vector3(rastgeleX, rastgeleY, 0f);


        Instantiate(Gezegen, olusmaYeri, Quaternion.identity);


    }
}