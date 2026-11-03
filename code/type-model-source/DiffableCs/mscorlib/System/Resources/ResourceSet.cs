namespace System.Resources;

[ComVisible(True)]
[Token(Token = "0x20004C7")]
public class ResourceSet : IDisposable, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012E6")]
	protected IResourceReader Reader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012E7")]
	protected Hashtable Table; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012E8")]
	private Hashtable _caseInsensitiveTable; //Field offset: 0x20

	[Address(RVA = "0x1F40440", Offset = "0x1F3F840", Length = "0x63")]
	[Token(Token = "0x60021F1")]
	protected ResourceSet() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60021F2")]
	internal ResourceSet(bool junk) { }

	[Address(RVA = "0x1F3F8C0", Offset = "0x1F3ECC0", Length = "0x5C")]
	[Token(Token = "0x60021F3")]
	private void CommonInit() { }

	[Address(RVA = "0x1F3F920", Offset = "0x1F3ED20", Length = "0x9D")]
	[Token(Token = "0x60021F4")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1F3F9C0", Offset = "0x1F3EDC0", Length = "0x16")]
	[Token(Token = "0x60021F5")]
	public override void Dispose() { }

	[Address(RVA = "0x1F3F9E0", Offset = "0x1F3EDE0", Length = "0x361")]
	[Token(Token = "0x60021FE")]
	private object GetCaseInsensitiveObjectInternal(string name) { }

	[Address(RVA = "0x1F3FDE0", Offset = "0x1F3F1E0", Length = "0x7")]
	[ComVisible(False)]
	[Token(Token = "0x60021F6")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x1F3FD50", Offset = "0x1F3F150", Length = "0x90")]
	[Token(Token = "0x60021F8")]
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	[Address(RVA = "0x1F3FDF0", Offset = "0x1F3F1F0", Length = "0xD7")]
	[Token(Token = "0x60021FB")]
	public override object GetObject(string name) { }

	[Address(RVA = "0x1F3FED0", Offset = "0x1F3F2D0", Length = "0x106")]
	[Token(Token = "0x60021FC")]
	public override object GetObject(string name, bool ignoreCase) { }

	[Address(RVA = "0x1F3FDF0", Offset = "0x1F3F1F0", Length = "0xD7")]
	[Token(Token = "0x60021FD")]
	private object GetObjectInternal(string name) { }

	[Address(RVA = "0x1F3FFE0", Offset = "0x1F3F3E0", Length = "0x1A4")]
	[Token(Token = "0x60021F9")]
	public override string GetString(string name) { }

	[Address(RVA = "0x1F40190", Offset = "0x1F3F590", Length = "0x2A1")]
	[Token(Token = "0x60021FA")]
	public override string GetString(string name, bool ignoreCase) { }

	[Address(RVA = "0x1F3FDE0", Offset = "0x1F3F1E0", Length = "0x7")]
	[Token(Token = "0x60021F7")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

