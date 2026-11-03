namespace UnityEngine;

[Token(Token = "0x2000134")]
[UsedByNativeCode]
public struct MeshLodRange
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40003FC")]
	private uint m_IndexStart; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40003FD")]
	private uint m_IndexCount; //Field offset: 0x4

	[Address(RVA = "0x30221B0", Offset = "0x30215B0", Length = "0x7B")]
	[Token(Token = "0x6000D5E")]
	public virtual string ToString() { }

}

