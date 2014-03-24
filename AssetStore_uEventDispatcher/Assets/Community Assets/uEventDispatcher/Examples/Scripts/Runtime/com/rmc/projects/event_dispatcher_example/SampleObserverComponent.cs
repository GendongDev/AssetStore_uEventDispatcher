/**
 * Copyright (C) 2005-2014 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.                                      
 */
// Marks the right margin of code *******************************************************************


//--------------------------------------
//  Imports
//--------------------------------------
using UnityEngine;
using com.rmc.projects.event_dispatcher;

//--------------------------------------
//  Namespace
//--------------------------------------
namespace com.rmc.projects.event_dispatcher_example
{
	
	//--------------------------------------
	//  Namespace Properties
	//--------------------------------------
	
	//--------------------------------------
	//  Class Attributes
	//--------------------------------------
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	public class SampleObserverComponent : MonoBehaviour 
	{
		
		//--------------------------------------
		//  Properties
		//--------------------------------------
		
		// GETTER / SETTER
		
		// PUBLIC
		/// <summary>
		/// The sample observed game object.
		/// </summary>
		public SampleObservedComponent sampleObservedGameObject;
		
		// PUBLIC STATIC

		// PRIVATE
		
		// PRIVATE STATIC


		//--------------------------------------
		//  Constructor
		//--------------------------------------
		/// <summary>
		/// Initializes a new instance of the <see cref="com.rmc.projects.event_dispatcher.SampleObserverComponent"/> class.
		/// </summary>
		public SampleObserverComponent ()
		{


		}

		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="com.rmc.projects.event_dispatcher.SampleObserverComponent"/> is reclaimed by garbage collection.
		/// </summary>
		~SampleObserverComponent ()
		{



		}

		
		//--------------------------------------
		//  Methods
		//--------------------------------------	
		
		///<summary>
		///	Use this for initialization
		///</summary>
		public void Start () 
		{
			/*
			 * NOTE: Here both the observer and observed are MonoBehavior subclasses.
			 *		 That is not a requirement. Any class type is compatible. 
			 *
			 * 
			 * 
			 * 
			 **/
			sampleObservedGameObject.eventDispatcher.addEventListener (SampleEvent.SAMPLE_EVENT, _onSampleEvent);
			
		}

		
		///<summary>
		///	Called once per frame
		///</summary>
		void Update () 
		{
			
			//Debug.Log (sampleObservedGameObject.eventDispatcher);
			
		}

		/// <summary>
		/// Raises the destroy event.
		/// </summary>
		public void OnDestroy ()
		{
			//	CLEANUP MEMORY
			sampleObservedGameObject.eventDispatcher.removeEventListener (SampleEvent.SAMPLE_EVENT, _onSampleEvent);
			
		}
		
		
		// PUBLIC

		// PUBLIC STATIC
		
		// PRIVATE
		
		// PRIVATE STATIC
		
		// PRIVATE COROUTINE
		
		// PRIVATE INVOKE
		
		//--------------------------------------
		//  Events 
		//--------------------------------------
		/// <summary>
		/// _ons the sample event.
		/// </summary>
		/// <param name="aIEvent">A I event.</param>
		public void _onSampleEvent (IEvent aIEvent)
		{

			Debug.Log ("\tListening: _onSampleEvent() aIEvent: " + aIEvent + " with customValue: " + (aIEvent as SampleEvent).customValue);

		}
		
		
	}
}

