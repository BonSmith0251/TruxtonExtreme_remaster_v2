namespace UnityEngine.UIElements;

[Token(Token = "0x2000046")]
public interface IDataSourceProvider
{

	[Token(Token = "0x17000046")]
	public object dataSource
	{
		[Token(Token = "0x6000215")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000047")]
	public PropertyPath dataSourcePath
	{
		[Token(Token = "0x6000216")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000215")]
	public object get_dataSource() { }

	[Token(Token = "0x6000216")]
	public PropertyPath get_dataSourcePath() { }

}

