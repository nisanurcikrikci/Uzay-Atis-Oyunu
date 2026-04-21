using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuKontrol : MonoBehaviour
{
    Animator _animator;
    public void OyunaBasla()
    {
        SceneManager.LoadScene("Oyun");
    }

    public void OyundanCikis()
    {
        Debug.Log("Oyundan Çıkıldı");
        Application.Quit();
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
    }


    void Update()
    {

    }
    public void MouseGirdi()
    {
        if (_animator != null) _animator.SetBool("UstundeMi", true);
    }

    public void MouseCikti()
    {
        if (_animator != null) _animator.SetBool("UstundeMi", false);
    }
}

