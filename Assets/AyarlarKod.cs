using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AyarlarKod : MonoBehaviour
{

    public AudioMixer AnaSes;
    public GameObject Ayarlar;
    public Slider MenuSlider;
    public Slider OyunSlider;
    public Slider SFXSlider;

    void Start()
    {
        Ayarlar.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PaneliAcKapat();
        }
    }

    public void PaneliAcKapat()
    {
        Ayarlar.SetActive(!Ayarlar.activeSelf);
        if (Ayarlar.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }


    public void MenuSesiniAyarla(float deger)
    {

        float db = deger > 0.0001f ? Mathf.Log10(deger) * 20 : -80f;
        AnaSes.SetFloat("Menu", db);
    }

    public void OyunSesiniAyarla(float deger)
    {
        float db = deger > 0.0001f ? Mathf.Log10(deger) * 20 : -80f;
        AnaSes.SetFloat("Oyun", db);
    }

    public void SfxSesiniAyarla(float deger)
    {
        float db = deger > 0.0001f ? Mathf.Log10(deger) * 20 : -80f;
        AnaSes.SetFloat("SFX", db);
    }
    void OnEnable()
    {
        if (AnaSes == null) return;

        // Mevcut desibel değerlerini almak için değişkenler
        float menuDB, oyunDB, sfxDB;

        // Mikser'den değerleri oku (Parametre isimleri mikserle aynı olmalı!)
        AnaSes.GetFloat("Menu", out menuDB);
        AnaSes.GetFloat("Game", out oyunDB);
        AnaSes.GetFloat("SFXV", out sfxDB);

        // Desibeli tekrar 0-1 arası slider değerine çevir ve slider'a ata
        MenuSlider.value = Mathf.Pow(10, menuDB / 20);
        OyunSlider.value = Mathf.Pow(10, oyunDB / 20);
        SFXSlider.value = Mathf.Pow(10, sfxDB / 20);
    }
}