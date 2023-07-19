using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform masukanLoadingbar;

    [SerializeField]
    private float nilaiSekarang;

    [SerializeField]
    private float nilaiKecepatan;

    // Update is called once per frame
    void Update()
    {
        if (nilaiSekarang < 100) {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log ((int)nilaiSekarang);
        } else {
            Application.LoadLevel ("main");
        }
        masukanLoadingbar.GetComponent<Image> ().fillAmount = nilaiSekarang / 100;
        
    }
}
