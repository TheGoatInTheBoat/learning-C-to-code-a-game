using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private UnityEngine.UI.Image totalhealthBar;
    [SerializeField] private UnityEngine.UI.Image currenthealthBar;

    // Start is called before the first frame update
    private void Start()
    {
        totalhealthBar.fillAmount = playerHealth.current_health / 10;

    }

    // Update is called once per frame
    private void Update()
    {
        currenthealthBar.fillAmount = playerHealth.current_health / 10;
    }
}
