namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000F0")]
public struct XRFeatureDescriptor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005A4")]
	public string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005A5")]
	public List<UsageHint> usageHints; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A6")]
	public FeatureType featureType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40005A7")]
	public uint customSize; //Field offset: 0x14

}

