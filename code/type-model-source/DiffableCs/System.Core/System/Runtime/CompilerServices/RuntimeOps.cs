namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Token(Token = "0x2000249")]
public static class RuntimeOps
{

	[Address(RVA = "0x22A8860", Offset = "0x22A7C60", Length = "0x23")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B23")]
	public static bool ExpandoCheckVersion(ExpandoObject expando, object version) { }

	[Address(RVA = "0x22A8890", Offset = "0x22A7C90", Length = "0x1A")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B24")]
	public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass) { }

	[Address(RVA = "0x22A88B0", Offset = "0x22A7CB0", Length = "0xAD")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B22")]
	public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase) { }

	[Address(RVA = "0x22A8960", Offset = "0x22A7D60", Length = "0x2C")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B20")]
	public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value) { }

	[Address(RVA = "0x22A8990", Offset = "0x22A7D90", Length = "0x42")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	[Token(Token = "0x6000B21")]
	public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase) { }

}

