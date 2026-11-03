namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200000F")]
public class DefaultJsonNameTable : JsonNameTable
{
	[Nullable(0)]
	[Token(Token = "0x2000010")]
	private class Entry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000018")]
		internal readonly string Value; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000019")]
		internal readonly int HashCode; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001A")]
		internal Entry Next; //Field offset: 0x20

		[Address(RVA = "0x20C7F80", Offset = "0x20C7380", Length = "0x5E")]
		[Token(Token = "0x6000014")]
		internal Entry(string value, int hashCode, Entry next) { }

	}

	[Token(Token = "0x4000014")]
	private static readonly int HashCodeRandomizer; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000015")]
	private int _count; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000016")]
	private Entry[] _entries; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000017")]
	private int _mask; //Field offset: 0x20

	[Address(RVA = "0x20C7EE0", Offset = "0x20C72E0", Length = "0x3C")]
	[Token(Token = "0x600000D")]
	private static DefaultJsonNameTable() { }

	[Address(RVA = "0x20C7F20", Offset = "0x20C7320", Length = "0x5C")]
	[Token(Token = "0x600000E")]
	public DefaultJsonNameTable() { }

	[Address(RVA = "0x20C7900", Offset = "0x20C6D00", Length = "0x1B1")]
	[Token(Token = "0x6000010")]
	public string Add(string key) { }

	[Address(RVA = "0x20C7680", Offset = "0x20C6A80", Length = "0x270")]
	[Token(Token = "0x6000011")]
	private string AddEntry(string str, int hashCode) { }

	[Address(RVA = "0x20C7AC0", Offset = "0x20C6EC0", Length = "0x20C")]
	[Token(Token = "0x600000F")]
	public virtual string Get(Char[] key, int start, int length) { }

	[Address(RVA = "0x20C7CD0", Offset = "0x20C70D0", Length = "0x166")]
	[Token(Token = "0x6000012")]
	private void Grow() { }

	[Address(RVA = "0x20C7E40", Offset = "0x20C7240", Length = "0x99")]
	[Token(Token = "0x6000013")]
	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

