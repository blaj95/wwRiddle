using System.Collections;
using System.Collections.Generic;
using FirebaseWebGL.Examples.Utils;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;
using TMPro;
using UnityEngine;

namespace com.pison
{
	/// <summary>
	/// 
	/// 
	/// Written by: Brodey Lajoie (blajoie95@gmail.com), 2020
	public class DBTest : MonoBehaviour
	{
		// Public Variables
		public TMP_Text text;
		
		// Private Variables
		
		
		#region Public API
		
		
		
		#endregion
		
		#region Private Helpers

		void OnRequestSuccess(string data)
		{
			text.text = data;
			text.color = Color.green;
		}
		
		void OnRequestFailed(string error)
		{
			text.text = error;
			text.color = Color.red;
		}
		
		#endregion
		
		
		#region Unity Functions
		
		void Start()
		{
			FirebaseDatabase.GetJSON("example", gameObject.name, "OnRequestSuccess", "OnRequestFailed");
		}

		void Update()
		{
			
		}
		
		#endregion
	}
}
