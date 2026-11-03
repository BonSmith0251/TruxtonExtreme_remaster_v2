namespace System.ComponentModel.Design;

[Token(Token = "0x20001C9")]
public interface IDesignerHost : IServiceProvider
{

	[Token(Token = "0x1700021C")]
	public IComponent RootComponent
	{
		[Token(Token = "0x6000B77")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000B77")]
	public IComponent get_RootComponent() { }

	[Token(Token = "0x6000B78")]
	public IDesigner GetDesigner(IComponent component) { }

}

