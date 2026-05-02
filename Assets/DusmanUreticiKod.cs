using UnityEngine;

public class DusmanUretici : MonoBehaviour
{

    public GameObject GezegenSablon;
    public GameObject UfoSablon;
    public GameObject Ufo2Sablon;
    [SerializeField] float uretimHiziGezegen = 10f;
    [SerializeField] float uretimHiziUfo = 2f;
    [SerializeField] float uretimHiziUfo2 = 7f;
    public PuanKod Puan;
    private bool ufo2Basladi = false;

    void Start()
    {
        Puan = GameObject.Find("PuanYoneticisi").GetComponent<PuanKod>();
        InvokeRepeating("DusmanOlusturGezegen", 1f, uretimHiziGezegen);
        InvokeRepeating("DusmanOlusturUfo", 1f, uretimHiziUfo);

    }
    void Update()
    {
        if (Puan.SuAnkiPuan() >= 10 && !ufo2Basladi)
        {
            InvokeRepeating("DusmanOlusturUfo2", 1f, uretimHiziUfo2);
            ufo2Basladi = true;
        }
    }

    void DusmanOlusturGezegen()
    {

        float rastgeleY = Random.Range(-0.8f, 0.75f);
        float rastgeleX = Random.Range(2F, 3f);
        Vector3 olusmaYeri = new Vector3(rastgeleX, rastgeleY, 0f);

        var yeniGezegen = GameObject.Instantiate(GezegenSablon);
        yeniGezegen.transform.position = olusmaYeri;


    }
    void DusmanOlusturUfo()
    {
        float rastgeleY = Random.Range(-0.85f, 0.75f);

        float rastgeleX = Random.Range(4f, 6f);
        Vector3 olusmaYeri = new Vector3(rastgeleX, rastgeleY, 0f);

        var yeniUfo = GameObject.Instantiate(UfoSablon);
        yeniUfo.transform.position = olusmaYeri;
    }
    void DusmanOlusturUfo2()
    {
        float rastgeleY = Random.Range(-0.85f, 0.75f);
        float rastgeleX = 2f;
        Vector3 olusmaYeri = new Vector3(rastgeleX, rastgeleY, 0f);

        var yeniUfo = GameObject.Instantiate(Ufo2Sablon);
        yeniUfo.transform.position = olusmaYeri;
    }
}