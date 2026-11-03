namespace UnityEngine.Networking.PlayerConnection;

[Token(Token = "0x2000306")]
public class MessageEventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007FC")]
	public int playerId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007FD")]
	public Byte[] data; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60018AF")]
	public MessageEventArgs() { }

}

