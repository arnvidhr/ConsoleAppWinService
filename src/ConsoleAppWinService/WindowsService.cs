using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWinService
{
	partial class WindowsService : ServiceBase
	{
		#region Attributes

		#endregion

		#region Properties

		#endregion

		#region Ctor

		public WindowsService()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods
		internal void Start(string[] args)
		{
			OnStart(args);
		}

		protected override void OnStart(string[] args)
		{
		}

		protected override void OnStop()
		{
		}

		#endregion
	}
}
