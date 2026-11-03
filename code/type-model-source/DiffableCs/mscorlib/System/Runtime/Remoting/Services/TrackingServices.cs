namespace System.Runtime.Remoting.Services;

[ComVisible(True)]
[Token(Token = "0x2000365")]
public class TrackingServices
{
	[Token(Token = "0x4000E2C")]
	private static ArrayList _handlers; //Field offset: 0x0

	[Address(RVA = "0x1EF1630", Offset = "0x1EF0A30", Length = "0x73")]
	[Token(Token = "0x6001B4C")]
	private static TrackingServices() { }

	[Address(RVA = "0x1EF0C40", Offset = "0x1EF0040", Length = "0x343")]
	[Token(Token = "0x6001B4B")]
	internal static void NotifyDisconnectedObject(object obj) { }

	[Address(RVA = "0x1EF0F90", Offset = "0x1EF0390", Length = "0x34B")]
	[Token(Token = "0x6001B49")]
	internal static void NotifyMarshaledObject(object obj, ObjRef or) { }

	[Address(RVA = "0x1EF12E0", Offset = "0x1EF06E0", Length = "0x34C")]
	[Token(Token = "0x6001B4A")]
	internal static void NotifyUnmarshaledObject(object obj, ObjRef or) { }

}

