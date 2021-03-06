#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.SmartCom.Xaml.SmartCom
File: SmartComEndPointEditor.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.SmartCom.Xaml
{
	using System.Windows;
	using System.Windows.Controls;
	using System.Windows.Data;

	using Ecng.Xaml;

	using StockSharp.SmartCom;

	using Xceed.Wpf.Toolkit.PropertyGrid;
	using Xceed.Wpf.Toolkit.PropertyGrid.Editors;

	/// <summary>
	/// ���������� ������ ��� ������ ������ ������� SmartCOM.
	/// </summary>
	public class SmartComEndPointEditor : ITypeEditor
	{
		FrameworkElement ITypeEditor.ResolveEditor(PropertyItem propertyItem)
		{
			var comboBox = new SmartComAddressComboBox { IsEditable = true, Width = double.NaN };

			var binding = new Binding("Value")
			{
				Source = propertyItem,
				Converter = new EndPointValueConverter(comboBox, SmartComAddresses.Matrix),
				Mode = propertyItem.IsReadOnly ? BindingMode.OneWay : BindingMode.TwoWay
			};

			BindingOperations.SetBinding(comboBox, ComboBox.TextProperty, binding);
			return comboBox;
		}
	}
}