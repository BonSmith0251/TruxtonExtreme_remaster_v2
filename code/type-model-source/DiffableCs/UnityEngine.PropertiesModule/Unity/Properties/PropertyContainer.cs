namespace Unity.Properties;

[Token(Token = "0x2000004")]
public static class PropertyContainer
{
	[Token(Token = "0x2000005")]
	private class GetPropertyVisitor : PathVisitor
	{
		[CompilerGenerated]
		[Token(Token = "0x2000006")]
		private sealed class <>c
		{
			[Token(Token = "0x4000009")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x31647E0", Offset = "0x3163BE0", Length = "0x67")]
			[Token(Token = "0x600000D")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600000E")]
			public <>c() { }

			[Address(RVA = "0x3164620", Offset = "0x3163A20", Length = "0x44")]
			[Token(Token = "0x600000F")]
			internal GetPropertyVisitor <.cctor>b__5_0() { }

			[Address(RVA = "0xA36C90", Offset = "0xA36090", Length = "0x2C")]
			[Token(Token = "0x6000010")]
			internal void <.cctor>b__5_1(GetPropertyVisitor v) { }

		}

		[Token(Token = "0x4000007")]
		public static readonly ObjectPool<GetPropertyVisitor> Pool; //Field offset: 0x0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000008")]
		public IProperty Property; //Field offset: 0xB8

		[Address(RVA = "0x3142370", Offset = "0x3141770", Length = "0x181")]
		[Token(Token = "0x600000C")]
		private static GetPropertyVisitor() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600000B")]
		public GetPropertyVisitor() { }

		[Address(RVA = "0x31422F0", Offset = "0x31416F0", Length = "0x7F")]
		[Token(Token = "0x6000009")]
		public virtual void Reset() { }

		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[Token(Token = "0x600000A")]
		protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

	}

	[Token(Token = "0x2000007")]
	private class GetValueVisitor : PathVisitor
	{
		[CompilerGenerated]
		[Token(Token = "0x2000008")]
		private sealed class <>c
		{
			[Token(Token = "0x400000C")]
			public static readonly <>c<TSrcValue> <>9; //Field offset: 0x0

			[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
			[Token(Token = "0x6000015")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000016")]
			public <>c() { }

			[Address(RVA = "0xA36BE0", Offset = "0xA35FE0", Length = "0x5D")]
			[Token(Token = "0x6000017")]
			internal GetValueVisitor<TSrcValue> <.cctor>b__5_0() { }

			[Address(RVA = "0xA36C90", Offset = "0xA36090", Length = "0x2C")]
			[Token(Token = "0x6000018")]
			internal void <.cctor>b__5_1(GetValueVisitor<TSrcValue> v) { }

		}

		[Token(Token = "0x400000A")]
		public static readonly ObjectPool<GetValueVisitor`1<TSrcValue>> Pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000B")]
		public TSrcValue Value; //Field offset: 0x0

		[Address(RVA = "0x1C3FC00", Offset = "0x1C3F000", Length = "0x30E")]
		[Token(Token = "0x6000014")]
		private static GetValueVisitor`1() { }

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000013")]
		public GetValueVisitor`1() { }

		[Address(RVA = "0x1C3F850", Offset = "0x1C3EC50", Length = "0x30")]
		[Token(Token = "0x6000011")]
		public virtual void Reset() { }

		[Address(RVA = "0x69A110", Offset = "0x699510", Length = "0xC9")]
		[Token(Token = "0x6000012")]
		protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

	}


	[Address(RVA = "0x8C7E40", Offset = "0x8C7240", Length = "0x1F3")]
	[Token(Token = "0x6000002")]
	public static void Accept(IPropertyBagVisitor visitor, ref TContainer container, VisitParameters parameters = null) { }

	[Address(RVA = "0x8CFC80", Offset = "0x8CF080", Length = "0x6C")]
	[Token(Token = "0x6000003")]
	public static bool TryAccept(IPropertyBagVisitor visitor, ref TContainer container, VisitParameters parameters = null) { }

	[Address(RVA = "0x8CFCF0", Offset = "0x8CF0F0", Length = "0x3B4")]
	[Token(Token = "0x6000004")]
	public static bool TryAccept(IPropertyBagVisitor visitor, ref TContainer container, out VisitReturnCode returnCode, VisitParameters parameters = null) { }

	[Address(RVA = "0x8DECD0", Offset = "0x8DE0D0", Length = "0x6C")]
	[Token(Token = "0x6000005")]
	public static bool TryGetProperty(ref TContainer container, in PropertyPath path, out IProperty property) { }

	[Address(RVA = "0x8DEA10", Offset = "0x8DDE10", Length = "0x2B9")]
	[Token(Token = "0x6000006")]
	public static bool TryGetProperty(ref TContainer container, in PropertyPath path, out IProperty property, out VisitReturnCode returnCode) { }

	[Address(RVA = "0x8DF3D0", Offset = "0x8DE7D0", Length = "0xC7")]
	[Token(Token = "0x6000007")]
	public static bool TryGetValue(ref TContainer container, string name, out TValue value) { }

	[Address(RVA = "0x8DF150", Offset = "0x8DE550", Length = "0x276")]
	[Token(Token = "0x6000008")]
	public static bool TryGetValue(ref TContainer container, in PropertyPath path, out TValue value, out VisitReturnCode returnCode) { }

}

