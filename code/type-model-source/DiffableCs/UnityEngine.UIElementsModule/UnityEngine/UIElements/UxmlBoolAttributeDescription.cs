namespace UnityEngine.UIElements;

[Token(Token = "0x20004FC")]
public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<Boolean>
{
	[CompilerGenerated]
	[Token(Token = "0x20004FD")]
	private sealed class <>c
	{
		[Token(Token = "0x400109A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400109B")]
		public static Func<String, Boolean, Boolean> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x32BB3E0", Offset = "0x32BA7E0", Length = "0x67")]
		[Token(Token = "0x6002567")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002568")]
		public <>c() { }

		[Address(RVA = "0x32BAAC0", Offset = "0x32B9EC0", Length = "0x58")]
		[Token(Token = "0x6002569")]
		internal bool <GetValueFromBag>b__3_0(string s, bool b) { }

	}


	[Address(RVA = "0x32C3980", Offset = "0x32C2D80", Length = "0x8A")]
	[Token(Token = "0x6002564")]
	public UxmlBoolAttributeDescription() { }

	[Address(RVA = "0x32C37A0", Offset = "0x32C2BA0", Length = "0x57")]
	[Token(Token = "0x6002566")]
	private static bool ConvertValueToBool(string v, bool defaultValue) { }

	[Address(RVA = "0x32C3800", Offset = "0x32C2C00", Length = "0x175")]
	[Token(Token = "0x6002565")]
	public virtual bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

