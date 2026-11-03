namespace UnityEngine.Rendering;

[Token(Token = "0x20000EC")]
public class DocumentationInfo
{
	[Token(Token = "0x4000300")]
	private const string fallbackVersion = "13.1"; //Field offset: 0x0
	[Token(Token = "0x4000301")]
	private const string packageDocumentationUrl = "https://docs.unity3d.com/Packages/{0}@{1}/manual/"; //Field offset: 0x0
	[Token(Token = "0x4000302")]
	private const string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html{3}"; //Field offset: 0x0

	[Token(Token = "0x170000EC")]
	public static string version
	{
		[Address(RVA = "0x2C0DB70", Offset = "0x2C0CF70", Length = "0x2C")]
		[Token(Token = "0x6000859")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000860")]
	public DocumentationInfo() { }

	[Address(RVA = "0x2C0DB70", Offset = "0x2C0CF70", Length = "0x2C")]
	[Token(Token = "0x6000859")]
	public static string get_version() { }

	[Address(RVA = "0x2C0D340", Offset = "0x2C0C740", Length = "0x4B")]
	[Token(Token = "0x600085E")]
	public static string GetDefaultPackageLink(string packageName, string packageVersion) { }

	[Address(RVA = "0x2C0D2E0", Offset = "0x2C0C6E0", Length = "0x5F")]
	[Token(Token = "0x600085F")]
	public static string GetDefaultPackageLink(string packageName) { }

	[Address(RVA = "0x2C0D390", Offset = "0x2C0C790", Length = "0x1C1")]
	[Token(Token = "0x600085A")]
	public static string GetPackageLink(string packageName, string packageVersion, string pageName) { }

	[Address(RVA = "0x2C0D560", Offset = "0x2C0C960", Length = "0x208")]
	[Token(Token = "0x600085B")]
	public static string GetPackageLink(string packageName, string packageVersion, string pageName, string pageHash) { }

	[Address(RVA = "0x2C0D990", Offset = "0x2C0CD90", Length = "0x1D7")]
	[Token(Token = "0x600085C")]
	public static string GetPageLink(string packageName, string pageName) { }

	[Address(RVA = "0x2C0D770", Offset = "0x2C0CB70", Length = "0x218")]
	[Token(Token = "0x600085D")]
	public static string GetPageLink(string packageName, string pageName, string pageHash) { }

}

