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

        carpan = carpanDegeri.CarpanArttir();

        toplamPuan = toplamPuan + miktar * carpan;
        puan.text = toplamPuan.ToString();
    }
    public int SuAnkiPuan()
    {
        Debug.Log(toplamPuan);
        return toplamPuan;
    }


}
