namespace DG.Tweening.Plugins.Core.PathCore;

[Token(Token = "0x2000099")]
internal abstract class ABSPathDecoder
{

	[Token(Token = "0x1700000B")]
	internal abstract int minInputWaypoints
	{
		[Token(Token = "0x6000382")]
		internal get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000383")]
	protected ABSPathDecoder() { }

	[Token(Token = "0x6000380")]
	internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) { }

	[Token(Token = "0x6000382")]
	internal abstract int get_minInputWaypoints() { }

	[Token(Token = "0x6000381")]
	internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) { }

}

