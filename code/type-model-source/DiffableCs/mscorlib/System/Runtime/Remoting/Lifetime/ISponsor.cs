namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
[Token(Token = "0x200036B")]
public interface ISponsor
{

	[Token(Token = "0x6001B76")]
	public TimeSpan Renewal(ILease lease) { }

}

