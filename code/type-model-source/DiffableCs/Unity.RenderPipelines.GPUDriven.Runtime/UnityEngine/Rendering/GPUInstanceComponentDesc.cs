namespace UnityEngine.Rendering;

[Token(Token = "0x2000067")]
internal struct GPUInstanceComponentDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001B7")]
	public int propertyID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001B8")]
	public int byteSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001B9")]
	public bool isOverriden; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x40001BA")]
	public bool isPerInstance; //Field offset: 0x9
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001BB")]
	public InstanceType instanceType; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BC")]
	public InstanceComponentGroup componentGroup; //Field offset: 0x10

	[Address(RVA = "0x2CDFC40", Offset = "0x2CDF040", Length = "0x21")]
	[Token(Token = "0x60001BD")]
	public GPUInstanceComponentDesc(int inPropertyID, int inByteSize, bool inIsOverriden, bool inPerInstance, InstanceType inInstanceType, InstanceComponentGroup inComponentType) { }

}

