using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundColltroller : MonoBehaviour
{
  // Design pattern: Singleton
  public static SoundColltroller instance; 

  private void Awake()
    {
      instance = this; 
    }
  public void PlayThisSound(string clipName, float volumeMultiplier)
  {
      AudioSource audioSource = this.gameObject.AddComponent<AudioSource>(); 
      audioSource.volume *= volumeMultiplier; 
      audioSource.PlayOneShot((AudioClip)Resources.Load("Rounds/" + clipName, typeof(AudioClip))); 
  }
}
