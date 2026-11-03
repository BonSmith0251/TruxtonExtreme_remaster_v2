namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200003E")]
internal class LightBuffer
{
	[Token(Token = "0x4000135")]
	internal static readonly int kMax; //Field offset: 0x0
	[Token(Token = "0x4000136")]
	internal static readonly int kCount; //Field offset: 0x4
	[Token(Token = "0x4000137")]
	internal static readonly int kLightMod; //Field offset: 0x8
	[Token(Token = "0x4000138")]
	internal static readonly int kBatchMax; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000139")]
	private GraphicsBuffer m_GraphicsBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400013A")]
	private NativeArray<Int32> m_Markers; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400013B")]
	private NativeArray<PerLight2D> m_NativeBuffer; //Field offset: 0x28

	[Token(Token = "0x17000046")]
	internal GraphicsBuffer graphicsBuffer
	{
		[Address(RVA = "0x2D27B10", Offset = "0x2D26F10", Length = "0xC8")]
		[Token(Token = "0x6000184")]
		internal get { } //Length: 200
	}

	[Token(Token = "0x17000047")]
	internal NativeArray<Int32> lightMarkers
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x6000185")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000048")]
	internal NativeArray<PerLight2D> nativeBuffer
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x6000186")]
		internal get { } //Length: 11
	}

	[Address(RVA = "0x2D279A0", Offset = "0x2D26DA0", Length = "0x78")]
	[Token(Token = "0x600018A")]
	private static LightBuffer() { }

	[Address(RVA = "0x2D27A20", Offset = "0x2D26E20", Length = "0xEC")]
	[Token(Token = "0x6000189")]
	public LightBuffer() { }

	[Address(RVA = "0x2D27B10", Offset = "0x2D26F10", Length = "0xC8")]
	[Token(Token = "0x6000184")]
	internal GraphicsBuffer get_graphicsBuffer() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[Token(Token = "0x6000185")]
	internal NativeArray<Int32> get_lightMarkers() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x6000186")]
	internal NativeArray<PerLight2D> get_nativeBuffer() { }

	[Address(RVA = "0x2D27860", Offset = "0x2D26C60", Length = "0x36")]
	[Token(Token = "0x6000187")]
	internal void Release() { }

	[Address(RVA = "0x2D278A0", Offset = "0x2D26CA0", Length = "0xF2")]
	[Token(Token = "0x6000188")]
	internal void Reset() { }

}

