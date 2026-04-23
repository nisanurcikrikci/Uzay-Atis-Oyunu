using UnityEngine;
using TMPro;

public class PuanKod : MonoBehaviour
{
    public TextMeshProUGUI puan;
    int toplamPuan = 0;

    public void PuanEkle(int miktar)
    {
        toplamPuan += miktar;
        puan.text = "Puan: " + toplamPuan.ToString();
    }
    public int SuAnkiPuan()
    {
        return toplamPuan;
    }


}
