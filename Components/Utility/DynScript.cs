using System;
using BaseX;
using FrooxEngine.LogiX;
using FrooxEngine.UIX;
using Jint;
namespace FrooxEngine
{
	//very experiemental 
	[Category("Data/Dynamic")]
	public class DynScript : Component
	{
		public readonly Sync<string> code;

		[ImpulseTarget]
		public void execute()
		{
			var engine = new Jint.Engine();
			engine.Execute(code.Value);
			engine.Invoke("update");
		}
	}
}
