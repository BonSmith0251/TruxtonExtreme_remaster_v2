namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000601")]
internal struct LayoutComputedData
{
	[CompilerGenerated]
	[Token(Token = "0x2000602")]
	[UnsafeValueType]
	internal struct <Border>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001606")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000603")]
	[UnsafeValueType]
	internal struct <Dimensions>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001607")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000604")]
	[UnsafeValueType]
	internal struct <Margin>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001608")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000605")]
	[UnsafeValueType]
	internal struct <MeasuredDimensions>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001609")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000606")]
	[UnsafeValueType]
	internal struct <Padding>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400160A")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000607")]
	[UnsafeValueType]
	internal struct <Position>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400160B")]
		public float FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(float), 4)]
	[Token(Token = "0x40015F9")]
	public <Position>e__FixedBuffer Position; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FixedBuffer(typeof(float), 2)]
	[Token(Token = "0x40015FA")]
	public <Dimensions>e__FixedBuffer Dimensions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FixedBuffer(typeof(float), 6)]
	[Token(Token = "0x40015FB")]
	public <Margin>e__FixedBuffer Margin; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[FixedBuffer(typeof(float), 6)]
	[Token(Token = "0x40015FC")]
	public <Border>e__FixedBuffer Border; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[FixedBuffer(typeof(float), 6)]
	[Token(Token = "0x40015FD")]
	public <Padding>e__FixedBuffer Padding; //Field offset: 0x48
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40015FE")]
	public LayoutDirection Direction; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40015FF")]
	public uint ComputedFlexBasisGeneration; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001600")]
	public float ComputedFlexBasis; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001601")]
	public bool HadOverflow; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001602")]
	public uint GenerationCount; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4001603")]
	public LayoutDirection LastParentDirection; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001604")]
	public float LastPointScaleFactor; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[FixedBuffer(typeof(float), 2)]
	[Token(Token = "0x4001605")]
	public <MeasuredDimensions>e__FixedBuffer MeasuredDimensions; //Field offset: 0x7C

	[Token(Token = "0x17000AE5")]
	public Single* BorderBuffer
	{
		[Address(RVA = "0x331C6D0", Offset = "0x331BAD0", Length = "0x7")]
		[Token(Token = "0x6002B43")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000AE3")]
	public static LayoutComputedData Default
	{
		[Address(RVA = "0x331C6E0", Offset = "0x331BAE0", Length = "0x1AD")]
		[Token(Token = "0x6002B41")]
		 get { } //Length: 429
	}

	[Token(Token = "0x17000AE4")]
	public Single* MarginBuffer
	{
		[Address(RVA = "0x3313B30", Offset = "0x3312F30", Length = "0x7")]
		[Token(Token = "0x6002B42")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000AE6")]
	public Single* PaddingBuffer
	{
		[Address(RVA = "0x331C890", Offset = "0x331BC90", Length = "0x7")]
		[Token(Token = "0x6002B44")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x331C6D0", Offset = "0x331BAD0", Length = "0x7")]
	[Token(Token = "0x6002B43")]
	public Single* get_BorderBuffer() { }

	[Address(RVA = "0x331C6E0", Offset = "0x331BAE0", Length = "0x1AD")]
	[Token(Token = "0x6002B41")]
	public static LayoutComputedData get_Default() { }

	[Address(RVA = "0x3313B30", Offset = "0x3312F30", Length = "0x7")]
	[Token(Token = "0x6002B42")]
	public Single* get_MarginBuffer() { }

	[Address(RVA = "0x331C890", Offset = "0x331BC90", Length = "0x7")]
	[Token(Token = "0x6002B44")]
	public Single* get_PaddingBuffer() { }

}

