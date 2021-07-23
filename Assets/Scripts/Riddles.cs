using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.pison
{
	/// <summary>
	/// 
	/// 
	/// Written by: Brodey Lajoie (blajoie95@gmail.com), 2020
	public class Riddles : MonoBehaviour
	{
		// Public Variables

		// Private Variables
		internal List<string> riddles = new List<string>
		{
			"The Guardian that fell from grace\nCombats a hero who's taken their place\nAtop a group no longer famed\n Through some persis who remember their name",
			"Corruption threatens\nSimplicity holds the cure\nWhere the Master rests",
			"The spirits tell of gnarled roots\nthat once broke through the densest ground\nEvasive as this place can be\nAll that exists can sure be found\nSearch from yourself to this world's end\nTo divinate Her third knuckle\nOnce you've arrived, take one step back\nLest two steps make you buckle",
			"The Prophecy of Her return\nWithstands the test of time\nTwo corners of the Council's strength\nWere cast to hold the line\nTheir joining spans the ages\nWithout faltering in grip\nThe final bone forever waits\nAboard the Monarch's ship",
			"With all bones in hand\nThe cult's power turns hollow\nIt's time that we meet\nFor they're sure to soon follow\nAs rider on this journey\nThere's little time left to traverse\nYour waite will come to its conclusion\nWhere disaster is reversed"
		};
		
		internal List<string> answers = new List<string>()
		{
			"Council of Nine",
			"Gichu-ji Temple",
			"Sturge Island",
			"Giza Necropolis",
			"The Tower"
		};
		
		#region Public API
		
		
		
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
