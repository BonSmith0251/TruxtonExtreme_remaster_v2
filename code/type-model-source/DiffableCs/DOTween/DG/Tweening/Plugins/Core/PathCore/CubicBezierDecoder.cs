namespace DG.Tweening.Plugins.Core.PathCore;

[Token(Token = "0x2000097")]
internal class CubicBezierDecoder : ABSPathDecoder
{
	[Token(Token = "0x400019E")]
	private static readonly ControlPoint[] _PartialControlPs; //Field offset: 0x0
	[Token(Token = "0x400019F")]
	private static readonly Vector3[] _PartialWps; //Field offset: 0x8

	[Token(Token = "0x1700000A")]
	internal virtual int minInputWaypoints
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000376")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x666D10", Offset = "0x666110", Length = "0xB1")]
	[Token(Token = "0x600037C")]
	private static CubicBezierDecoder() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600037B")]
	public CubicBezierDecoder() { }

	[Address(RVA = "0x665D30", Offset = "0x665130", Length = "0x5F2")]
	[Token(Token = "0x6000377")]
	internal virtual void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000376")]
	internal virtual int get_minInputWaypoints() { }

	[Address(RVA = "0x666330", Offset = "0x665730", Length = "0x25B")]
	[Token(Token = "0x6000378")]
	internal virtual Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

	[Address(RVA = "0x666590", Offset = "0x665990", Length = "0x321")]
	[Token(Token = "0x6000379")]
	internal void SetTimeToLengthTables(Path p, int subdivisions) { }

	[Address(RVA = "0x6668C0", Offset = "0x665CC0", Length = "0x444")]
	[Token(Token = "0x600037A")]
	internal void SetWaypointsLengths(Path p, int subdivisions) { }

}

