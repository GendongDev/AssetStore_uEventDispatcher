/**
 * Copyright (C) 2005-2013 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furn
 * 
 * ished to do so, subject to
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
using com.rmc.projects.event_dispatcher;

//--------------------------------------
//  Namespace
//--------------------------------------
namespace com.rmc.projects.event_dispatcher_example
{
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	/// <summary>
	/// Test event.
	/// </summary>
	public class SampleEvent : Event
	{
		//--------------------------------------
		//  Properties
		//--------------------------------------
		// GETTER / SETTER
		/// <summary>
		/// An example of event-specific data you can add in.
		/// </summary>
		private string _customValue_string;
		public string customValue 
		{
			get {
				return _customValue_string;
			}
			set {
				_customValue_string = value;
			}
		}

		
		// PUBLIC
		
		// PUBLIC STATIC
		/// <summary>
		/// The Event Type Name
		/// </summary>
		public static string SAMPLE_EVENT = "SAMPLE_EVENT";
		
		// PRIVATE
		
		// PUBLIC
		
		// PUBLIC STATIC
		
		// PRIVATE
		
		// PRIVATE STATIC
		
		//--------------------------------------
		//  Methods
		//--------------------------------------
		// PUBLIC
		
		/// <summary>
		/// Initializes a new instance of the <see cref="com.rmc.projects.event_dispatcher.SampleEvent"/> class.
		/// </summary>
		/// <param name="aType_str">A type_str.</param>
		public SampleEvent (string aType_str ) : base (aType_str)
		{
			
		}
		
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="com.rmc.projects.event_dispatcher.SampleEvent"/> is reclaimed by garbage collection.
		/// </summary>
		//~SampleEvent ( )
		//{
		//	Debug.Log ("SampleEvent.deconstructor()");
		
		//}
		
		
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

