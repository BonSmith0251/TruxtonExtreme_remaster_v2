namespace UnityEngine.VFX;

[Token(Token = "0x2000017")]
internal abstract class EventAttributeValue : EventAttribute
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004C")]
	private readonly Func<VFXEventAttribute, Int32, Boolean> m_HasFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004D")]
	private readonly Action<VFXEventAttribute, Int32, T> m_ApplyFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004E")]
	public T value; //Field offset: 0x0

	[Address(RVA = "0x1BAB0A0", Offset = "0x1BAA4A0", Length = "0x4E")]
	[Token(Token = "0x600002D")]
	protected EventAttributeValue`1(Func<VFXEventAttribute, Int32, Boolean> hasFunc, Action<VFXEventAttribute, Int32, T> applyFunc) { }

	[Address(RVA = "0x1BAACE0", Offset = "0x1BAA0E0", Length = "0x9E")]
	[Token(Token = "0x600002E")]
	public virtual bool ApplyToVFX(VFXEventAttribute eventAttribute) { }

}

