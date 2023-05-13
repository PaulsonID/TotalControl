using System;
using UnityEngine;

public class LampRoom : MonoBehaviour
{
    [SerializeField] private float timeAnimation = 8.0f;

    [Header("Min and max Range light")]
    [SerializeField] private float minRange = 0.0f;
    [SerializeField] private float maxRange = 10.0f;

    // Intensity material of lamp
    private float minIntensity = -10.0f;
    private float maxIntensity = 0.0f;

    private bool isAnimation = false;
    private bool stateLight = true;

    private Light targetLight;
    private MeshRenderer targetRenderer;

    private void Start()
    {
        targetLight = transform.GetChild(0).GetComponent<Light>();
        targetRenderer = transform.GetChild(1).GetChild(0).gameObject.GetComponent<MeshRenderer>();
    }

    private void Update() => PlayAnimationLight();

    public void SetActiveLight(bool set)
    {
        isAnimation = true;
        stateLight = set;

        // Change intensity emission material Lightbulb
        Vector4 colorWhite = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
        float targetIntensity = stateLight ? maxIntensity : minIntensity;

        targetRenderer.material.SetColor("_EmissionColor", colorWhite * Mathf.Pow(2.0F, targetIntensity));
    }

    private void PlayAnimationLight()
    {
        if (isAnimation)
        {
            // Light
            float nowRange = targetLight.range;
            float targetRange = stateLight ? maxRange : minRange;

            targetLight.range = Mathf.Lerp(nowRange, targetRange, Time.deltaTime * timeAnimation);

            if ((!stateLight && targetLight.range - targetRange <= 1.0f) || (stateLight && targetRange - targetLight.range <= 1.0f))
            {
                isAnimation = false;
                targetLight.range = targetRange;
            }
        }
    }
}
