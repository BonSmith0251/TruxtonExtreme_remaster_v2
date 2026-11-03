namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001B1")]
public class DiscriminatedUnionConverter : JsonConverter
{
	[CompilerGenerated]
	[Token(Token = "0x20001B4")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007FD")]
		public int tag; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000EBB")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x1E17C30", Offset = "0x1E17030", Length = "0x1C")]
		[NullableContext(0)]
		[Token(Token = "0x6000EBC")]
		internal bool <WriteJson>b__0(UnionCase c) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001B5")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(0)]
		[Token(Token = "0x40007FE")]
		public string caseName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Nullable(0)]
		[Token(Token = "0x40007FF")]
		public Func<UnionCase, Boolean> <>9__0; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000EBD")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x21A8EB0", Offset = "0x21A82B0", Length = "0x25")]
		[NullableContext(0)]
		[Token(Token = "0x6000EBE")]
		internal bool <ReadJson>b__0(UnionCase c) { }

	}

	[Nullable(0)]
	[Token(Token = "0x20001B2")]
	public class Union
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007F6")]
		public readonly FSharpFunction TagReader; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007F7")]
		public readonly List<UnionCase> Cases; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000EB9")]
		public Union(FSharpFunction tagReader, List<UnionCase> cases) { }

	}

	[Nullable(0)]
	[Token(Token = "0x20001B3")]
	public class UnionCase
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007F8")]
		public readonly int Tag; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007F9")]
		public readonly string Name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007FA")]
		public readonly PropertyInfo[] Fields; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007FB")]
		public readonly FSharpFunction FieldReader; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007FC")]
		public readonly FSharpFunction Constructor; //Field offset: 0x30

		[Address(RVA = "0x21A8F50", Offset = "0x21A8350", Length = "0x81")]
		[Token(Token = "0x6000EBA")]
		public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }

	}

	[Token(Token = "0x40007F2")]
	private const string CasePropertyName = "Case"; //Field offset: 0x0
	[Token(Token = "0x40007F3")]
	private const string FieldsPropertyName = "Fields"; //Field offset: 0x0
	[Token(Token = "0x40007F4")]
	private static readonly ThreadSafeStore<Type, Union> UnionCache; //Field offset: 0x0
	[Token(Token = "0x40007F5")]
	private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache; //Field offset: 0x8

	[Address(RVA = "0x2194800", Offset = "0x2193C00", Length = "0x16B")]
	[Token(Token = "0x6000EB8")]
	private static DiscriminatedUnionConverter() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000EB7")]
	public DiscriminatedUnionConverter() { }

	[Address(RVA = "0x2192D10", Offset = "0x2192110", Length = "0x26A")]
	[Token(Token = "0x6000EB6")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x21931D0", Offset = "0x21925D0", Length = "0x923")]
	[Token(Token = "0x6000EB3")]
	private static Union CreateUnion(Type t) { }

	[Address(RVA = "0x2192F80", Offset = "0x2192380", Length = "0x240")]
	[Token(Token = "0x6000EB2")]
	private static Type CreateUnionTypeLookup(Type t) { }

	[Address(RVA = "0x2193B00", Offset = "0x2192F00", Length = "0x7BF")]
	[Token(Token = "0x6000EB5")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x21942C0", Offset = "0x21936C0", Length = "0x539")]
	[Token(Token = "0x6000EB4")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

