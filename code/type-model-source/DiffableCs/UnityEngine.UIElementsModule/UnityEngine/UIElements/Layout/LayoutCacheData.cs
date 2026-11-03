namespace UnityEngine.UIElements.Layout;

[NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutNative.h")]
[Token(Token = "0x20005FF")]
internal struct LayoutCacheData
{
	[Token(Token = "0x40015ED")]
	public static LayoutCacheData Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015EE")]
	public LayoutCachedMeasurement CachedLayout; //Field offset: 0x0

	[Address(RVA = "0x331C230", Offset = "0x331B630", Length = "0x7D")]
	[Token(Token = "0x6002B3D")]
	private static LayoutCacheData() { }

	[Address(RVA = "0x331BFD0", Offset = "0x331B3D0", Length = "0x92")]
	[Token(Token = "0x6002B3B")]
	public void ClearCachedMeasurements() { }

	[Address(RVA = "0x331C070", Offset = "0x331B470", Length = "0x33")]
	[Token(Token = "0x6002B3C")]
	private static void ClearCachedMeasurements(Void* LayoutCacheData) { }

	[Address(RVA = "0x331C0B0", Offset = "0x331B4B0", Length = "0x90")]
	[IsReadOnly]
	[Token(Token = "0x6002B3A")]
	public int MeasurementCacheCount() { }

	[Address(RVA = "0x331C140", Offset = "0x331B540", Length = "0xEE")]
	[IsReadOnly]
	[Token(Token = "0x6002B39")]
	public virtual string ToString() { }

}

