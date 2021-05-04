using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BGMusic : MonoBehaviour
{
    public AudioMixerGroup mixer;    
    public Slider slider;    
    
    private void Start()
    {        
        slider.value = PlayerPrefs.GetFloat ("Master");
        PlayerPrefs.Save();
    }
    
     
    public void ChargingVolume(float volume)
    {        
        mixer.audioMixer.SetFloat("Master", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("Master", volume);
        PlayerPrefs.Save();
    }
    
}
