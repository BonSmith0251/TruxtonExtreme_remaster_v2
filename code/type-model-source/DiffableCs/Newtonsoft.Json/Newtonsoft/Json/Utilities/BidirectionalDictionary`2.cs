namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000098")]
internal class BidirectionalDictionary
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400037E")]
	private readonly IDictionary<TFirst, TSecond> _firstToSecond; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400037F")]
	private readonly IDictionary<TSecond, TFirst> _secondToFirst; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000380")]
	private readonly string _duplicateFirstErrorMessage; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000381")]
	private readonly string _duplicateSecondErrorMessage; //Field offset: 0x0

	[Address(RVA = "0x16B6E80", Offset = "0x16B6280", Length = "0x178")]
	[Token(Token = "0x60004F9")]
	public BidirectionalDictionary`2() { }

	[Address(RVA = "0x16B7340", Offset = "0x16B6740", Length = "0x142")]
	[Token(Token = "0x60004FA")]
	public BidirectionalDictionary`2(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer) { }

	[Address(RVA = "0x16B71A0", Offset = "0x16B65A0", Length = "0x114")]
	[Token(Token = "0x60004FB")]
	public BidirectionalDictionary`2(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }

	[Address(RVA = "0x16B6010", Offset = "0x16B5410", Length = "0x33F")]
	[Token(Token = "0x60004FC")]
	public void Set(TFirst first, TSecond second) { }

	[Address(RVA = "0x16B6BA0", Offset = "0x16B5FA0", Length = "0x6B")]
	[Token(Token = "0x60004FD")]
	public bool TryGetByFirst(TFirst first, out TSecond second) { }

	[Address(RVA = "0x16B6E10", Offset = "0x16B6210", Length = "0x6E")]
	[Token(Token = "0x60004FE")]
	public bool TryGetBySecond(TSecond second, out TFirst first) { }

}

