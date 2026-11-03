namespace UnityEngine;

[NativeClass("TransformHandle")]
[Token(Token = "0x20001FF")]
[UsedByNativeCode]
public struct TransformHandle : IEquatable<TransformHandle>, IComparable<TransformHandle>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000732")]
	internal IntPtr pTransformData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000733")]
	internal EntityId id; //Field offset: 0x8

	[Address(RVA = "0x308D560", Offset = "0x308C960", Length = "0xF")]
	[Token(Token = "0x6001705")]
	public override int CompareTo(TransformHandle other) { }

	[Address(RVA = "0x308D580", Offset = "0x308C980", Length = "0x8E")]
	[Token(Token = "0x6001703")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x308D570", Offset = "0x308C970", Length = "0xE")]
	[Token(Token = "0x6001704")]
	public override bool Equals(TransformHandle other) { }

	[Address(RVA = "0x308D610", Offset = "0x308CA10", Length = "0xD")]
	[Token(Token = "0x6001706")]
	public virtual int GetHashCode() { }

}

