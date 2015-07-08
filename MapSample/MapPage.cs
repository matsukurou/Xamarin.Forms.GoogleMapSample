using System;

using Xamarin.Forms;

using Xamarin.Forms.Maps;

namespace GoogleMapSample
{
	public class MapPage : ContentPage
	{
		public MapPage()
		{
			// マップの中心座標の設定(渋谷駅の緯度経度を設定してある)
			var centerPosition = new Position(35.658517, 139.701334);
			// 中心座標からの表示距離（マップの縮尺）を設定
			var distanceFromCenter = Distance.FromKilometers(0.5);

			// マップスパンの生成
			var mapSpan = MapSpan.FromCenterAndRadius(centerPosition, distanceFromCenter);

			// 設定した内容でマップを生成
			var map = new Map(mapSpan);

			Content = map;
		}
	}
}