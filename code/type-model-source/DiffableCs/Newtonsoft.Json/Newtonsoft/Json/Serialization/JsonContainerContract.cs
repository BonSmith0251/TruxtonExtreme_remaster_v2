namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x2000113")]
public class JsonContainerContract : JsonContract
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400051C")]
	private JsonContract _itemContract; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400051D")]
	private JsonContract _finalItemContract; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400051E")]
	private JsonConverter <ItemConverter>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400051F")]
	private Nullable<Boolean> <ItemIsReference>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000520")]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000521")]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; //Field offset: 0xB4

	[Token(Token = "0x17000103")]
	internal JsonContract FinalItemContract
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60007DE")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000102")]
	internal JsonContract ItemContract
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60007DC")]
		internal get { } //Length: 8
		[Address(RVA = "0x21401C0", Offset = "0x213F5C0", Length = "0x6E")]
		[Token(Token = "0x60007DD")]
		internal set { } //Length: 110
	}

	[Token(Token = "0x17000104")]
	public JsonConverter ItemConverter
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007DF")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60007E0")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000105")]
	public Nullable<Boolean> ItemIsReference
	{
		[Address(RVA = "0x2140190", Offset = "0x213F590", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007E1")]
		 get { } //Length: 8
		[Address(RVA = "0x2140230", Offset = "0x213F630", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007E2")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000106")]
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling
	{
		[Address(RVA = "0x21401A0", Offset = "0x213F5A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007E3")]
		 get { } //Length: 8
		[Address(RVA = "0x2140240", Offset = "0x213F640", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007E4")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000107")]
	public Nullable<TypeNameHandling> ItemTypeNameHandling
	{
		[Address(RVA = "0x21401B0", Offset = "0x213F5B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007E5")]
		 get { } //Length: 8
		[Address(RVA = "0x2140250", Offset = "0x213F650", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007E6")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x2140060", Offset = "0x213F460", Length = "0x121")]
	[NullableContext(1)]
	[Token(Token = "0x60007E7")]
	internal JsonContainerContract(Type underlyingType) { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60007DE")]
	internal JsonContract get_FinalItemContract() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60007DC")]
	internal JsonContract get_ItemContract() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007DF")]
	public JsonConverter get_ItemConverter() { }

	[Address(RVA = "0x2140190", Offset = "0x213F590", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007E1")]
	public Nullable<Boolean> get_ItemIsReference() { }

	[Address(RVA = "0x21401A0", Offset = "0x213F5A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007E3")]
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[Address(RVA = "0x21401B0", Offset = "0x213F5B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007E5")]
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[Address(RVA = "0x21401C0", Offset = "0x213F5C0", Length = "0x6E")]
	[Token(Token = "0x60007DD")]
	internal void set_ItemContract(JsonContract value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60007E0")]
	public void set_ItemConverter(JsonConverter value) { }

	[Address(RVA = "0x2140230", Offset = "0x213F630", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007E2")]
	public void set_ItemIsReference(Nullable<Boolean> value) { }

	[Address(RVA = "0x2140240", Offset = "0x213F640", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007E4")]
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[Address(RVA = "0x2140250", Offset = "0x213F650", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007E6")]
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

}

