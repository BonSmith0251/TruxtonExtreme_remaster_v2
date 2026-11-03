namespace UnityEngine.VFX;

[Token(Token = "0x2000018")]
internal class EventAttributeFloat : EventAttributeValue<Single>
{
	[CompilerGenerated]
	[Token(Token = "0x2000019")]
	private sealed class <>c
	{
		[Token(Token = "0x400004F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000050")]
		public static Func<VFXEventAttribute, Int32, Boolean> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4000051")]
		public static Action<VFXEventAttribute, Int32, Single> <>9__0_1; //Field offset: 0x10

		[Address(RVA = "0x2F72650", Offset = "0x2F71A50", Length = "0x67")]
		[Token(Token = "0x6000030")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000031")]
		public <>c() { }

		[Address(RVA = "0x2F72320", Offset = "0x2F71720", Length = "0x26")]
		[Token(Token = "0x6000032")]
		internal bool <.ctor>b__0_0(VFXEventAttribute e, int id) { }

		[Address(RVA = "0x2F72430", Offset = "0x2F71830", Length = "0x26")]
		[Token(Token = "0x6000033")]
		internal void <.ctor>b__0_1(VFXEventAttribute e, int id, float value) { }

	}


	[Address(RVA = "0x2F65150", Offset = "0x2F64550", Length = "0x1CC")]
	[Token(Token = "0x600002F")]
	public EventAttributeFloat() { }

}

