namespace InGame.Kernel.Timeline;

[Token(Token = "0x2000105")]
public class TweenUtilty
{

	[Address(RVA = "0x1D540B0", Offset = "0x1D534B0", Length = "0x23")]
	[Token(Token = "0x6000814")]
	private static AxisConstraint _getAxisRot(int v) { }

	[Address(RVA = "0x1D540E0", Offset = "0x1D534E0", Length = "0xD")]
	[Token(Token = "0x6000815")]
	private static PathMode _getPathMode(int n) { }

	[Address(RVA = "0x1D540F0", Offset = "0x1D534F0", Length = "0x15")]
	[Token(Token = "0x6000813")]
	private static PathType _getPathType(int n) { }

	[Address(RVA = "0x1D54110", Offset = "0x1D53510", Length = "0x300")]
	[Token(Token = "0x6000810")]
	private static Tween _setupPath(TweenerCore<Vector3, Path, PathOptions> dopath, int lookAtType) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000816")]
	public TweenUtilty() { }

	[Address(RVA = "0x1D53C20", Offset = "0x1D53020", Length = "0xF9")]
	[Token(Token = "0x600080E")]
	public static Tween CreateLocalPath(Transform t, Vector3[] poss, RouteData rd) { }

	[Address(RVA = "0x1D53D20", Offset = "0x1D53120", Length = "0x129")]
	[Token(Token = "0x600080D")]
	public static Sequence CreateMove(Transform t, Vector3 targetWorld, float duration, bool isLookAt = false) { }

	[Address(RVA = "0x1D53E50", Offset = "0x1D53250", Length = "0x157")]
	[Token(Token = "0x6000811")]
	public static Sequence CreateMove(Transform t, Vector3[] poss, float duration, int pathtype, int lookAtType, Ease _easeType) { }

	[Address(RVA = "0x1D53FB0", Offset = "0x1D533B0", Length = "0xF9")]
	[Token(Token = "0x600080F")]
	public static Tween CreatePath(Transform t, Vector3[] poss, RouteData rd) { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x6000812")]
	public static double GetDistance(Tween tw, Transform tr) { }

}

