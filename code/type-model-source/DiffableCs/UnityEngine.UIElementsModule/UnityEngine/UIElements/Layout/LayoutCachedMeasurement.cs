namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000600")]
internal struct LayoutCachedMeasurement
{
	[Token(Token = "0x40015EF")]
	public static LayoutCachedMeasurement Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015F0")]
	public float AvailableWidth; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40015F1")]
	public float AvailableHeight; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40015F2")]
	public float ParentWidth; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40015F3")]
	public float ParentHeight; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015F4")]
	public LayoutMeasureMode WidthMeasureMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40015F5")]
	public LayoutMeasureMode HeightMeasureMode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40015F6")]
	public float ComputedWidth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40015F7")]
	public float ComputedHeight; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40015F8")]
	private Void* m_NextMeasurementCachePtr; //Field offset: 0x20

	[Token(Token = "0x17000AE2")]
	public LayoutCachedMeasurement* NextMeasurementCache
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6002B3E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x331C660", Offset = "0x331BA60", Length = "0x6F")]
	[Token(Token = "0x6002B40")]
	private static LayoutCachedMeasurement() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6002B3E")]
	public LayoutCachedMeasurement* get_NextMeasurementCache() { }

	[Address(RVA = "0x331C2B0", Offset = "0x331B6B0", Length = "0x3A8")]
	[IsReadOnly]
	[Token(Token = "0x6002B3F")]
	public virtual string ToString() { }

}

