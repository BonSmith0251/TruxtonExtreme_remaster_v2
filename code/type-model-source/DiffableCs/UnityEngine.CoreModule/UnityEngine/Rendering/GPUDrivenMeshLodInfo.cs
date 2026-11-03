namespace UnityEngine.Rendering;

[Token(Token = "0x20003BE")]
[UsedByNativeCode]
internal struct GPUDrivenMeshLodInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BBF")]
	public int levelCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000BC0")]
	public float lodSlope; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BC1")]
	public float lodBias; //Field offset: 0x8

	[Token(Token = "0x170003F8")]
	public bool lodSelectionActive
	{
		[Address(RVA = "0x30B3A50", Offset = "0x30B2E50", Length = "0x7")]
		[Token(Token = "0x6001D37")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x30B3A50", Offset = "0x30B2E50", Length = "0x7")]
	[Token(Token = "0x6001D37")]
	public bool get_lodSelectionActive() { }

}

