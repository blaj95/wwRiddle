using System.Collections;
using System.Collections.Generic;
using com.pison;
using TMPro;
using UnityEngine;

/// <summary>
	/// 
	/// 
	/// Written by: Brodey Lajoie (blajoie95@gmail.com), 2021
	public class BookManager : MonoBehaviour
	{
		// Public Variables
		public Riddles riddles;
		public AutoFlip book;
		
		public Animator textAnimator;
		public TMP_Text riddleText;
		
		public int riddleIndex;
		
		// Private Variables
		
		
		#region Public API

		public IEnumerator OnNextPage()
		{
			//FADE OUT
			//THEN FLIP PAGE
			Debug.Log("Next Page");
			textAnimator.SetTrigger("FadeOut");
			yield return new WaitForSeconds(1.5f);
			book.FlipRightPage();
			riddleIndex++;
			riddleText.text = riddles.riddles[riddleIndex];
			textAnimator.SetTrigger("FadeIn");
			
		}

		public void FlipPage()
		{
			StartCoroutine(OnNextPage());
		}
		
		
		#endregion
		
		#region Private Helpers
		
		
		#endregion
		
		
		#region Unity Functions
		
		void Start()
		{
			riddleText.text = riddles.riddles[riddleIndex];
			textAnimator.SetTrigger("FadeIn");	
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.RightArrow))
				StartCoroutine(OnNextPage());
		}
		
		#endregion
	}

