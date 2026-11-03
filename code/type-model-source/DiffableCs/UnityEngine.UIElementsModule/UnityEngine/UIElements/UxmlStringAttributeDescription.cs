namespace UnityEngine.UIElements;

[Token(Token = "0x20004EE")]
public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<String>
{
	[CompilerGenerated]
	[Token(Token = "0x20004EF")]
	private sealed class <>c
	{
		[Token(Token = "0x400108A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400108B")]
		public static Func<String, String, String> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x400108C")]
		public static Func<String, String, String> <>9__4_0; //Field offset: 0x10

		[Address(RVA = "0x32BB450", Offset = "0x32BA850", Length = "0x67")]
		[Token(Token = "0x600253A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600253B")]
		public <>c() { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x600253C")]
		internal string <GetValueFromBag>b__3_0(string s, string t) { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x600253D")]
		internal string <TryGetValueFromBag>b__4_0(string s, string t) { }

	}


	[Address(RVA = "0x32C62A0", Offset = "0x32C56A0", Length = "0xA5")]
	[Token(Token = "0x6002537")]
	public UxmlStringAttributeDescription() { }

	[Address(RVA = "0x32C5F90", Offset = "0x32C5390", Length = "0x176")]
	[Token(Token = "0x6002538")]
	public virtual string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x32C6110", Offset = "0x32C5510", Length = "0x181")]
	[Token(Token = "0x6002539")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value) { }

}

