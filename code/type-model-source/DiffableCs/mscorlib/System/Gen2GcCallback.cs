namespace System;

[Token(Token = "0x20000D8")]
internal sealed class Gen2GcCallback : CriticalFinalizerObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F8")]
	private Func<Object, Boolean> _callback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F9")]
	private GCHandle _weakTargetObj; //Field offset: 0x18

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60006B4")]
	private Gen2GcCallback() { }

	[Address(RVA = "0x2021290", Offset = "0x2020690", Length = "0x169")]
	[Token(Token = "0x60006B7")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2021400", Offset = "0x2020800", Length = "0x85")]
	[Token(Token = "0x60006B5")]
	public static void Register(Func<Object, Boolean> callback, object targetObj) { }

	[Address(RVA = "0x2021490", Offset = "0x2020890", Length = "0x39")]
	[Token(Token = "0x60006B6")]
	private void Setup(Func<Object, Boolean> callback, object targetObj) { }

}

