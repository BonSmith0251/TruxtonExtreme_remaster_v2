namespace System.Runtime.CompilerServices;

[Token(Token = "0x200047E")]
public static class FormattableStringFactory
{
	[Token(Token = "0x200047F")]
	private sealed class ConcreteFormattableString : FormattableString
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001257")]
		private readonly string _format; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001258")]
		private readonly Object[] _arguments; //Field offset: 0x18

		[Token(Token = "0x17000400")]
		public virtual int ArgumentCount
		{
			[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
			[Token(Token = "0x60020E0")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170003FF")]
		public virtual string Format
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60020DE")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1F319D0", Offset = "0x1F30DD0", Length = "0x4E")]
		[Token(Token = "0x60020DD")]
		internal ConcreteFormattableString(string format, Object[] arguments) { }

		[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
		[Token(Token = "0x60020E0")]
		public virtual int get_ArgumentCount() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60020DE")]
		public virtual string get_Format() { }

		[Address(RVA = "0x1F12AF0", Offset = "0x1F11EF0", Length = "0x2B")]
		[Token(Token = "0x60020E1")]
		public virtual object GetArgument(int index) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60020DF")]
		public virtual Object[] GetArguments() { }

		[Address(RVA = "0x1F330C0", Offset = "0x1F324C0", Length = "0x16")]
		[Token(Token = "0x60020E2")]
		public virtual string ToString(IFormatProvider formatProvider) { }

	}


	[Address(RVA = "0x1F35BB0", Offset = "0x1F34FB0", Length = "0x11C")]
	[Token(Token = "0x60020DC")]
	public static FormattableString Create(string format, Object[] arguments) { }

}

