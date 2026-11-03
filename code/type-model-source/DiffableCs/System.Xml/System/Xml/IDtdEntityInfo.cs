namespace System.Xml;

[Token(Token = "0x200002A")]
internal interface IDtdEntityInfo
{

	[Token(Token = "0x1700002B")]
	public string BaseUriString
	{
		[Token(Token = "0x600014E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002C")]
	public string DeclaredUriString
	{
		[Token(Token = "0x600014F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000028")]
	public bool IsDeclaredInExternal
	{
		[Token(Token = "0x600014B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000027")]
	public bool IsExternal
	{
		[Token(Token = "0x600014A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002A")]
	public bool IsParameterEntity
	{
		[Token(Token = "0x600014D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000029")]
	public bool IsUnparsedEntity
	{
		[Token(Token = "0x600014C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000030")]
	public int LineNumber
	{
		[Token(Token = "0x6000153")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000031")]
	public int LinePosition
	{
		[Token(Token = "0x6000154")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000026")]
	public string Name
	{
		[Token(Token = "0x6000149")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002E")]
	public string PublicId
	{
		[Token(Token = "0x6000151")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002D")]
	public string SystemId
	{
		[Token(Token = "0x6000150")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002F")]
	public string Text
	{
		[Token(Token = "0x6000152")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600014E")]
	public string get_BaseUriString() { }

	[Token(Token = "0x600014F")]
	public string get_DeclaredUriString() { }

	[Token(Token = "0x600014B")]
	public bool get_IsDeclaredInExternal() { }

	[Token(Token = "0x600014A")]
	public bool get_IsExternal() { }

	[Token(Token = "0x600014D")]
	public bool get_IsParameterEntity() { }

	[Token(Token = "0x600014C")]
	public bool get_IsUnparsedEntity() { }

	[Token(Token = "0x6000153")]
	public int get_LineNumber() { }

	[Token(Token = "0x6000154")]
	public int get_LinePosition() { }

	[Token(Token = "0x6000149")]
	public string get_Name() { }

	[Token(Token = "0x6000151")]
	public string get_PublicId() { }

	[Token(Token = "0x6000150")]
	public string get_SystemId() { }

	[Token(Token = "0x6000152")]
	public string get_Text() { }

}

