namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
[Token(Token = "0x2000379")]
public interface IContextAttribute
{

	[Token(Token = "0x6001BCE")]
	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[Token(Token = "0x6001BCF")]
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }

}

