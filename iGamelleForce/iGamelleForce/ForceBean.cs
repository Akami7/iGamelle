/*
 * Created by SharpDevelop.
 * User: Akami
 * Date: 26/01/2015
 * Time: 22:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using WComp.Util;

using WComp.Beans;

namespace WComp.Beans
{
	/// <summary>
	/// This is a sample bean, which has an integer evented property and a method.
	/// 
	/// Notes: for beans creating threads, the IThreadCreator interface should be implemented,
	/// 	providing a cleanup method should be implemented and named `Stop()'.
	/// For proxy beans, the IProxyBean interface should  be implemented,
	/// 	providing the IsConnected property, allowing the connection status to be drawn in
	/// 	the AddIn's graphical designer.
	/// 
	/// Several classes can be defined or used by a Bean, but only the class with the
	/// [Bean] attribute will be available in WComp. Its ports will be all public methods,
	/// events and properties definied in that class.
	/// </summary>
	[Bean(Category="iGamelle")]
	public class Force
	{
		/// <summary>
		/// Fill in private attributes here.
		/// </summary>
		private int force;

		/// <summary>
		/// This property will appear in bean's property panel and bean's input functions.
		/// </summary>
		public int MyForce {
			get { return force; }
			set {
				force = value;
				FireIntEvent(force);		// event will be fired for every property set.
			}
		}

		/// <summary>
		/// A method sending an event, which is here simply the argument + 1.
		/// Note that there is no return type to the method, because we use events to send
		/// information in WComp. Return values don't have to be used.
		/// </summary>
		public void ForceToWeight(int arg) {
			double weight= 15.311 * Math.Exp(0.005199*arg);
		//	string s= Convert.ToString(weight);
			Console.WriteLine("Weight :"+weight+" grams");
			Logger.Info("Weight :"+weight+" grams");
			FireIntEvent(weight);
		}

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
			if (PropertyChanged != null)
				PropertyChanged(i);
		}
	}
}
