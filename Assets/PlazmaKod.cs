using UnityEngine;

public class PlazmaKod : MonoBehaviour
{
    Rigidbody2D _rb;
    public float Hiz = 0.5f;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = Vector2.right * Hiz;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
