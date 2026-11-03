namespace TMPro;

[Extension]
[Token(Token = "0x2000004")]
public static class ObjectUtilsBridge
{

	[Address(RVA = "0x2A17610", Offset = "0x2A16A10", Length = "0x19")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Extension]
	[Token(Token = "0x6000003")]
	public static void MarkDirty(object obj) { }

}

