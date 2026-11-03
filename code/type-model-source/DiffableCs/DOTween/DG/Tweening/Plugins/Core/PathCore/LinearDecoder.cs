namespace DG.Tweening.Plugins.Core.PathCore;

[Token(Token = "0x200009B")]
internal class LinearDecoder : ABSPathDecoder
{

	[Token(Token = "0x1700000D")]
	internal virtual int minInputWaypoints
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600038B")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000390")]
	public LinearDecoder() { }

	[Address(RVA = "0x66A330", Offset = "0x669730", Length = "0x64")]
	[Token(Token = "0x600038C")]
	internal virtual void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600038B")]
	internal virtual int get_minInputWaypoints() { }

	[Address(RVA = "0x66A3A0", Offset = "0x6697A0", Length = "0x1E2")]
	[Token(Token = "0x600038D")]
	internal virtual Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

	[Address(RVA = "0x66A590", Offset = "0x669990", Length = "0x320")]
	[Token(Token = "0x600038E")]
	internal void SetTimeToLengthTables(Path p, int subdivisions) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600038F")]
	internal void SetWaypointsLengths(Path p, int subdivisions) { }

}

