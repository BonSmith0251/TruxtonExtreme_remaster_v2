namespace UnityEngine.UIElements;

[Token(Token = "0x20004FF")]
public class UxmlEnumAttributeDescription : TypedUxmlAttributeDescription<T>
{
	[CompilerGenerated]
	[Token(Token = "0x2000500")]
	private sealed class <>c
	{
		[Token(Token = "0x400109C")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x400109D")]
		public static Func<String, T, T> <>9__3_0; //Field offset: 0x0
		[Token(Token = "0x400109E")]
		public static Func<String, T, T> <>9__4_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6002574")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002575")]
		public <>c() { }

		[Address(RVA = "0xA35270", Offset = "0xA34670", Length = "0x1D")]
		[Token(Token = "0x6002576")]
		internal T <GetValueFromBag>b__3_0(string s, T convertible) { }

		[Address(RVA = "0xA35270", Offset = "0xA34670", Length = "0x1D")]
		[Token(Token = "0x6002577")]
		internal T <TryGetValueFromBag>b__4_0(string s, T convertible) { }

	}


	[Address(RVA = "0x11E4440", Offset = "0x11E3840", Length = "0x50D")]
	[Token(Token = "0x600256E")]
	public UxmlEnumAttributeDescription`1() { }

	[Address(RVA = "0x6E8A50", Offset = "0x6E7E50", Length = "0x1DE")]
	[Token(Token = "0x6002571")]
	private static U ConvertValueToEnum(string v, U defaultValue) { }

	[Address(RVA = "0x11E2F40", Offset = "0x11E2340", Length = "0x1BC")]
	[Token(Token = "0x6002572")]
	private static string GetEnumNameErrorMessage(string v, Type enumType) { }

	[Address(RVA = "0x11E3350", Offset = "0x11E2750", Length = "0x85")]
	[Token(Token = "0x6002573")]
	private static string GetEnumRangeErrorMessage(string v, Type enumType) { }

	[Address(RVA = "0x11E3700", Offset = "0x11E2B00", Length = "0x20B")]
	[Token(Token = "0x600256F")]
	public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x11E3BD0", Offset = "0x11E2FD0", Length = "0x22C")]
	[Token(Token = "0x6002570")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value) { }

}

