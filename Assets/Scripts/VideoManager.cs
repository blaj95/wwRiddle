using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace com.pison
{
	/// <summary>
	/// 
	/// 
	/// Written by: Brodey Lajoie (blajoie95@gmail.com), 2020
	public class VideoManager : MonoBehaviour
	{
		// Public Variables
		public VideoPlayer videoPlayer;
		
		// Private Variables
		
		
		#region Public API
		
		
		
		#endregion
		
		#region Private Helpers

		IEnumerator DelayedVideoPlay()
		{
			yield return new WaitForSeconds(1.5f);
			videoPlayer.url = System.IO.Path.Combine (Application.streamingAssetsPath,"ww1.mp4");
			videoPlayer.Prepare();
			videoPlayer.prepareCompleted += OnPrepareCompleted;
		}

		private void OnPrepareCompleted(VideoPlayer source)
		{
			videoPlayer.Play();
		}

		#endregion
		
		
		#region Unity Functions
		
		void Start()
		{
			StartCoroutine(DelayedVideoPlay());
		}

		void Update()
		{
			
		}
		
		#endregion
	}
}
