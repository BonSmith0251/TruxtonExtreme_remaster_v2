namespace System.ComponentModel;

[Token(Token = "0x2000153")]
public interface ISite : IServiceProvider
{

	[Token(Token = "0x1700018A")]
	public IContainer Container
	{
		[Token(Token = "0x600084F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700018B")]
	public bool DesignMode
	{
		[Token(Token = "0x6000850")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700018C")]
	public string Name
	{
		[Token(Token = "0x6000851")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600084F")]
	public IContainer get_Container() { }

	[Token(Token = "0x6000850")]
	public bool get_DesignMode() { }

	[Token(Token = "0x6000851")]
	public string get_Name() { }

}

