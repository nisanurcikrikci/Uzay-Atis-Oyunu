using UnityEngine;

public class PlazmaKod : MonoBehaviour
{
    Rigidbody2D _rb;
    public float Hiz = 0.5f;
    public SesKod SesYonetici;
    void Start()
    {
        //SesYonetici = GameObject.Find("SesYonetici").GetComponent<SesKod>();
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = Vector2.right * Hiz;
    }


    void Update()
    {
        if (transform.position.x > 1.682f) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dusman"))
        {
            SesYonetici.vurmaSesiCal();

            Destroy(gameObject);
        }
    }
}
