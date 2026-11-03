namespace System.Resources;

[Token(Token = "0x20004BA")]
internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable
{
	[Token(Token = "0x40012B3")]
	internal const int Version = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012B4")]
	private Dictionary<String, ResourceLocator> _resCache; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012B5")]
	private ResourceReader _defaultReader; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012B6")]
	private Dictionary<String, ResourceLocator> _caseInsensitiveTable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40012B7")]
	private bool _haveReadFromReader; //Field offset: 0x40

	[Address(RVA = "0x1F416C0", Offset = "0x1F40AC0", Length = "0x166")]
	[Token(Token = "0x60021A4")]
	internal RuntimeResourceSet(string fileName) { }

	[Address(RVA = "0x1F415A0", Offset = "0x1F409A0", Length = "0x117")]
	[Token(Token = "0x60021A5")]
	internal RuntimeResourceSet(Stream stream) { }

	[Address(RVA = "0x1F40630", Offset = "0x1F3FA30", Length = "0x13B")]
	[Token(Token = "0x60021A6")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1F40810", Offset = "0x1F3FC10", Length = "0x7")]
	[Token(Token = "0x60021A7")]
	public virtual IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x1F40770", Offset = "0x1F3FB70", Length = "0x95")]
	[Token(Token = "0x60021A9")]
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	[Address(RVA = "0x1F40820", Offset = "0x1F3FC20", Length = "0x1D")]
	[Token(Token = "0x60021AC")]
	public virtual object GetObject(string key) { }

	[Address(RVA = "0x1F41330", Offset = "0x1F40730", Length = "0x1A")]
	[Token(Token = "0x60021AD")]
	public virtual object GetObject(string key, bool ignoreCase) { }

	[Address(RVA = "0x1F40840", Offset = "0x1F3FC40", Length = "0xAE8")]
	[Token(Token = "0x60021AE")]
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	[Address(RVA = "0x1F41390", Offset = "0x1F40790", Length = "0x41")]
	[Token(Token = "0x60021AA")]
	public virtual string GetString(string key) { }

	[Address(RVA = "0x1F41350", Offset = "0x1F40750", Length = "0x3E")]
	[Token(Token = "0x60021AB")]
	public virtual string GetString(string key, bool ignoreCase) { }

	[Address(RVA = "0x1F413E0", Offset = "0x1F407E0", Length = "0x1B6")]
	[Token(Token = "0x60021AF")]
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<String, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

	[Address(RVA = "0x1F40810", Offset = "0x1F3FC10", Length = "0x7")]
	[Token(Token = "0x60021A8")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

