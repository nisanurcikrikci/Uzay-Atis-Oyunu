using UnityEngine;

public class UfoKod : MonoBehaviour
{
    public SesKod SesYonetici; // Unity içinde Ses Yöneticisi objesini buraya sürükle
    Vector2 _hiz = Vector2.zero;
    Rigidbody2D _rigidbody;
    float HedefY;
    float zamanlayici = 0f;

    void Start()
    {
        SesYonetici = GameObject.Find("SesYonetici").GetComponent<SesKod>();
        _rigidbody = GetComponent<Rigidbody2D>();
        HedefY = transform.position.y;
    }

    void Update()
    {
        _hiz.x = -1.0f;

        if (true)
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
            Destroy(gameObject);
            SesYonetici.PatlamaSesiCal();
        }
    }
}