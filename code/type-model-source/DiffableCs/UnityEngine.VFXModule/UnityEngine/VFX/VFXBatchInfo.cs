namespace UnityEngine.VFX;

[RequiredByNativeCode]
[Token(Token = "0x200000A")]
internal struct VFXBatchInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001A")]
	public uint capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001B")]
	public uint activeInstanceCount; //Field offset: 0x4

}

