using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuKontrol : MonoBehaviour
{
    Animator _animator;
    public void OyunaBasla()
    {
        if (Time.timeScale == 0f)
        {
            return;
        }
        SceneManager.LoadScene("Oyun");
    }
    public void MenuyeDon()
    {
        SceneManager.LoadScene("Giris");
        Time.timeScale = 1f;
    }
    public void YenidenBaslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;

    }
    public void OyundanCikis()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBGL
            Application.ExternalEval("location.reload();");
#else
            Application.Quit();
#endif
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
        if (Time.timeScale == 0f)
        {
            return;
        }
        if (_animator != null) _animator.SetBool("UstundeMi", true);
    }

    public void MouseCikti()
    {
        if (Time.timeScale == 0f)
        {
            return;
        }
        if (_animator != null) _animator.SetBool("UstundeMi", false);
    }
}

