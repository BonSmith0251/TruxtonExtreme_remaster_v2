namespace System.Dynamic;

[Token(Token = "0x2000266")]
internal class ExpandoClass
{
	[Token(Token = "0x4000449")]
	internal static readonly ExpandoClass Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000446")]
	private readonly String[] _keys; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000447")]
	private readonly int _hashCode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000448")]
	private Dictionary<Int32, List`1<WeakReference>> _transitions; //Field offset: 0x20

	[Token(Token = "0x17000266")]
	internal String[] Keys
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000BD5")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2297AE0", Offset = "0x2296EE0", Length = "0xA6")]
	[Token(Token = "0x6000BD6")]
	private static ExpandoClass() { }

	[Address(RVA = "0x2297BE0", Offset = "0x2296FE0", Length = "0x57")]
	[Token(Token = "0x6000BCE")]
	internal ExpandoClass() { }

	[Address(RVA = "0x2297B90", Offset = "0x2296F90", Length = "0x41")]
	[Token(Token = "0x6000BCF")]
	internal ExpandoClass(String[] keys, int hashCode) { }

	[Address(RVA = "0x2297290", Offset = "0x2296690", Length = "0x4E3")]
	[Token(Token = "0x6000BD0")]
	internal ExpandoClass FindNewClass(string newKey) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000BD5")]
	internal String[] get_Keys() { }

	[Address(RVA = "0x2297780", Offset = "0x2296B80", Length = "0x124")]
	[Token(Token = "0x6000BD1")]
	private List<WeakReference> GetTransitionList(int hashCode) { }

	[Address(RVA = "0x2297AC0", Offset = "0x2296EC0", Length = "0x1B")]
	[Token(Token = "0x6000BD2")]
	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	[Address(RVA = "0x22978B0", Offset = "0x2296CB0", Length = "0x167")]
	[Token(Token = "0x6000BD4")]
	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	[Address(RVA = "0x2297A20", Offset = "0x2296E20", Length = "0x9A")]
	[Token(Token = "0x6000BD3")]
	internal int GetValueIndexCaseSensitive(string name) { }

}

