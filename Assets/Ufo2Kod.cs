using UnityEngine;

public class Dusman2Kod : MonoBehaviour
{
    public SesKod SesYonetici;
    Vector2 _hiz = Vector2.zero;
    Rigidbody2D _rigidbody;
    float HedefY;
    float zamanlayici = 0f;
    public PuanKod Puan;
    public Transform Namlu;
    public GameObject MermiSablon;

    void Start()
    {
        SesYonetici = GameObject.Find("SesYonetici").GetComponent<SesKod>();
        Puan = GameObject.Find("PuanYoneticisi").GetComponent<PuanKod>();
        _rigidbody = GetComponent<Rigidbody2D>();
        HedefY = transform.position.y;
        InvokeRepeating("AtesEt", 2f, 5f);
    }

    void Update()
    {
        _hiz.x = -0.2f;

        if (Puan.SuAnkiPuan() >= 40)
        {
            zamanlayici += Time.deltaTime;
            if (zamanlayici >= 2f)
            {
                HedefY = Random.Range(-0.7f, 0.8f);
                zamanlayici = 0f;
            }
        }

        if (transform.position.y < HedefY - 0.05f)
        {
            _hiz.y = 1.5f;
        }
        else if (transform.position.y > HedefY + 0.05f)
        {
            _hiz.y = -1.5f;
        }
        else
        {
            _hiz.y = 0f;
        }
        _rigidbody.linearVelocity = _hiz;


        if (transform.position.x < -1.9f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mermi"))
        {
            Puan.PuanEkle(1);
            SesYonetici.PatlamaSesiCal();
            Destroy(gameObject);

        }
    }
    public void AtesEt()
    {
        var yeniMermi = GameObject.Instantiate(MermiSablon);
        yeniMermi.transform.position = Namlu.position;
    }
}
