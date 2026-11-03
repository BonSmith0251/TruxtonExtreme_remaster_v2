namespace DG.Tweening.Plugins.Core.PathCore;

[Token(Token = "0x200009A")]
internal class CatmullRomDecoder : ABSPathDecoder
{
	[Token(Token = "0x40001A2")]
	private static readonly ControlPoint[] _PartialControlPs; //Field offset: 0x0
	[Token(Token = "0x40001A3")]
	private static readonly Vector3[] _PartialWps; //Field offset: 0x8

	[Token(Token = "0x1700000C")]
	internal virtual int minInputWaypoints
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000384")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x665270", Offset = "0x664670", Length = "0xB1")]
	[Token(Token = "0x600038A")]
	private static CatmullRomDecoder() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000389")]
	public CatmullRomDecoder() { }

	[Address(RVA = "0x664270", Offset = "0x663670", Length = "0x34C")]
	[Token(Token = "0x6000385")]
	internal virtual void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000384")]
	internal virtual int get_minInputWaypoints() { }

	[Address(RVA = "0x6645C0", Offset = "0x6639C0", Length = "0x462")]
	[Token(Token = "0x6000386")]
	internal virtual Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

	[Address(RVA = "0x664A30", Offset = "0x663E30", Length = "0x321")]
	[Token(Token = "0x6000387")]
	internal void SetTimeToLengthTables(Path p, int subdivisions) { }

	[Address(RVA = "0x664D60", Offset = "0x664160", Length = "0x501")]
	[Token(Token = "0x6000388")]
	internal void SetWaypointsLengths(Path p, int subdivisions) { }

}

