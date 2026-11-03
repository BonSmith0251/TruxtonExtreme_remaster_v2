namespace UnityEngine.UIElements;

[Token(Token = "0x20004F0")]
public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20004F1")]
	private sealed class <>c
	{
		[Token(Token = "0x400108D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400108E")]
		public static Func<String, Single, Single> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x32BB220", Offset = "0x32BA620", Length = "0x67")]
		[Token(Token = "0x6002541")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002542")]
		public <>c() { }

		[Address(RVA = "0x32BABC0", Offset = "0x32B9FC0", Length = "0x97")]
		[Token(Token = "0x6002543")]
		internal float <GetValueFromBag>b__3_0(string s, float f) { }

	}


	[Address(RVA = "0x32C41D0", Offset = "0x32C35D0", Length = "0x8D")]
	[Token(Token = "0x600253E")]
	public UxmlFloatAttributeDescription() { }

	[Address(RVA = "0x32C3FB0", Offset = "0x32C33B0", Length = "0x97")]
	[Token(Token = "0x6002540")]
	private static float ConvertValueToFloat(string v, float defaultValue) { }

	[Address(RVA = "0x32C4050", Offset = "0x32C3450", Length = "0x178")]
	[Token(Token = "0x600253F")]
	public virtual float GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

