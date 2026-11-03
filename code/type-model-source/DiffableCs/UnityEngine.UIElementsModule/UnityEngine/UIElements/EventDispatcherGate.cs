namespace UnityEngine.UIElements;

[Token(Token = "0x20001AD")]
public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E7")]
	private readonly EventDispatcher m_Dispatcher; //Field offset: 0x0

	[Address(RVA = "0x33CDA60", Offset = "0x33CCE60", Length = "0x78")]
	[Token(Token = "0x6000C5D")]
	public EventDispatcherGate(EventDispatcher d) { }

	[Address(RVA = "0x33CD9B0", Offset = "0x33CCDB0", Length = "0x1C")]
	[Token(Token = "0x6000C5E")]
	public override void Dispose() { }

	[Address(RVA = "0x32E7D60", Offset = "0x32E7160", Length = "0xD")]
	[Token(Token = "0x6000C5F")]
	public override bool Equals(EventDispatcherGate other) { }

	[Address(RVA = "0x33CD9D0", Offset = "0x33CCDD0", Length = "0x86")]
	[Token(Token = "0x6000C60")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x326C2F0", Offset = "0x326B6F0", Length = "0x2C")]
	[Token(Token = "0x6000C61")]
	public virtual int GetHashCode() { }

}

