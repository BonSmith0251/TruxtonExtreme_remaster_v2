namespace System.Diagnostics;

[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
[Token(Token = "0x2000340")]
public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler
{

	[Address(RVA = "0x25DE7D0", Offset = "0x25DDBD0", Length = "0x2C")]
	[Token(Token = "0x6001513")]
	public DiagnosticsConfigurationHandler() { }

	[Address(RVA = "0x25DE7A0", Offset = "0x25DDBA0", Length = "0x2C")]
	[Token(Token = "0x6001514")]
	public override object Create(object parent, object configContext, XmlNode section) { }

}

