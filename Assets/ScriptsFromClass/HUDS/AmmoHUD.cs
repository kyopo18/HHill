using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoHUD : MonoBehaviour
{
    [SerializeField] AmmoStorage ammoStorage;
    [SerializeField] TextMeshProUGUI ammoCount;
    [SerializeField] TextMeshProUGUI grenadesCount;

    public void UpdateAmmoUI(int ammoValue)
    {
        ammoCount.text = ammoValue.ToString();

    }

    public void UpdateGrenadesUI(int grenadesValue)
    {
        grenadesCount.text = grenadesValue.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        ammoStorage.OnAmmoChanged.AddListener(UpdateAmmoUI);
        ammoStorage.OnGrenadesChanged.AddListener(UpdateGrenadesUI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
