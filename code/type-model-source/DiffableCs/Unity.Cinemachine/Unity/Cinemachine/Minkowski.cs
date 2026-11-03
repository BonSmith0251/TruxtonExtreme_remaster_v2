namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000189")]
internal class Minkowski
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600082C")]
	public Minkowski() { }

	[Address(RVA = "0x28A4410", Offset = "0x28A3810", Length = "0x87")]
	[Token(Token = "0x600082A")]
	public static List<List`1<Point64>> Diff(List<Point64> pattern, List<Point64> path, bool isClosed) { }

	[Address(RVA = "0x28A4300", Offset = "0x28A3700", Length = "0x10D")]
	[Token(Token = "0x600082B")]
	public static List<List`1<PointD>> Diff(List<PointD> pattern, List<PointD> path, bool isClosed, int decimalPlaces = 2) { }

	[Address(RVA = "0x28A44A0", Offset = "0x28A38A0", Length = "0x959")]
	[Token(Token = "0x6000827")]
	private static List<List`1<Point64>> MinkowskiInternal(List<Point64> pattern, List<Point64> path, bool isSum, bool isClosed) { }

	[Address(RVA = "0x28A4E00", Offset = "0x28A4200", Length = "0x87")]
	[Token(Token = "0x6000828")]
	public static List<List`1<Point64>> Sum(List<Point64> pattern, List<Point64> path, bool isClosed) { }

	[Address(RVA = "0x28A4E90", Offset = "0x28A4290", Length = "0x10D")]
	[Token(Token = "0x6000829")]
	public static List<List`1<PointD>> Sum(List<PointD> pattern, List<PointD> path, bool isClosed, int decimalPlaces = 2) { }

}

