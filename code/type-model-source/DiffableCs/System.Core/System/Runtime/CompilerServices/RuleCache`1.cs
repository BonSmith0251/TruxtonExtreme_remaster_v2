namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Token(Token = "0x2000253")]
public class RuleCache
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400042E")]
	private T[] _rules; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400042F")]
	private readonly object _cacheLock; //Field offset: 0x0

	[Address(RVA = "0xF54A40", Offset = "0xF53E40", Length = "0x8C")]
	[Token(Token = "0x6000B77")]
	internal RuleCache`1() { }

	[Address(RVA = "0xF54470", Offset = "0xF53870", Length = "0x142")]
	[Token(Token = "0x6000B7B")]
	private static T[] AddOrInsert(T[] rules, T item) { }

	[Address(RVA = "0xF545C0", Offset = "0xF539C0", Length = "0x1E9")]
	[Token(Token = "0x6000B7A")]
	internal void AddRule(T newRule) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000B78")]
	internal T[] GetRules() { }

	[Address(RVA = "0xF547B0", Offset = "0xF53BB0", Length = "0x281")]
	[Token(Token = "0x6000B79")]
	internal void MoveRule(T rule, int i) { }

}

