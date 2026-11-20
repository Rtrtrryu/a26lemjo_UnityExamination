using UnityEngine;
using UnityEngine.UI;

public class VolymController : MonoBehaviour
{
    public Slider volumeSlider;

    private void Awake()
    {
        
        DontDestroyOnLoad(gameObject);

        
        volumeSlider.minValue = 0f;
        volumeSlider.maxValue = 1f;

        
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1f);

        
        AudioListener.volume = savedVolume;

        
        volumeSlider.value = savedVolume;

        
        volumeSlider.onValueChanged.AddListener(Volymcontrol);
    }

    public void Volymcontrol(float volym)
    {
        AudioListener.volume = volym;
    }
}
