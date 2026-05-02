using UnityEngine;
using TMPro;

public class PuanKod : MonoBehaviour
{
    public TextMeshProUGUI puan;
    public CarpanYoneticiKod carpanDegeri;
    int carpan;
    int toplamPuan = 0;

    public void PuanEkle(int miktar)
    {
        Debug.Log(miktar);
        // carpan = carpanDegeri.CarpanArttir();
        carpan = 1;
        Debug.Log("2");
        toplamPuan = toplamPuan + miktar * carpan;
        Debug.Log("3");
        puan.text = toplamPuan.ToString();
    }
    public int SuAnkiPuan()
    {
        return toplamPuan;
    }


}
