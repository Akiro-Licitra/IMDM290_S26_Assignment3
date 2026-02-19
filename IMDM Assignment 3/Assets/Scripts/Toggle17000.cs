using UnityEngine;

public class Toggle17000 : MonoBehaviour
{
    public float targetHz = 17000;
    
    public float threshold = 0.0001f; 

    private MeshRenderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (AudioSpectrum.samples == null || AudioSpectrum.samples.Length == 0) return;

        int fftSize = AudioSpectrum.samples.Length;
        float nyquist = AudioSettings.outputSampleRate * 0.5f; 
        
        int fftBin = Mathf.Clamp(Mathf.RoundToInt((targetHz / nyquist) * fftSize), 0, fftSize - 1);

        float rawValue = AudioSpectrum.samples[fftBin];

        bool hasSound = rawValue > threshold;

        if (myRenderer.enabled != hasSound)
        {
            myRenderer.enabled = hasSound;
        }
    }
}