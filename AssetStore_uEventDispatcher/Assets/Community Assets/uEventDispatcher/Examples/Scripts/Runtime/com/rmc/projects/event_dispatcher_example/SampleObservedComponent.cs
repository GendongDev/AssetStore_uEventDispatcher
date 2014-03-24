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
	public class SampleObservedComponent : MonoBehaviour 
	{
		
		//--------------------------------------
		//  Properties
		//--------------------------------------
		
		// GETTER / SETTER
		
		// PUBLIC
		
		// PUBLIC STATIC
		
		// PRIVATE
		/// <summary>
		/// The event dispatcher.
		/// </summary>
		public EventDispatcher eventDispatcher;
		
		// PRIVATE STATIC
		
		
		//--------------------------------------
		//  Constructor
		//--------------------------------------
		/// <summary>
		/// Initializes a new instance of the <see cref="com.rmc.projects.event_dispatcher.SampleObservedComponent"/> class.
		/// </summary>
		public SampleObservedComponent ()
		{
			
			eventDispatcher = new EventDispatcher (this);
		}
		
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="com.rmc.projects.event_dispatcher.SampleObservedComponent"/> is reclaimed by garbage collection.
		/// </summary>
		~SampleObservedComponent ()
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
			
			SampleEvent sampleEvent = new SampleEvent (SampleEvent.SAMPLE_EVENT);
			sampleEvent.customValue = "foo";
			Debug.Log ("Dispatching: SampleEvent " + sampleEvent);
			eventDispatcher.dispatchEvent (sampleEvent);
		}
		
		
		///<summary>
		///	Called once per frame
		///</summary>
		void Update () 
		{


			
		}
		
		/// <summary>
		/// Raises the destroy event.
		/// </summary>
		public void OnDestroy ()
		{
			//	CLEANUP MEMORY
			eventDispatcher.removeAllEventListeners();
			eventDispatcher = null;
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
		
		
	}
}

