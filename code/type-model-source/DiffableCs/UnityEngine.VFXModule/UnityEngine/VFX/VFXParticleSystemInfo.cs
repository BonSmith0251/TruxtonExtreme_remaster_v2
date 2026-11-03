namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/Systems/VFXParticleSystem.h")]
[Token(Token = "0x2000017")]
[UsedByNativeCode]
public struct VFXParticleSystemInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000033")]
	public uint aliveCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000034")]
	public uint capacity; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000035")]
	public bool sleeping; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000036")]
	public Bounds bounds; //Field offset: 0xC

}

