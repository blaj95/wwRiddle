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

		public TMP_InputField answerInput;
		
		// Private Variables
		
		
		#region Public API

		public void CheckAnswer()
		{
			if (answerInput.text.ToLower() == bookManager.riddles.answers[bookManager.riddleIndex].ToLower())
			{
				bookManager.FlipPage();
				answerInput.text = "";
			}
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
