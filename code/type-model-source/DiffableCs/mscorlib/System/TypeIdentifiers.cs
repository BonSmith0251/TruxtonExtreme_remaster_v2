namespace System;

[Token(Token = "0x20001D4")]
internal class TypeIdentifiers
{
	[Token(Token = "0x20001D5")]
	private class Display : ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400090C")]
		private string displayName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400090D")]
		private string internal_name; //Field offset: 0x18

		[Token(Token = "0x17000172")]
		public virtual string DisplayName
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x600108F")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000173")]
		public override string InternalName
		{
			[Address(RVA = "0x207FDE0", Offset = "0x207F1E0", Length = "0x3F")]
			[Token(Token = "0x6001090")]
			 get { } //Length: 63
		}

		[Address(RVA = "0x207FDB0", Offset = "0x207F1B0", Length = "0x2E")]
		[Token(Token = "0x600108E")]
		internal Display(string displayName) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600108F")]
		public virtual string get_DisplayName() { }

		[Address(RVA = "0x207FDE0", Offset = "0x207F1E0", Length = "0x3F")]
		[Token(Token = "0x6001090")]
		public override string get_InternalName() { }

		[Address(RVA = "0x207FDA0", Offset = "0x207F1A0", Length = "0xB")]
		[Token(Token = "0x6001091")]
		private string GetInternalName() { }

	}


	[Address(RVA = "0x2090320", Offset = "0x208F720", Length = "0x69")]
	[Token(Token = "0x600108D")]
	internal static TypeIdentifier FromDisplay(string displayName) { }

}

