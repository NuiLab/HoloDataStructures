using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour {

	public AudioMixer masterMixer;

	public void SetMusicAudioLevel(float audioLevel)
	{
		masterMixer.SetFloat ("musicVolume", audioLevel);
	}

}
