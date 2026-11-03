namespace Unity.Properties;

[Token(Token = "0x200001D")]
internal interface IMemberInfo
{

	[Token(Token = "0x17000016")]
	public bool IsReadOnly
	{
		[Token(Token = "0x600006B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000015")]
	public string Name
	{
		[Token(Token = "0x600006A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000017")]
	public Type ValueType
	{
		[Token(Token = "0x600006C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600006B")]
	public bool get_IsReadOnly() { }

	[Token(Token = "0x600006A")]
	public string get_Name() { }

	[Token(Token = "0x600006C")]
	public Type get_ValueType() { }

	[Token(Token = "0x600006F")]
	public IEnumerable<Attribute> GetCustomAttributes() { }

	[Token(Token = "0x600006D")]
	public object GetValue(object obj) { }

	[Token(Token = "0x600006E")]
	public void SetValue(object obj, object value) { }

}

