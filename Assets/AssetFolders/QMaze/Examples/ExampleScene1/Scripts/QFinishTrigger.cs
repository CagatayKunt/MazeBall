using UnityEngine;
using System.Collections;

namespace qtools.qmaze.example4
{
	public class QFinishTrigger : MonoBehaviour 
	{
		public delegate void QFinishTriggerHandler();

		public event QFinishTriggerHandler triggerHandlerEvent;

		void OnTriggerEnter () 
		{
			if (triggerHandlerEvent != null)
			{
				triggerHandlerEvent();
			}
		}
	}
}