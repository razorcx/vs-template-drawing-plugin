using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Tekla.Structures.Plugins;
using Tekla.Structures.Drawing;
using Tekla.Structures.Drawing.Tools;
using Tekla.Structures.Drawing.UI;

namespace TeklaDrawingsPlugin
{
	public class PluginData
	{
		#region Fields
		//
		// Define the fields specified on the Form.
		//
		/* Some examples:
        [Tekla.Structures.Plugins.StructuresField("text")]
        public string Text;

        [Tekla.Structures.Plugins.StructuresField("color")]
        public int Color;

        [Tekla.Structures.Plugins.StructuresField("angle")]
        public double Angle;
        */
		#endregion
	}

	[Plugin("DrawingsPlugin")]
	[PluginUserInterface("DrawingsPlugin.MainForm")]
	public class TeklaDrawingsPlugin : DrawingPluginBase
	{
		#region Fields
		private PluginData data;
		//
		// Define variables for the field values.
		//
		#endregion

		#region Properties
		private PluginData Data
		{
			get { return data; }
			set { data = value; }
		}
		#endregion

		#region Constructor
		public TeklaDrawingsPlugin(PluginData data)
		{
			Data = data;
		}
		#endregion

		#region Overrides
		public override List<InputDefinition> DefineInput()
		{
			//
			// This is an example for selecting two points; change this to suit your needs.
			//
			List<InputDefinition> inputs = new List<InputDefinition>();
			DrawingHandler drawingHandler = new DrawingHandler();

			if (drawingHandler.GetConnectionStatus())
			{
				Picker picker = drawingHandler.GetPicker();

				ViewBase view = null;
				PointList points = new PointList();

				StringList prompts = new StringList();
				prompts.Add("Pick first point");
				prompts.Add("Pick second point");

				picker.PickPoints(2, prompts, out points, out view);
				inputs.Add(InputDefinitionFactory.CreateInputDefinition(view, points));
			}

			return inputs;
		}

		public override bool Run(List<InputDefinition> inputs)
		{
			try
			{
				//
				// This is an example for selecting two points; change this to suit your needs.
				//
				ViewBase view = InputDefinitionFactory.GetView(inputs[0]);
				PointList points = InputDefinitionFactory.GetPoints(inputs[0]);

				//
				// Write your code here; better yet, create private methods and call them from here.
				//
			}
			catch (Exception Exc)
			{
				MessageBox.Show(Exc.ToString());
			}

			return true;
		}
		#endregion

		#region Private methods
		//
		// Write your private methods here.
		//
		#endregion
	}
}
