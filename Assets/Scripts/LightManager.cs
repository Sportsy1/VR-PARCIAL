using UnityEngine;

public class LightManager : MonoBehaviour
{
    private Light _light;
    private float storedIntensity;
    private bool isOn;

    private void Awake()
    {
        _light = GetComponent<Light>();
        storedIntensity = _light.intensity;
        isOn = true;
    }

    public void TurnOn()
    {
        _light.intensity = 0;
    }

    public void TurnOff()
    {
        _light.intensity = storedIntensity;
    }

    public void Switch()
    {
        if (isOn == true)
        {
            _light.intensity = 0;
            isOn = false;
        }
        else
        {
            _light.intensity = storedIntensity;
            isOn = true;
        }
    }
}
