using UnityEngine;
using UnityEngine.UI;
public class PlayerHasarKod : MonoBehaviour
{
    public float can = 90f;
    public Animator _animator;
    bool HasarAldiMi = false;
    public Image canBariGorseli;
    Vector2 BaslangicPozisyon;
    public SesKod SesYonetici;
    public GameObject ileri;
    public CarpanYoneticiKod carpanDegeri;
    public GameObject oyunBitti;
    void Start()
    {
        _animator = GetComponent<Animator>();
        //SesYonetici = GameObject.Find("SesYonetici").GetComponent<SesKod>();
        BaslangicPozisyon = transform.position;

    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Dusman"))
        {
            HasarAl();
        }
    }

    void HasarAl()
    {
        SesYonetici.PatlamaSesiCal();
        can -= 30f;
        if (canBariGorseli != null)
        {
            canBariGorseli.fillAmount = can / 90f;
        }
        HasarAldiMi = true;
        ileri.SetActive(false);
        if (can <= 0)
        {
            OyunBitti();
        }
        else
        {
            _animator.SetBool("HasarAldiMi", HasarAldiMi);
        }
        Time.timeScale = 0f;
    }

    void OyunuDevamEttir()
    {
        HasarAldiMi = false;


        _animator.SetBool("HasarAldiMi", HasarAldiMi);
        foreach (GameObject d in GameObject.FindGameObjectsWithTag("Dusman")) Destroy(d);
        foreach (GameObject m in GameObject.FindGameObjectsWithTag("Mermi")) Destroy(m);
        gameObject.transform.position = BaslangicPozisyon;
        carpanDegeri.CarpanSifirla();
        Time.timeScale = 1f;

    }
    void OyunBitti()
    {
        oyunBitti.SetActive(true);
        Time.timeScale = 0f;
    }
}
