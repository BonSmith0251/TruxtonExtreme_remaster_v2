namespace System;

[Token(Token = "0x20001E0")]
public sealed class WeakReference : ISerializable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000936")]
	private GCHandle handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000937")]
	private bool trackResurrection; //Field offset: 0x0

	[Address(RVA = "0x141A220", Offset = "0x1419620", Length = "0x37")]
	[Token(Token = "0x60010CF")]
	public WeakReference`1(T target) { }

	[Address(RVA = "0x141A260", Offset = "0x1419660", Length = "0x44")]
	[Token(Token = "0x60010D0")]
	public WeakReference`1(T target, bool trackResurrection) { }

	[Address(RVA = "0x141A100", Offset = "0x1419500", Length = "0x118")]
	[Token(Token = "0x60010D1")]
	private WeakReference`1(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1419E10", Offset = "0x1419210", Length = "0x70")]
	[Token(Token = "0x60010D5")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1419E90", Offset = "0x1419290", Length = "0xF1")]
	[Token(Token = "0x60010D2")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1419F90", Offset = "0x1419390", Length = "0x5F")]
	[Token(Token = "0x60010D3")]
	public void SetTarget(T target) { }

	[Address(RVA = "0x1419FF0", Offset = "0x14193F0", Length = "0x10C")]
	[Token(Token = "0x60010D4")]
	public bool TryGetTarget(out T target) { }

}

