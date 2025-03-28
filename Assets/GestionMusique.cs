using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionMusique : MonoBehaviour
{      
    [SerializeField] AudioMixer _mixer;
    
    public void ChangerVolumeMusique(float nouveauVolume)
    {
        Debug.Log("Changer volume" + nouveauVolume);
        _mixer.SetFloat("VolumeMusique", nouveauVolume);
    }
}
