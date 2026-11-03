namespace System;

[Token(Token = "0x20001D2")]
internal class TypeNames
{
	[Token(Token = "0x20001D3")]
	public abstract class ATypeName : TypeName, IEquatable<TypeName>
	{

		[Token(Token = "0x17000171")]
		public abstract string DisplayName
		{
			[Token(Token = "0x6001088")]
			 get { } //Length: 0
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600108C")]
		protected ATypeName() { }

		[Address(RVA = "0x20797B0", Offset = "0x2078BB0", Length = "0xDF")]
		[Token(Token = "0x6001089")]
		public override bool Equals(TypeName other) { }

		[Address(RVA = "0x2079890", Offset = "0x2078C90", Length = "0x10F")]
		[Token(Token = "0x600108B")]
		public virtual bool Equals(object other) { }

		[Token(Token = "0x6001088")]
		public abstract string get_DisplayName() { }

		[Address(RVA = "0x20799A0", Offset = "0x2078DA0", Length = "0x3C")]
		[Token(Token = "0x600108A")]
		public virtual int GetHashCode() { }

	}


}

