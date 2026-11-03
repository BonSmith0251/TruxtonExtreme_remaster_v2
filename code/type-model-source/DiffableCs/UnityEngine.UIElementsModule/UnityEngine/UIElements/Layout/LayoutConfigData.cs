namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000608")]
internal struct LayoutConfigData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400160C")]
	public float PointScaleFactor; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400160D")]
	public int ManagedMeasureFunctionIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400160E")]
	public int ManagedBaselineFunctionIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400160F")]
	public bool ShouldLog; //Field offset: 0xC

	[Token(Token = "0x17000AE7")]
	public static LayoutConfigData Default
	{
		[Address(RVA = "0x331C8A0", Offset = "0x331BCA0", Length = "0x10")]
		[Token(Token = "0x6002B45")]
		 get { } //Length: 16
	}

	[Address(RVA = "0x331C8A0", Offset = "0x331BCA0", Length = "0x10")]
	[Token(Token = "0x6002B45")]
	public static LayoutConfigData get_Default() { }

}

