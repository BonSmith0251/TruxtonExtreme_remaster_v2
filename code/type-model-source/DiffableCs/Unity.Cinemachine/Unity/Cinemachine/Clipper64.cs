namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000180")]
internal class Clipper64 : ClipperBase
{

	[Address(RVA = "0x289F0C0", Offset = "0x289E4C0", Length = "0x7")]
	[Token(Token = "0x60007F1")]
	public Clipper64() { }

	[Address(RVA = "0x289ECD0", Offset = "0x289E0D0", Length = "0x20")]
	[Token(Token = "0x60007F6")]
	public void AddClip(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x289ECF0", Offset = "0x289E0F0", Length = "0x1D")]
	[Token(Token = "0x60007F5")]
	public void AddOpenSubject(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x289ED10", Offset = "0x289E110", Length = "0xE")]
	[Token(Token = "0x60007F2")]
	internal void AddPath(List<Point64> path, PathType polytype, bool isOpen = false) { }

	[Address(RVA = "0x289ED20", Offset = "0x289E120", Length = "0xE")]
	[Token(Token = "0x60007F3")]
	internal void AddPaths(List<List`1<Point64>> paths, PathType polytype, bool isOpen = false) { }

	[Address(RVA = "0x289ED30", Offset = "0x289E130", Length = "0x1D")]
	[Token(Token = "0x60007F4")]
	public void AddSubject(List<List`1<Point64>> paths) { }

	[Address(RVA = "0x289EFD0", Offset = "0x289E3D0", Length = "0xEB")]
	[Token(Token = "0x60007F7")]
	public bool Execute(ClipType clipType, FillRule fillRule, List<List`1<Point64>> solutionClosed, List<List`1<Point64>> solutionOpen) { }

	[Address(RVA = "0x289EE00", Offset = "0x289E200", Length = "0xA4")]
	[Token(Token = "0x60007F8")]
	public bool Execute(ClipType clipType, FillRule fillRule, List<List`1<Point64>> solutionClosed) { }

	[Address(RVA = "0x289EEB0", Offset = "0x289E2B0", Length = "0x117")]
	[Token(Token = "0x60007F9")]
	public bool Execute(ClipType clipType, FillRule fillRule, PolyTree64 polytree, List<List`1<Point64>> openPaths) { }

	[Address(RVA = "0x289ED50", Offset = "0x289E150", Length = "0xA4")]
	[Token(Token = "0x60007FA")]
	public bool Execute(ClipType clipType, FillRule fillRule, PolyTree64 polytree) { }

}

