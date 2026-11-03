namespace DG.Tweening;

[Token(Token = "0x2000008")]
public static class DOCurve
{
	[Token(Token = "0x2000009")]
	internal static class CubicBezier
	{

		[Address(RVA = "0x649110", Offset = "0x648510", Length = "0x160")]
		[Token(Token = "0x6000011")]
		public static Vector3 GetPointOnSegment(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, float factor) { }

		[Address(RVA = "0x649270", Offset = "0x648670", Length = "0x2C8")]
		[Token(Token = "0x6000012")]
		public static Vector3[] GetSegmentPointCloud(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10) { }

		[Address(RVA = "0x649540", Offset = "0x648940", Length = "0x308")]
		[Token(Token = "0x6000013")]
		public static void GetSegmentPointCloud(List<Vector3> addToList, Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10) { }

	}


}

