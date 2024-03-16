using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Clinic
{

	public class MainWindowViewModel
	{
		public IRelayCommand CalculateCommand { get; }
		public MainWindowViewModel()
		{
			CalculateCommand = new RelayCommand(
				execute: () =>
					{
								
					},
				canExecute: () =>
				{
					return true;
				});
		}
	}
}
