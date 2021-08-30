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
		public TextFadeEvent textFadeEvents;
		public TMP_InputField answerInput;
		public TMP_Text answerFadeText;
		
		public GameObject answerInputObject;
		
		// Private Variables
		private bool checking;
		
		#region Public API

		//Will eventually check if the answer is wrong or not with Enter
		public IEnumerator SubmitAnswer(string answer)
		{
			//So user can't press enter again
			checking = true;
			
			//Clear input field and turn it off
			answerInput.SetTextWithoutNotify("");
			answerInput.interactable = false;
			
			//transfer text to page
			answerFadeText.text = answer;
			
			yield return new WaitForSeconds(3);
			answerFadeText.text = "";
			
			//check if right or wrong
			if (answer.ToLower().Contains(bookManager.riddles.answers[bookManager.riddleIndex].ToLower()))
			{
				StartCoroutine("PlayAnswerAnimation");
			}
			else
			{
				answerInput.interactable = true;
			}

			checking = false;
		}
		
		public void CheckAnswer()
		{
			
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
		
		private void OnTextFadeIn()
		{
			answerInputObject.SetActive(true);
		}

		
		#endregion
		
		
		#region Unity Functions
		
		private void Awake()
		{
			textFadeEvents.onTextFadeIn += OnTextFadeIn;
		}
		
		void Start()
		{
			
		}

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Return))
			{
				if (!checking)
				{
					StartCoroutine(SubmitAnswer(answerInput.text));
				}
			}
		}
		
		#endregion
	}
}
