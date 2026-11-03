namespace UnityEngine.Rendering;

[AttributeUsage(20, AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
[Token(Token = "0x20000E9")]
public class CoreRPHelpURLAttribute : HelpURLAttribute
{

	[Address(RVA = "0x2C0CDF0", Offset = "0x2C0C1F0", Length = "0x66")]
	[Token(Token = "0x600084E")]
	public CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core") { }

	[Address(RVA = "0x2C0CDC0", Offset = "0x2C0C1C0", Length = "0x2A")]
	[Token(Token = "0x600084F")]
	public CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName = "com.unity.render-pipelines.core") { }

}

