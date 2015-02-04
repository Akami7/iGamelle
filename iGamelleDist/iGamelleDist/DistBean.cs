/*
 * Created by SharpDevelop.
 * User: Akami
 * Date: 27/01/2015
 * Time: 13:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Timers;
using WComp.Beans;
using WComp.Util;

namespace WComp.Beans
{
	/// <summary>
	/// This is a sample bean, which has an integer evented property and a method.
	/// 
	/// Notes: for beans creating threads, the IThreadCreator interface should be implemented,
	/// 	providing a cleanup method should be implemented and named `Stop()'.
	/// For proxy beans, the IProxyBean interface should  be implemented,
	/// 
	/// 	providing the IsConnected property, allowing the connection status to be drawn in
	/// 	the AddIn's graphical designer.
	/// 
	/// Several classes can be defined or used by a Bean, but only the class with the
	/// [Bean] attribute will be available in WComp. Its ports will be all public methods,
	/// events and properties definied in that class.
	/// </summary>
	[Bean(Category="iGamelle")]
	public class Dist
	{
		/// <summary>
		/// Fill in private attributes here.
		/// </summary>
		private double val;
	private  System.Timers.Timer timer;
	
		/// <summary>
		/// This property will appear in bean's property panel and bean's input functions.
		/// </summary>
		public double MyVal {
			get { return val; }
			set {
				val = value;
			//	FireIntEvent(val);		// event will be fired for every property set.
			}
		}
		
		public Dist (){
		
			timer = new Timer(1000);
			
			timer.AutoReset = false;
			
			timer.Elapsed += wait;
			
			
		}

		/// <summary>
		/// A method sending an event, which is here simply the argument + 1.
		/// Note that there is no return type to the method, because we use events to send
		/// information in WComp. Return values don't have to be used.
		/// </summary>
	
		
		public void ValToDist(int arg) {
		   
			
		    val = arg/100f;
			if (timer.Enabled){
				return;
				
			}
		    Console.WriteLine("Dist1 :"+val+" cm");
			Logger.Info("Dist :"+val+" cm");
			
			timer.Start();
			Logger.Info("Firing event now with value from ValToDist : " + val);
	
			FireIntEvent(val);
			
			
		}
//		

		/// <summary>
		/// Here are the delegate and his event.
		/// A function checking nullity should be used to fire events (like FireIntEvent).
		/// </summary>
		public delegate void IntValueEventHandler(double val);
		/// <summary>
		/// the following declaration is the event by itself. Its name, here "PropertyChanged",
		/// is the name of the event as it will be displayed in the bean type's interface.
		/// </summary>
		public event IntValueEventHandler PropertyChanged;
		
		private void FireIntEvent(double i) {
			if (PropertyChanged != null){
				
				PropertyChanged(i);
			}
		}
		private  void wait(Object source,ElapsedEventArgs e) {
			Logger.Info("Firing event now from WAIT with : " + val );
			FireIntEvent(val);
		}
	}
	}

