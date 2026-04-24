using UnityEngine;
using UnityEngine.UI;
public class PlayerHasarKod : MonoBehaviour
{
    public float can = 100f;
    public Animator _animator;
    float bekletmeSayaci = 0; // Zamanı saymak için
    bool HasarAldiMi = false;
    public Image canBariGorseli;
    Vector2 BaslangicPozisyon;
    public SesKod SesYonetici;
    public GameObject ileri;
    void Start()
    {
        _animator = GetComponent<Animator>();
        SesYonetici = GameObject.Find("SesYonetici").GetComponent<SesKod>();
        BaslangicPozisyon = transform.position;

    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Hasar alma şartı (Gezegen veya UFO gelirse ve o an durmamışsak)
        if (collision.CompareTag("Dusman") && !HasarAldiMi)
        {
            HasarAl();
        }
    }

    void HasarAl()
    {
        SesYonetici.PatlamaSesiCal();
        can -= 20f;
        HasarAldiMi = true;
        bekletmeSayaci = 0;
        ileri.SetActive(false);
        _animator.SetBool("HasarAldiMi", HasarAldiMi);
        Time.timeScale = 0f;

    }

    void OyunuDevamEttir()
    {
        HasarAldiMi = false;
        if (canBariGorseli != null)
        {
            canBariGorseli.fillAmount = can / 100f;
        }
        _animator.SetBool("HasarAldiMi", HasarAldiMi);
        foreach (GameObject d in GameObject.FindGameObjectsWithTag("Dusman")) Destroy(d);
        foreach (GameObject m in GameObject.FindGameObjectsWithTag("Mermi")) Destroy(m);
        gameObject.transform.position = BaslangicPozisyon;

        Time.timeScale = 1f;

    }
}
