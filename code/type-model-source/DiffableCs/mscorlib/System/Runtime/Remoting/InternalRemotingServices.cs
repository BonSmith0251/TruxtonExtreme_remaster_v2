namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x200034E")]
public class InternalRemotingServices
{
	[Token(Token = "0x4000DDB")]
	private static Hashtable _soapAttributes; //Field offset: 0x0

	[Address(RVA = "0x1EE2590", Offset = "0x1EE1990", Length = "0x73")]
	[Token(Token = "0x6001A91")]
	private static InternalRemotingServices() { }

	[Address(RVA = "0x1EE2020", Offset = "0x1EE1420", Length = "0x56B")]
	[Token(Token = "0x6001A90")]
	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject) { }

}

