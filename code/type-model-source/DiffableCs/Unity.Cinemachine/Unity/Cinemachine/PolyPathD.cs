namespace Unity.Cinemachine;

[DefaultMember("Child")]
[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000185")]
internal class PolyPathD : PolyPathBase
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000684")]
	private double <Scale>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000685")]
	private List<PointD> <Polygon>k__BackingField; //Field offset: 0x28

	[Nullable(1)]
	[Token(Token = "0x17000158")]
	public PolyPathD Child
	{
		[Address(RVA = "0x28A5AD0", Offset = "0x28A4ED0", Length = "0xF2")]
		[NullableContext(1)]
		[Token(Token = "0x6000821")]
		 get { } //Length: 242
	}

	[Token(Token = "0x17000157")]
	public private List<PointD> Polygon
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600081D")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600081E")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000156")]
	internal double Scale
	{
		[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600081B")]
		internal get { } //Length: 6
		[Address(RVA = "0x28A5BD0", Offset = "0x28A4FD0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600081C")]
		internal set { } //Length: 6
	}

	[Address(RVA = "0x28A5410", Offset = "0x28A4810", Length = "0x8")]
	[Token(Token = "0x600081F")]
	public PolyPathD(PolyPathBase parent = null) { }

	[Address(RVA = "0x28A56F0", Offset = "0x28A4AF0", Length = "0x1F3")]
	[NullableContext(1)]
	[Token(Token = "0x6000820")]
	internal virtual PolyPathBase AddChild(List<Point64> p) { }

	[Address(RVA = "0x28A58F0", Offset = "0x28A4CF0", Length = "0x1D5")]
	[Token(Token = "0x6000822")]
	public double Area() { }

	[Address(RVA = "0x28A5AD0", Offset = "0x28A4ED0", Length = "0xF2")]
	[NullableContext(1)]
	[Token(Token = "0x6000821")]
	public PolyPathD get_Child(int index) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600081D")]
	public List<PointD> get_Polygon() { }

	[Address(RVA = "0x1CC53C0", Offset = "0x1CC47C0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600081B")]
	internal double get_Scale() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600081E")]
	private void set_Polygon(List<PointD> value) { }

	[Address(RVA = "0x28A5BD0", Offset = "0x28A4FD0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600081C")]
	internal void set_Scale(double value) { }

}

