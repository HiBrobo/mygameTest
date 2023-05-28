using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image HealthImage;
    public int DecreaseCount = 2;
    public int HealthCount = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthCount < 100)
            HealthCount++;
        UpdateUI();
    }

    public void DecreaseHealth()
    {
        if (HealthCount <= 0)
            return;
        HealthCount -= DecreaseCount;
    }

    private void UpdateUI()
    {
        HealthImage.fillAmount = HealthCount / 100f;
    }
}
