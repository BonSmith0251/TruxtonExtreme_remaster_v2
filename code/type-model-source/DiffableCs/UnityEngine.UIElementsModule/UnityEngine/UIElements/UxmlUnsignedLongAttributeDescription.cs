namespace UnityEngine.UIElements;

[Token(Token = "0x20004F8")]
public class UxmlUnsignedLongAttributeDescription : TypedUxmlAttributeDescription<UInt64>
{
	[CompilerGenerated]
	[Token(Token = "0x20004F9")]
	private sealed class <>c
	{
		[Token(Token = "0x4001096")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001097")]
		public static Func<String, UInt64, UInt64> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x32BB530", Offset = "0x32BA930", Length = "0x67")]
		[Token(Token = "0x600255B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600255C")]
		public <>c() { }

		[Address(RVA = "0x32BA9D0", Offset = "0x32B9DD0", Length = "0x3C")]
		[Token(Token = "0x600255D")]
		internal ulong <GetValueFromBag>b__3_0(string s, ulong l) { }

	}


	[Address(RVA = "0x32C6BC0", Offset = "0x32C5FC0", Length = "0x8E")]
	[Token(Token = "0x6002558")]
	public UxmlUnsignedLongAttributeDescription() { }

	[Address(RVA = "0x32C6A00", Offset = "0x32C5E00", Length = "0x36")]
	[Token(Token = "0x600255A")]
	private static ulong ConvertValueToUlong(string v, ulong defaultValue) { }

	[Address(RVA = "0x32C6A40", Offset = "0x32C5E40", Length = "0x176")]
	[Token(Token = "0x6002559")]
	public virtual ulong GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

