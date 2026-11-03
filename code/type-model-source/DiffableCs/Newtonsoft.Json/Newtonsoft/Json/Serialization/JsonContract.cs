namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000119")]
public abstract class JsonContract
{
	[CompilerGenerated]
	[Token(Token = "0x200011A")]
	private sealed class <>c__DisplayClass57_0
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(0)]
		[Token(Token = "0x4000541")]
		public MethodInfo callbackMethodInfo; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000812")]
		public <>c__DisplayClass57_0() { }

		[Address(RVA = "0x21553E0", Offset = "0x21547E0", Length = "0xF3")]
		[Token(Token = "0x6000813")]
		internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200011B")]
	private sealed class <>c__DisplayClass58_0
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(0)]
		[Token(Token = "0x4000542")]
		public MethodInfo callbackMethodInfo; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000814")]
		public <>c__DisplayClass58_0() { }

		[Address(RVA = "0x21554E0", Offset = "0x21548E0", Length = "0x14D")]
		[Token(Token = "0x6000815")]
		internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400052C")]
	internal bool IsNullable; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400052D")]
	internal bool IsConvertable; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x400052E")]
	internal bool IsEnum; //Field offset: 0x12
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400052F")]
	internal Type NonNullableUnderlyingType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000530")]
	internal ReadType InternalReadType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000531")]
	internal JsonContractType ContractType; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000532")]
	internal bool IsReadOnlyOrFixedSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000533")]
	internal bool IsSealed; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000534")]
	internal bool IsInstantiable; //Field offset: 0x2A
	[FieldOffset(Offset = "0x30")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000535")]
	private List<SerializationCallback> _onDeserializedCallbacks; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000536")]
	private List<SerializationCallback> _onDeserializingCallbacks; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000537")]
	private List<SerializationCallback> _onSerializedCallbacks; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000538")]
	private List<SerializationCallback> _onSerializingCallbacks; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000539")]
	private List<SerializationErrorCallback> _onErrorCallbacks; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400053A")]
	private Type _createdType; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400053B")]
	private readonly Type <UnderlyingType>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400053C")]
	private Nullable<Boolean> <IsReference>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Nullable(2)]
	[Token(Token = "0x400053D")]
	private JsonConverter <Converter>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Nullable(2)]
	[Token(Token = "0x400053E")]
	private JsonConverter <InternalConverter>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400053F")]
	private Func<Object> <DefaultCreator>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000540")]
	private bool <DefaultCreatorNonPublic>k__BackingField; //Field offset: 0x88

	[Nullable(2)]
	[Token(Token = "0x1700010B")]
	public JsonConverter Converter
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x60007FD")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x60007FE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000109")]
	public Type CreatedType
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60007F9")]
		 get { } //Length: 5
		[Address(RVA = "0x2140F40", Offset = "0x2140340", Length = "0xF8")]
		[Token(Token = "0x60007FA")]
		 set { } //Length: 248
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x17000112")]
	public Func<Object> DefaultCreator
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000806")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x6000807")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000113")]
	public bool DefaultCreatorNonPublic
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000808")]
		 get { } //Length: 8
		[Address(RVA = "0x2141040", Offset = "0x2140440", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000809")]
		 set { } //Length: 7
	}

	[Nullable(2)]
	[Token(Token = "0x1700010C")]
	public internal JsonConverter InternalConverter
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x60007FF")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000800")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700010A")]
	public Nullable<Boolean> IsReference
	{
		[Address(RVA = "0x2140CB0", Offset = "0x21400B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007FB")]
		 get { } //Length: 5
		[Address(RVA = "0x2141050", Offset = "0x2140450", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007FC")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700010D")]
	public IList<SerializationCallback> OnDeserializedCallbacks
	{
		[Address(RVA = "0x2140CC0", Offset = "0x21400C0", Length = "0x7A")]
		[Token(Token = "0x6000801")]
		 get { } //Length: 122
	}

	[Token(Token = "0x1700010E")]
	public IList<SerializationCallback> OnDeserializingCallbacks
	{
		[Address(RVA = "0x2140D40", Offset = "0x2140140", Length = "0x7A")]
		[Token(Token = "0x6000802")]
		 get { } //Length: 122
	}

	[Token(Token = "0x17000111")]
	public IList<SerializationErrorCallback> OnErrorCallbacks
	{
		[Address(RVA = "0x2140DC0", Offset = "0x21401C0", Length = "0x7A")]
		[Token(Token = "0x6000805")]
		 get { } //Length: 122
	}

	[Token(Token = "0x1700010F")]
	public IList<SerializationCallback> OnSerializedCallbacks
	{
		[Address(RVA = "0x2140E40", Offset = "0x2140240", Length = "0x7A")]
		[Token(Token = "0x6000803")]
		 get { } //Length: 122
	}

	[Token(Token = "0x17000110")]
	public IList<SerializationCallback> OnSerializingCallbacks
	{
		[Address(RVA = "0x2140EC0", Offset = "0x21402C0", Length = "0x7A")]
		[Token(Token = "0x6000804")]
		 get { } //Length: 122
	}

	[Token(Token = "0x17000108")]
	public Type UnderlyingType
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007F8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2140B00", Offset = "0x213FF00", Length = "0x1A6")]
	[Token(Token = "0x600080A")]
	internal JsonContract(Type underlyingType) { }

	[Address(RVA = "0x2140260", Offset = "0x213F660", Length = "0xA6")]
	[Token(Token = "0x6000810")]
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	[Address(RVA = "0x2140310", Offset = "0x213F710", Length = "0x189")]
	[Token(Token = "0x6000811")]
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x60007FD")]
	public JsonConverter get_Converter() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60007F9")]
	public Type get_CreatedType() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000806")]
	public Func<Object> get_DefaultCreator() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000808")]
	public bool get_DefaultCreatorNonPublic() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x60007FF")]
	public JsonConverter get_InternalConverter() { }

	[Address(RVA = "0x2140CB0", Offset = "0x21400B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007FB")]
	public Nullable<Boolean> get_IsReference() { }

	[Address(RVA = "0x2140CC0", Offset = "0x21400C0", Length = "0x7A")]
	[Token(Token = "0x6000801")]
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	[Address(RVA = "0x2140D40", Offset = "0x2140140", Length = "0x7A")]
	[Token(Token = "0x6000802")]
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	[Address(RVA = "0x2140DC0", Offset = "0x21401C0", Length = "0x7A")]
	[Token(Token = "0x6000805")]
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[Address(RVA = "0x2140E40", Offset = "0x2140240", Length = "0x7A")]
	[Token(Token = "0x6000803")]
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	[Address(RVA = "0x2140EC0", Offset = "0x21402C0", Length = "0x7A")]
	[Token(Token = "0x6000804")]
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007F8")]
	public Type get_UnderlyingType() { }

	[Address(RVA = "0x21404A0", Offset = "0x213F8A0", Length = "0x13D")]
	[Token(Token = "0x600080E")]
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	[Address(RVA = "0x21405E0", Offset = "0x213F9E0", Length = "0x13D")]
	[Token(Token = "0x600080D")]
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	[Address(RVA = "0x2140720", Offset = "0x213FB20", Length = "0x15D")]
	[Token(Token = "0x600080F")]
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	[Address(RVA = "0x2140880", Offset = "0x213FC80", Length = "0x13D")]
	[Token(Token = "0x600080C")]
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	[Address(RVA = "0x21409C0", Offset = "0x213FDC0", Length = "0x13D")]
	[Token(Token = "0x600080B")]
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x60007FE")]
	public void set_Converter(JsonConverter value) { }

	[Address(RVA = "0x2140F40", Offset = "0x2140340", Length = "0xF8")]
	[Token(Token = "0x60007FA")]
	public void set_CreatedType(Type value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[CompilerGenerated]
	[Token(Token = "0x6000807")]
	public void set_DefaultCreator(Func<Object> value) { }

	[Address(RVA = "0x2141040", Offset = "0x2140440", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000809")]
	public void set_DefaultCreatorNonPublic(bool value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000800")]
	internal void set_InternalConverter(JsonConverter value) { }

	[Address(RVA = "0x2141050", Offset = "0x2140450", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007FC")]
	public void set_IsReference(Nullable<Boolean> value) { }

}

