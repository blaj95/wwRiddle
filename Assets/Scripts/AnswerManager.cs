using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace com.pison
{
	/// <summary>
	/// 
	/// 
	/// Written by: Brodey Lajoie (blajoie95@gmail.com), 2020
	public class AnswerManager : MonoBehaviour
	{
		// Public Variables
		public BookManager bookManager;
		public AnswerAnimations answerAnimations;
		
		public TMP_InputField answerInput;
		
		// Private Variables
		
		
		#region Public API

		public void CheckAnswer()
		{
			if (answerInput.text.ToLower().Contains(bookManager.riddles.answers[bookManager.riddleIndex].ToLower()))
			{

				StartCoroutine("PlayAnswerAnimation");
				answerInput.text = "";
				answerInput.interactable = false;
			}
		}

		IEnumerator PlayAnswerAnimation()
		{
			answerAnimations.animators[bookManager.riddleIndex].SetTrigger("Correct");
			yield return new WaitForSeconds(answerAnimations.animationTimes[bookManager.riddleIndex]);
			answerAnimations.animators[bookManager.riddleIndex].gameObject.SetActive(false);
			bookManager.FlipPage();
			answerInput.interactable = true;
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
