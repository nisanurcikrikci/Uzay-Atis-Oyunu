using UnityEngine;
using System.Collections;

public class GezegenKod : MonoBehaviour
{
    public float can = 100f;
    public float hareketHizi = 2f;

    public SpriteRenderer CanSimge;
    public GameObject canGrubu;
    public float canBariGorunmeSuresi = 1.0f;
    float ilkGenislik;
    public SesKod SesYonetici;
    public PuanKod Puan;

    void Start()
    {
        SesYonetici = GameObject.Find("SesYonetici").GetComponent<SesKod>();
        Puan = GameObject.Find("PuanYoneticisi").GetComponent<PuanKod>();
        if (CanSimge != null)
        {
            ilkGenislik = CanSimge.size.x;
        }

        canGrubu.SetActive(false);
    }

    void Update()
    {
        transform.Translate(Vector2.left * hareketHizi * Time.deltaTime);
        if (canBariGorunmeSuresi > 0)
        {
            canBariGorunmeSuresi -= Time.deltaTime; // Saniyeyi geri say

            if (canBariGorunmeSuresi <= 0)
            {
                canGrubu.SetActive(false); // Süre bitince kapat
            }
        }

        if (transform.position.x < -1.9f) Destroy(gameObject);
    }

    public void HasarAl(float miktar)
    {
        can -= miktar;
        float canOrani = can / 100f;

        if (CanSimge)
        {
            Vector2 yeniBoyut = CanSimge.size;
            yeniBoyut.x = ilkGenislik * canOrani;
            CanSimge.size = yeniBoyut;
        }

        canGrubu.SetActive(true); // Barı aç
        canBariGorunmeSuresi = 1f;

        if (can <= 0)
        {
            SesYonetici.PatlamaSesiCal();
            Puan.PuanEkle(2);
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mermi"))
        {
            HasarAl(20f);
        }
    }
}