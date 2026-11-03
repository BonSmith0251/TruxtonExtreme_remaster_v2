namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000181")]
internal class ClipperD : ClipperBase
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400067D")]
	private readonly double _scale; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400067E")]
	private readonly double _invScale; //Field offset: 0x80

	[Address(RVA = "0x289FC30", Offset = "0x289F030", Length = "0xD6")]
	[Token(Token = "0x60007FB")]
	public ClipperD(int roundingDecimalPrecision = 2) { }

	[Address(RVA = "0x289F0F0", Offset = "0x289E4F0", Length = "0x20")]
	[Token(Token = "0x6000800")]
	public void AddClip(List<PointD> path) { }

	[Address(RVA = "0x289F0D0", Offset = "0x289E4D0", Length = "0x20")]
	[Token(Token = "0x6000803")]
	public void AddClip(List<List`1<PointD>> paths) { }

	[Address(RVA = "0x289F130", Offset = "0x289E530", Length = "0x1D")]
	[Token(Token = "0x60007FF")]
	public void AddOpenSubject(List<PointD> path) { }

	[Address(RVA = "0x289F110", Offset = "0x289E510", Length = "0x1D")]
	[Token(Token = "0x6000802")]
	public void AddOpenSubject(List<List`1<PointD>> paths) { }

	[Address(RVA = "0x289F150", Offset = "0x289E550", Length = "0x9E")]
	[Token(Token = "0x60007FC")]
	public void AddPath(List<PointD> path, PathType polytype, bool isOpen = false) { }

	[Address(RVA = "0x289F1F0", Offset = "0x289E5F0", Length = "0x9E")]
	[Token(Token = "0x60007FD")]
	public void AddPaths(List<List`1<PointD>> paths, PathType polytype, bool isOpen = false) { }

	[Address(RVA = "0x289F2B0", Offset = "0x289E6B0", Length = "0x1D")]
	[Token(Token = "0x60007FE")]
	public void AddSubject(List<PointD> path) { }

	[Address(RVA = "0x289F290", Offset = "0x289E690", Length = "0x1D")]
	[Token(Token = "0x6000801")]
	public void AddSubject(List<List`1<PointD>> paths) { }

	[Address(RVA = "0x289F430", Offset = "0x289E830", Length = "0x49D")]
	[Token(Token = "0x6000804")]
	public bool Execute(ClipType clipType, FillRule fillRule, List<List`1<PointD>> solutionClosed, List<List`1<PointD>> solutionOpen) { }

	[Address(RVA = "0x289F380", Offset = "0x289E780", Length = "0xA4")]
	[Token(Token = "0x6000805")]
	public bool Execute(ClipType clipType, FillRule fillRule, List<List`1<PointD>> solutionClosed) { }

	[Address(RVA = "0x289F8D0", Offset = "0x289ECD0", Length = "0x350")]
	[Token(Token = "0x6000806")]
	public bool Execute(ClipType clipType, FillRule fillRule, PolyTreeD polytree, List<List`1<PointD>> openPaths) { }

	[Address(RVA = "0x289F2D0", Offset = "0x289E6D0", Length = "0xA4")]
	[Token(Token = "0x6000807")]
	public bool Execute(ClipType clipType, FillRule fillRule, PolyTreeD polytree) { }

}

