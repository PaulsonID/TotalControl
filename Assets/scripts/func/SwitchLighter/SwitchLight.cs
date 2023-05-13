using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    private Transform switcher;
    private float positionOn = -10.0f;
    private float positionOff = 10.0f;


    private void Awake() => switcher = transform;

    public void RotateSwitch(bool isOn)
    {
        float position = isOn ? positionOn : positionOff;

        Vector3 positionSwitch = new Vector3(position, 0.0f, 0.0f);

        switcher.localEulerAngles = positionSwitch;
    }
}
