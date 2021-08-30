using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace com.pison
{
	/// <summary>
	/// 
	/// 
	/// Written by: Brodey Lajoie (blajoie95@gmail.com), 2020
	public class TextFadeEvent : MonoBehaviour
	{
		public delegate void OnTextFadeInAction();

		public event OnTextFadeInAction onTextFadeIn;


		// Public Variables
		
		
		// Private Variables
		
		
		#region Public API

		public void OnTextFadeIn()
		{
			onTextFadeIn.Invoke();
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
