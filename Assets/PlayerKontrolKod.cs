using UnityEngine;

public class PlayerKontrolKod : MonoBehaviour
{
    public AudioSource AtesSesi;
    public GameObject Flash;
    public Transform Namlu;
    public GameObject PlazmaSablon;
    Animator _animator;
    Rigidbody2D _rigidbody;
    Vector2 _hiz = Vector2.zero;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void AtesEt()
    {
        var yeniPlazma = GameObject.Instantiate(PlazmaSablon);
        yeniPlazma.transform.position = Namlu.position;
        Flash.SetActive(true);
        AtesSesi.Play();
    }


    void Update()
    {
        bool yukariBasildiMi = false;
        bool asagiBasildiMi = false;
        if (Input.GetKey(KeyCode.W))
        {
            yukariBasildiMi = true;
            if (_hiz.y < 0.5f)
                _hiz += Vector2.up * 0.1f;
        }
        else
        {
            yukariBasildiMi = false;

        }
        if (Input.GetKey(KeyCode.S))
        {
            asagiBasildiMi = true;
            if (_hiz.y > -0.5f)
                _hiz += Vector2.down * 0.1f;
        }
        else
        {
            asagiBasildiMi = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AtesEt();
        }
        if (!asagiBasildiMi && !yukariBasildiMi)
            _hiz = Vector2.zero;

        _animator.SetBool("AsagiBasildiMi", asagiBasildiMi);
        _animator.SetBool("YukariBasildiMi", yukariBasildiMi);
        _rigidbody.linearVelocity = _hiz;
    }
}
