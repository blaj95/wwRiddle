using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.pison
{
	/// <summary>
	/// 
	/// 
	/// Written by: Brodey Lajoie (blajoie95@gmail.com), 2020
	public class AudioManager : MonoBehaviour
	{
		// Public Variables
		public AudioSource writingAudioSource;
		public List<AudioClip> writingClips;
		
		// Private Variables
		
		
		#region Public API

		public void PlayWritingClip()
		{
			int clipIndex = Random.Range(0, 3);
			writingAudioSource.PlayOneShot(writingClips[clipIndex]);
		}
		
		
		#endregion
		
		#region Private Helpers
		
		
		#endregion
		
		
		#region Unity Functions
		
		void Start()
		{
			
		}

		void Update()
		{
			
		}
		
		#endregion
	}
}
