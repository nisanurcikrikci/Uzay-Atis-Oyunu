using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
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

    }


    void Update()
    {

    }
}
