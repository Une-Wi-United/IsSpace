using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllHealth : MonoBehaviour {
    public Image HealthBar;
    private void FixedUpdate()
    {
        HealthBar.fillAmount = GetComponent<DamageSystem>().hp / 100;
    }

    // Update is called once per frame
}
