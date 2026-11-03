namespace UnityEngine.Rendering;

[Token(Token = "0x20003C6")]
public struct SubPassDescriptor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C0A")]
	public AttachmentIndexArray inputs; //Field offset: 0x0
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000C0B")]
	public AttachmentIndexArray colorOutputs; //Field offset: 0x24
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C0C")]
	public SubPassFlags flags; //Field offset: 0x48

}

