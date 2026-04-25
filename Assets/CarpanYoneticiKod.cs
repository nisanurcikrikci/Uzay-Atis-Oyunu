using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarpanYoneticiKod : MonoBehaviour
{



    public Image Sure;
    public TextMeshProUGUI carpanYazisi;
    public Animator _animator;
    private int aktifCarpan = 1;
    private float kalanSure = 0f;
    private bool CarpanVarMi = false;
    private float toplamSure = 5;


    void Start()
    {
        carpanYazisi.text = "1X";
        Sure.fillAmount = 1;
    }

    void Update()
    {
        if (kalanSure > 0)
        {
            kalanSure -= Time.deltaTime;
            Sure.fillAmount = kalanSure / toplamSure;
            Sure.color = Color.Lerp(Color.red, Color.blue, Sure.fillAmount);


            if (kalanSure <= 0)
            {
                CarpanSifirla();
            }
        }
    }

    public int CarpanArttir()
    {
        kalanSure = 5f;

        aktifCarpan++;
        CarpanVarMi = true;



        carpanYazisi.text = aktifCarpan.ToString() + "X";

        _animator.SetBool("CarpanVarMi", CarpanVarMi);

        return aktifCarpan;
    }
    public void CarpanSifirla()
    {
        aktifCarpan = 1;
        carpanYazisi.text = aktifCarpan.ToString() + "X";
        CarpanVarMi = false;
        _animator.SetBool("CarpanVarMi", CarpanVarMi);
        Sure.color = Color.blue;
        kalanSure = 0f;
        Sure.fillAmount = 1;
    }
}
