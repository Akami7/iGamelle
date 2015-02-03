/*
 * Created by SharpDevelop.
 * User: Akami
 * Date: 03/02/2015
 * Time: 09:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

using WComp.Beans;

namespace ProtoTest
{
	/// <summary>
	/// Description of Container3.
	/// </summary>
	public class Container3 : System.Windows.Forms.Form
	{
        [BeanDesignLocation(232,216)]
        private WComp.BasicBeans.ValueFormatter valueFormatter1;
        [BeanDesignLocation(392,200)]
        private System.Windows.Forms.TextBox textBox1;
        [BeanDesignLocation(64,152)]
        private WComp.Phidgets.Thin_Force_Sensor thin_Force_Sensor1;
        [BeanDesignLocation(56,328)]
        private WComp.Phidgets.IR_Reflective_Sensor_10cm iR_Reflective_Sensor_10cm1;
        [BeanDesignLocation(312,376)]
        private WComp.BasicBeans.ValueFormatter valueFormatter2;
        [BeanDesignLocation(432,408)]
        private System.Windows.Forms.TextBox textBox2;
        [BeanDesignLocation(568,48)]
        private WComp.Phidgets.GenericOutput genericOutput1;
        [BeanDesignLocation(608,208)]
        private WComp.Phidgets.GenericOutput genericOutput2;
        [BeanDesignLocation(376,48)]
        private WComp.BasicBeans.Threshold threshold1;
        [BeanDesignLocation(560,336)]
        private WComp.BasicBeans.Threshold threshold2;
        [BeanDesignLocation(440,272)]
        private WComp.Logic.NOT nOT1;
        [BeanDesignLocation(160,104)]
        private WComp.Beans.Force force1;
        [BeanDesignLocation(192,392)]
        private WComp.Beans.Dist dist1;
		public Container3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// The InitializeBeans() call is required for WComp.NET designer support.
			//
			InitializeBeans();
			
			//
			// TODO: Add constructor code after the InitializeBeans() call.
			//
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new Container3());
		}
		
		#region WComp.NET designer generated code
		/// <summary>
		/// This method is required for WComp.NET designer support.
		/// Do not change the method contents inside the source code editor.
		/// The WComp.NET designer might not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource = null;
            this.textBox1.Text = "0";
            this.textBox1.Controls = null;
            this.textBox1.DataBindings = null;
            this.textBox1.Location = new System.Drawing.Point(392, 200);
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteCustomSource = null;
            this.textBox2.Text = "0,09";
            this.textBox2.Controls = null;
            this.textBox2.DataBindings = null;
            this.textBox2.Location = new System.Drawing.Point(432, 408);
            // 
            // Container
            // 
            this.Text = "SharpWComp static application";
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
        }
		
		/// <summary>
		/// This method is required for WComp.NET designer support.
		/// Do not change the method contents inside the source code editor.
		/// The WComp.NET designer might not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeBeans() {
            this.valueFormatter1 = new WComp.BasicBeans.ValueFormatter();
            this.thin_Force_Sensor1 = new WComp.Phidgets.Thin_Force_Sensor();
            this.iR_Reflective_Sensor_10cm1 = new WComp.Phidgets.IR_Reflective_Sensor_10cm();
            this.valueFormatter2 = new WComp.BasicBeans.ValueFormatter();
            this.genericOutput1 = new WComp.Phidgets.GenericOutput();
            this.genericOutput2 = new WComp.Phidgets.GenericOutput();
            this.threshold1 = new WComp.BasicBeans.Threshold();
            this.threshold2 = new WComp.BasicBeans.Threshold();
            this.nOT1 = new WComp.Logic.NOT();
            this.force1 = new WComp.Beans.Force();
            this.dist1 = new WComp.Beans.Dist();
            // 
            // thin_Force_Sensor1
            // 
            this.thin_Force_Sensor1.Value = 0;
            this.thin_Force_Sensor1.Serial = 0;
            this.thin_Force_Sensor1.Port = 6;
            this.thin_Force_Sensor1.Type = "Thin_Force_Sensor";
            this.thin_Force_Sensor1.Reference = 1131;
            // 
            // iR_Reflective_Sensor_10cm1
            // 
            this.iR_Reflective_Sensor_10cm1.Value = 9;
            this.iR_Reflective_Sensor_10cm1.Serial = 0;
            this.iR_Reflective_Sensor_10cm1.Port = 1;
            this.iR_Reflective_Sensor_10cm1.Type = "IR_Reflective_Sensor_10cm";
            this.iR_Reflective_Sensor_10cm1.Reference = 1103;
            // 
            // genericOutput1
            // 
            this.genericOutput1.Value = false;
            this.genericOutput1.Serial = 0;
            this.genericOutput1.Port = 5;
            this.genericOutput1.Type = null;
            this.genericOutput1.Reference = 0;
            // 
            // genericOutput2
            // 
            this.genericOutput2.Value = false;
            this.genericOutput2.Serial = 0;
            this.genericOutput2.Port = 4;
            this.genericOutput2.Type = null;
            this.genericOutput2.Reference = 0;
            // 
            // threshold1
            // 
            this.threshold1.Value = "0";
            this.threshold1.ThresholdValue = 17;
            this.threshold1.Inverted = false;
            this.threshold1.Min = 0;
            this.threshold1.Max = 19.856303716933;
            // 
            // threshold2
            // 
            this.threshold2.Value = "0";
            this.threshold2.ThresholdValue = 8;
            this.threshold2.Inverted = false;
            this.threshold2.Min = 0;
            this.threshold2.Max = 90;
            // 
            // nOT1
            // 
            this.nOT1.Value = true;
            // 
            // force1
            // 
            this.force1.MyForce = 0;
            // 
            // dist1
            // 
            this.dist1.MyVal = 0;
            // 
            Control.CheckForIllegalCrossThreadCalls = false;
            // 
            // Event dispatching
            // 
            this.valueFormatter1.StringValueChanged += new WComp.BasicBeans.StringValueEventHandler(this.@__valueFormatter1_to_textBox1_0);
            this.valueFormatter2.StringValueChanged += new WComp.BasicBeans.StringValueEventHandler(this.@__valueFormatter2_to_textBox2_1);
            this.valueFormatter1.StringValueChanged += new WComp.BasicBeans.StringValueEventHandler(this.@__valueFormatter1_to_threshold1_2);
            this.threshold1.ThresholdReachedBool += new WComp.BasicBeans.BoolValueEventHandler(this.@__threshold1_to_genericOutput1_3);
            this.valueFormatter2.StringValueChanged += new WComp.BasicBeans.StringValueEventHandler(this.@__valueFormatter2_to_threshold2_4);
            this.thin_Force_Sensor1.ValeurChanged += new WComp.Phidgets.GenericSensor.IntValueEventHandler(this.force1.ForceToWeight);
            this.force1.PropertyChanged += new WComp.Beans.Force.IntValueEventHandler(this.valueFormatter1.Format);
            this.iR_Reflective_Sensor_10cm1.ValeurChanged += new WComp.Phidgets.GenericSensor.IntValueEventHandler(this.dist1.ValToDist);
            this.dist1.PropertyChanged += new WComp.Beans.Dist.IntValueEventHandler(this.valueFormatter2.Format);
            this.threshold2.ThresholdReachedBool += new WComp.BasicBeans.BoolValueEventHandler(this.@__threshold2_to_genericOutput2_5);
        }

		private void @__valueFormatter1_to_textBox1_0(string val) {
            this.textBox1.Text = val;
        }

		private void @__valueFormatter2_to_textBox2_1(string val) {
            this.textBox2.Text = val;
        }

		private void @__valueFormatter1_to_threshold1_2(string val) {
            this.threshold1.Value = val;
        }

		private void @__threshold1_to_genericOutput1_3(bool val) {
            this.genericOutput1.Value = val;
        }

		private void @__valueFormatter2_to_threshold2_4(string val) {
            this.threshold2.Value = val;
        }

		private void @__threshold2_to_genericOutput2_5(bool val) {
            this.genericOutput2.Value = val;
        }
		#endregion
	}
}
