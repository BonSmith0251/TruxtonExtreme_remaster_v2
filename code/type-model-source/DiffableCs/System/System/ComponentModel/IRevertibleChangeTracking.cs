namespace System.ComponentModel;

[Token(Token = "0x20001A1")]
public interface IRevertibleChangeTracking : IChangeTracking
{

	[Token(Token = "0x6000A2A")]
	public void RejectChanges() { }

}

