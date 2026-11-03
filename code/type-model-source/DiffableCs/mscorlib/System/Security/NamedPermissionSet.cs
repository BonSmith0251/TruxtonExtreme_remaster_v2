namespace System.Security;

[ComVisible(True)]
[Token(Token = "0x20002CE")]
public sealed class NamedPermissionSet : PermissionSet
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C0E")]
	private string name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C0F")]
	private string description; //Field offset: 0x38

	[Token(Token = "0x1700024E")]
	public string Name
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001796")]
		 get { } //Length: 5
		[Address(RVA = "0x1EA5C00", Offset = "0x1EA5000", Length = "0xA4")]
		[Token(Token = "0x6001797")]
		 set { } //Length: 164
	}

	[Address(RVA = "0x1EA5980", Offset = "0x1EA4D80", Length = "0x97")]
	[Token(Token = "0x6001793")]
	internal NamedPermissionSet() { }

	[Address(RVA = "0x1EA5A20", Offset = "0x1EA4E20", Length = "0x1DE")]
	[Token(Token = "0x6001794")]
	public NamedPermissionSet(string name, PermissionState state) { }

	[Address(RVA = "0x1EA5970", Offset = "0x1EA4D70", Length = "0xE")]
	[Token(Token = "0x6001795")]
	public NamedPermissionSet(string name) { }

	[Address(RVA = "0x1EA57D0", Offset = "0x1EA4BD0", Length = "0x7F")]
	[ComVisible(False)]
	[Token(Token = "0x6001799")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001796")]
	public string get_Name() { }

	[Address(RVA = "0x1EA5850", Offset = "0x1EA4C50", Length = "0x72")]
	[ComVisible(False)]
	[Token(Token = "0x600179A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1EA5C00", Offset = "0x1EA5000", Length = "0xA4")]
	[Token(Token = "0x6001797")]
	public void set_Name(string value) { }

	[Address(RVA = "0x1EA58D0", Offset = "0x1EA4CD0", Length = "0x99")]
	[Token(Token = "0x6001798")]
	public virtual SecurityElement ToXml() { }

}

