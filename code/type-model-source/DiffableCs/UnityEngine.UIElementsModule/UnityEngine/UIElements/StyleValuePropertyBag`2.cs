namespace UnityEngine.UIElements;

[Token(Token = "0x200042F")]
internal class StyleValuePropertyBag : ContainerPropertyBag<TContainer>
{
	[Token(Token = "0x2000431")]
	private class KeywordProperty : Property<TContainer, StyleKeyword>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000DE0")]
		private readonly string <Name>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000DE1")]
		private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170008DC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002023")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170008DB")]
		public virtual string Name
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002022")]
			 get { } //Length: 5
		}

		[Address(RVA = "0xAF4FC0", Offset = "0xAF43C0", Length = "0x6C")]
		[Token(Token = "0x6002026")]
		public KeywordProperty() { }

		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002023")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002022")]
		public virtual string get_Name() { }

		[Address(RVA = "0xAF4270", Offset = "0xAF3670", Length = "0x17")]
		[Token(Token = "0x6002024")]
		public virtual StyleKeyword GetValue(ref TContainer container) { }

		[Address(RVA = "0xAF4510", Offset = "0xAF3910", Length = "0x1D")]
		[Token(Token = "0x6002025")]
		public virtual void SetValue(ref TContainer container, StyleKeyword value) { }

	}

	[Token(Token = "0x2000430")]
	private class ValueProperty : Property<TContainer, TValue>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000DDE")]
		private readonly string <Name>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000DDF")]
		private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170008DA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600201E")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170008D9")]
		public virtual string Name
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600201D")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x120E9F0", Offset = "0x120DDF0", Length = "0x6C")]
		[Token(Token = "0x6002021")]
		public ValueProperty() { }

		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600201E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600201D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x120DC70", Offset = "0x120D070", Length = "0x17")]
		[Token(Token = "0x600201F")]
		public virtual TValue GetValue(ref TContainer container) { }

		[Address(RVA = "0x120E290", Offset = "0x120D690", Length = "0x1D")]
		[Token(Token = "0x6002020")]
		public virtual void SetValue(ref TContainer container, TValue value) { }

	}


	[Address(RVA = "0xFD6BF0", Offset = "0xFD5FF0", Length = "0x131")]
	[Token(Token = "0x600201C")]
	public StyleValuePropertyBag`2() { }

}

