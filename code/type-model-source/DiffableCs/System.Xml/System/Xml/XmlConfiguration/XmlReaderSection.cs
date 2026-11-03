namespace System.Xml.XmlConfiguration;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Token(Token = "0x2000147")]
public sealed class XmlReaderSection
{

	[Token(Token = "0x170003B0")]
	internal static bool CollapseWhiteSpaceIntoEmptyString
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000E4E")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170003AF")]
	internal static bool ProhibitDefaultUrlResolver
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000E4C")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x258B930", Offset = "0x258AD30", Length = "0x44")]
	[Token(Token = "0x6000E4D")]
	internal static XmlResolver CreateDefaultResolver() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000E4E")]
	internal static bool get_CollapseWhiteSpaceIntoEmptyString() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000E4C")]
	internal static bool get_ProhibitDefaultUrlResolver() { }

}

