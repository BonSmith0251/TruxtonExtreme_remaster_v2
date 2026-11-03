namespace UnityEngine.XR;

[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
[Token(Token = "0x200001B")]
[UsedByNativeCode]
public struct MeshId : IEquatable<MeshId>
{
	[Token(Token = "0x4000082")]
	private static MeshId s_InvalidId; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000083")]
	private ulong m_SubId1; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000084")]
	private ulong m_SubId2; //Field offset: 0x8

	[Address(RVA = "0x34925A0", Offset = "0x34919A0", Length = "0x39")]
	[Token(Token = "0x600005C")]
	private static MeshId() { }

	[Address(RVA = "0x3492470", Offset = "0x3491870", Length = "0xA7")]
	[Token(Token = "0x600005A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3049AB0", Offset = "0x3048EB0", Length = "0x1D")]
	[Token(Token = "0x600005B")]
	public override bool Equals(MeshId other) { }

	[Address(RVA = "0x3049470", Offset = "0x3048870", Length = "0x2E")]
	[Token(Token = "0x6000059")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3492520", Offset = "0x3491920", Length = "0x7C")]
	[Token(Token = "0x6000058")]
	public virtual string ToString() { }

}

