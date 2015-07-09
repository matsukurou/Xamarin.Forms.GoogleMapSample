using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace GoogleMapSample
{
	public class CustomMap : Xamarin.Forms.Maps.Map
	{
		/// <summary>
		/// 最初のMapの中心座標
		/// </summary>
		public Position firstPosition;

		public CustomMap(MapSpan mapspan) : base (mapspan)
		{
			// 中心位置を保管
			firstPosition = mapspan.Center;
		}
	}
}


