using UnityEngine;

public class SesKod : MonoBehaviour
{
    public AudioSource Patlama;
    public AudioSource Vurma;
    public AudioSource Mermi;
    public AudioSource Muzik;
    void Start()
    {
        Muzik.Play();
    }


    void Update()
    {

    }
    public void PatlamaSesiCal()
    {
        Patlama.Play();
    }
    public void vurmaSesiCal()
    {
        Vurma.Play();
    }
    public void MermiSesiCal()
    {
        Mermi.Play();
    }
}
