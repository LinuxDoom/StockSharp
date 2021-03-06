#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.OpenECry.OpenECry
File: OpenECryException.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.OpenECry
{
	using System;

	/// <summary>
	/// The exception generated by the implementation of <see cref="OECTrader"/> in case of errors.
	/// </summary>
	public sealed class OpenECryException : ApplicationException
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenECryException"/>.
		/// </summary>
		/// <param name="msg">Message text.</param>
		/// <param name="inner">The internal exception.</param>
		internal OpenECryException(string msg, Exception inner = null)
			: base(msg, inner)
		{
		}
	}
}