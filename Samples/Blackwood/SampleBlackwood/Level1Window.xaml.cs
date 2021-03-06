﻿#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: SampleBlackwood.SampleBlackwoodPublic
File: Level1Window.xaml.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp, LLC
*******************************************************************************************/
#endregion S# License
namespace SampleBlackwood
{
	using System.Linq;
	using System.Windows;

	using MoreLinq;

	public partial class Level1Window
	{
		public Level1Window()
		{
			InitializeComponent();

			Level1Grid.Columns[0].Visibility = Visibility.Visible;
			Level1Grid.Columns[1].Visibility = Visibility.Visible;

			Level1Grid.Columns[3].Visibility = Visibility.Collapsed;
			Level1Grid.Columns[4].Visibility = Visibility.Collapsed;

			Level1Grid.Columns.Skip(11).ForEach(c => c.Visibility = Visibility.Collapsed);
		}
	}
}