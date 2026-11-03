namespace Unity.Properties;

[Token(Token = "0x2000016")]
public interface IProperty
{

	[Token(Token = "0x17000008")]
	public string Name
	{
		[Token(Token = "0x600002F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000030")]
	public Type DeclaredValueType() { }

	[Token(Token = "0x600002F")]
	public string get_Name() { }

}

