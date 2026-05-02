using UnityEngine;

public class DusmanMermiKod : MonoBehaviour
{
    Rigidbody2D _rb;
    public float Hiz = 1f;
    public SesKod SesYonetici;
    void Start()
    {
        SesYonetici = GameObject.Find("SesYonetici").GetComponent<SesKod>();
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = Vector2.left * Hiz;
    }


    void Update()
    {
        if (transform.position.x < -1.682f) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Mermi"))
        {
            SesYonetici.vurmaSesiCal();

            Destroy(gameObject);
        }
    }
}
