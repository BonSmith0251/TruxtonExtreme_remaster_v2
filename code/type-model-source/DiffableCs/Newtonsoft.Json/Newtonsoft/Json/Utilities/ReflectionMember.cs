namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20000E2")]
internal class ReflectionMember
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004B1")]
	private Type <MemberType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	[Token(Token = "0x40004B2")]
	private Func<Object, Object> <Getter>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	[Token(Token = "0x40004B3")]
	private Action<Object, Object> <Setter>k__BackingField; //Field offset: 0x20

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	[Token(Token = "0x170000D9")]
	public Func<Object, Object> Getter
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600069C")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600069D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000D8")]
	public Type MemberType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600069A")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600069B")]
		 set { } //Length: 13
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	[Token(Token = "0x170000DA")]
	public Action<Object, Object> Setter
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600069E")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600069F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60006A0")]
	public ReflectionMember() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600069C")]
	public Func<Object, Object> get_Getter() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600069A")]
	public Type get_MemberType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600069E")]
	public Action<Object, Object> get_Setter() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600069D")]
	public void set_Getter(Func<Object, Object> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600069B")]
	public void set_MemberType(Type value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600069F")]
	public void set_Setter(Action<Object, Object> value) { }

}

