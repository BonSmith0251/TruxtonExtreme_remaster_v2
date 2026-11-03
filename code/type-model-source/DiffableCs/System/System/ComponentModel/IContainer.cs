namespace System.ComponentModel;

[Token(Token = "0x2000152")]
public interface IContainer : IDisposable
{

	[Token(Token = "0x17000189")]
	public ComponentCollection Components
	{
		[Token(Token = "0x600084D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600084D")]
	public ComponentCollection get_Components() { }

	[Token(Token = "0x600084E")]
	public void Remove(IComponent component) { }

}

