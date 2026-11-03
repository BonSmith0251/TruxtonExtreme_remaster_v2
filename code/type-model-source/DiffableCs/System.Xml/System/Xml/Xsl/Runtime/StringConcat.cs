namespace System.Xml.Xsl.Runtime;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Token(Token = "0x2000148")]
public struct StringConcat
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F4")]
	private string s1; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006F5")]
	private string s2; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006F6")]
	private string s3; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006F7")]
	private string s4; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006F8")]
	private string delimiter; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006F9")]
	private List<String> strList; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006FA")]
	private int idxStr; //Field offset: 0x30

	[Token(Token = "0x170003B1")]
	internal int Count
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000E50")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x2589B60", Offset = "0x2588F60", Length = "0x14")]
	[Token(Token = "0x6000E4F")]
	public void Clear() { }

	[Address(RVA = "0x2589B80", Offset = "0x2588F80", Length = "0x196")]
	[Token(Token = "0x6000E52")]
	internal void ConcatNoDelimiter(string s) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000E50")]
	internal int get_Count() { }

	[Address(RVA = "0x2589D20", Offset = "0x2589120", Length = "0xE4")]
	[Token(Token = "0x6000E51")]
	public string GetResult() { }

}

