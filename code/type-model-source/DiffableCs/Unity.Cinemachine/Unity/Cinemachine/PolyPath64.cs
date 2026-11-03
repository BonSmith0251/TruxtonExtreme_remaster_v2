namespace Unity.Cinemachine;

[DefaultMember("Child")]
[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000184")]
internal class PolyPath64 : PolyPathBase
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000683")]
	private List<Point64> <Polygon>k__BackingField; //Field offset: 0x20

	[Nullable(1)]
	[Token(Token = "0x17000155")]
	public PolyPath64 Child
	{
		[Address(RVA = "0x28A5420", Offset = "0x28A4820", Length = "0xF2")]
		[NullableContext(1)]
		[Token(Token = "0x6000819")]
		 get { } //Length: 242
	}

	[Token(Token = "0x17000154")]
	public private List<Point64> Polygon
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000815")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000816")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x28A5410", Offset = "0x28A4810", Length = "0x8")]
	[Token(Token = "0x6000817")]
	public PolyPath64(PolyPathBase parent = null) { }

	[Address(RVA = "0x28A50D0", Offset = "0x28A44D0", Length = "0x15B")]
	[NullableContext(1)]
	[Token(Token = "0x6000818")]
	internal virtual PolyPathBase AddChild(List<Point64> p) { }

	[Address(RVA = "0x28A5230", Offset = "0x28A4630", Length = "0x1D5")]
	[Token(Token = "0x600081A")]
	public double Area() { }

	[Address(RVA = "0x28A5420", Offset = "0x28A4820", Length = "0xF2")]
	[NullableContext(1)]
	[Token(Token = "0x6000819")]
	public PolyPath64 get_Child(int index) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000815")]
	public List<Point64> get_Polygon() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000816")]
	private void set_Polygon(List<Point64> value) { }

}

