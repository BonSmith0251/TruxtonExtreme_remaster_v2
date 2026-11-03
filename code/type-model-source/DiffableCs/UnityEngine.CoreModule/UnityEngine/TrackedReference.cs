namespace UnityEngine;

[Token(Token = "0x20001C8")]
[UsedByNativeCode]
public class TrackedReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000695")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AnimationModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001423")]
	protected TrackedReference() { }

	[Address(RVA = "0x3073180", Offset = "0x3072580", Length = "0xC3")]
	[Token(Token = "0x6001425")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x3073250", Offset = "0x3072650", Length = "0xD")]
	[Token(Token = "0x6001426")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3073260", Offset = "0x3072660", Length = "0x43")]
	[Token(Token = "0x6001424")]
	public static bool op_Equality(TrackedReference x, TrackedReference y) { }

}

