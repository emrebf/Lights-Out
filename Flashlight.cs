using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    Light m_Light;
    public bool drainOverTime;
    public float maxBrightness;
    public float minBrightness;
    public float drainRate;

    public BatteryBar batteryBar;

    void Start()
    {
        m_Light = GetComponent<Light>();
        batteryBar.SetMaxBattery(maxBrightness);
    }

    // Update is called once per frame
    void Update()
    {
        if(drainOverTime == true && m_Light.enabled == true)
        {
            m_Light.intensity = Mathf.Clamp(m_Light.intensity, minBrightness, maxBrightness);
            if(m_Light.intensity > minBrightness)
            {
                m_Light.intensity -= Time.deltaTime *(drainRate/1000);
                batteryBar.SetBattery(m_Light.intensity);
            }
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            m_Light.enabled = !m_Light.enabled;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReplaceBattery(.3f);
        }
    }

    public void ReplaceBattery(float amount)
    {
        m_Light.intensity += amount;
    }
}
