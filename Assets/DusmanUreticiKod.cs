using UnityEngine;

public class DusmanUretici : MonoBehaviour
{

    public GameObject GezegenSablon;
    public GameObject UfoSablon;
    [SerializeField] float uretimHiziGezegen = 10f;
    [SerializeField] float uretimHiziUfo = 2f;

    void Start()
    {
        InvokeRepeating("DusmanOlusturGezegen", 1f, uretimHiziGezegen);
        InvokeRepeating("DusmanOlusturUfo", 1f, uretimHiziUfo);
    }

    void DusmanOlusturGezegen()
    {

        float rastgeleY = Random.Range(-0.7f, 0.75f);
        float rastgeleX = Random.Range(2F, 3f);
        Vector3 olusmaYeri = new Vector3(rastgeleX, rastgeleY, 0f);

        var yeniGezegen = GameObject.Instantiate(GezegenSablon);
        yeniGezegen.transform.position = olusmaYeri;


    }
    void DusmanOlusturUfo()
    {
        float rastgeleY = Random.Range(-0.7f, 0.75f);
        float rastgeleX = Random.Range(4f, 6f);
        Vector3 olusmaYeri = new Vector3(rastgeleX, rastgeleY, 0f);

        var yeniUfo = GameObject.Instantiate(UfoSablon);
        yeniUfo.transform.position = olusmaYeri;
    }
}