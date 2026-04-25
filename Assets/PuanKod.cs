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
        Debug.Log("puan");
        carpan = carpanDegeri.CarpanArttir();
        Debug.Log("carpan");
        toplamPuan = toplamPuan + miktar * carpan;
        puan.text = "Puan: " + toplamPuan.ToString();
    }
    public int SuAnkiPuan()
    {
        return toplamPuan;
    }


}
