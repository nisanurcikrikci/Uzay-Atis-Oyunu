using UnityEngine;

public class PlayerKontrolKod : MonoBehaviour
{
    public SesKod SesYonetici;
    public GameObject Flash;
    public Transform Namlu;
    public GameObject MermiSablon;
    public GameObject ileri;
    Animator _animator;
    Rigidbody2D _rigidbody;
    Vector2 _hiz = Vector2.zero;
    void Start()
    {
        SesYonetici = GameObject.Find("SesYonetici").GetComponent<SesKod>();
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void AtesEt()
    {
        var yeniMermi = GameObject.Instantiate(MermiSablon);
        yeniMermi.transform.position = Namlu.position;
        Flash.SetActive(true);
        SesYonetici.MermiSesiCal();
    }


    void Update()
    {
        if (Time.timeScale == 0f)
        {
            return;
        }
        bool yukariBasildiMi = false;
        bool asagiBasildiMi = false;
        bool sagBasildiMi = false;
        bool solBasildiMi = false;
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
        if (Input.GetKey(KeyCode.D))
        {
            if (_hiz.x < 0.5f)
                _hiz += Vector2.right * 0.1f;
            sagBasildiMi = true;
            ileri.SetActive(true);
        }
        else
        {
            sagBasildiMi = false;
            ileri.SetActive(false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (_hiz.x > -0.5f)
                _hiz += Vector2.left * 0.1f;
            solBasildiMi = true;
            ileri.SetActive(false);
        }
        else
        {
            solBasildiMi = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AtesEt();
        }
        if (!asagiBasildiMi && !yukariBasildiMi)
        {
            _hiz.y = 0;
        }
        if (!sagBasildiMi && !solBasildiMi)
        {
            _hiz.x = 0;
        }

        _animator.SetBool("AsagiBasildiMi", asagiBasildiMi);
        _animator.SetBool("YukariBasildiMi", yukariBasildiMi);
        _rigidbody.linearVelocity = _hiz;
    }
}
