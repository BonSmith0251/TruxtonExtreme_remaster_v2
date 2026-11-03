namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x20003C9")]
public class RemotingSurrogateSelector : ISurrogateSelector
{
	[Token(Token = "0x4000F08")]
	private static Type s_cachedTypeObjRef; //Field offset: 0x0
	[Token(Token = "0x4000F09")]
	private static ObjRefSurrogate _objRefSurrogate; //Field offset: 0x8
	[Token(Token = "0x4000F0A")]
	private static RemotingSurrogate _objRemotingSurrogate; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F0B")]
	private ISurrogateSelector _next; //Field offset: 0x10

	[Address(RVA = "0x1F12840", Offset = "0x1F11C40", Length = "0x122")]
	[Token(Token = "0x6001D55")]
	private static RemotingSurrogateSelector() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001D53")]
	public RemotingSurrogateSelector() { }

	[Address(RVA = "0x1F126A0", Offset = "0x1F11AA0", Length = "0x195")]
	[Token(Token = "0x6001D54")]
	public override ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

}

