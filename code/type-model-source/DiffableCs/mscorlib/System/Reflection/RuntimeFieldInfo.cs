namespace System.Reflection;

[Token(Token = "0x200051A")]
internal class RuntimeFieldInfo : RtFieldInfo, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001471")]
	internal IntPtr klass; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001472")]
	internal RuntimeFieldHandle fhandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001473")]
	private string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001474")]
	private Type type; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001475")]
	private FieldAttributes attrs; //Field offset: 0x30

	[Token(Token = "0x170004CA")]
	public virtual FieldAttributes Attributes
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x600246D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170004C7")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002463")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004CE")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F65F30", Offset = "0x1F65330", Length = "0x7")]
		[Token(Token = "0x6002473")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170004CB")]
	public virtual RuntimeFieldHandle FieldHandle
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600246E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004CC")]
	public virtual Type FieldType
	{
		[Address(RVA = "0x1F65F40", Offset = "0x1F65340", Length = "0x5E")]
		[Token(Token = "0x6002470")]
		 get { } //Length: 94
	}

	[Token(Token = "0x170004D0")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
		[Token(Token = "0x6002480")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C8")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F65710", Offset = "0x1F64B10", Length = "0x89")]
		[Token(Token = "0x6002464")]
		 get { } //Length: 137
	}

	[Token(Token = "0x170004CF")]
	public virtual string Name
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6002474")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004CD")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F66020", Offset = "0x1F65420", Length = "0x7")]
		[Token(Token = "0x6002472")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170004C9")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x1F65FA0", Offset = "0x1F653A0", Length = "0x7D")]
		[Token(Token = "0x6002466")]
		private get { } //Length: 125
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6002482")]
	public RuntimeFieldInfo() { }

	[Address(RVA = "0x1F651D0", Offset = "0x1F645D0", Length = "0x1B7")]
	[Token(Token = "0x600246A")]
	internal virtual void CheckConsistency(object target) { }

	[Address(RVA = "0x1F65390", Offset = "0x1F64790", Length = "0x93")]
	[Token(Token = "0x600247F")]
	private void CheckGeneric() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x600246D")]
	public virtual FieldAttributes get_Attributes() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6002463")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x1F65F30", Offset = "0x1F65330", Length = "0x7")]
	[Token(Token = "0x6002473")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600246E")]
	public virtual RuntimeFieldHandle get_FieldHandle() { }

	[Address(RVA = "0x1F65F40", Offset = "0x1F65340", Length = "0x5E")]
	[Token(Token = "0x6002470")]
	public virtual Type get_FieldType() { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x6002481")]
	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x6002480")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x1F65710", Offset = "0x1F64B10", Length = "0x89")]
	[Token(Token = "0x6002464")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6002474")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F66020", Offset = "0x1F65420", Length = "0x7")]
	[Token(Token = "0x6002472")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F65FA0", Offset = "0x1F653A0", Length = "0x7D")]
	[Token(Token = "0x6002466")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x1F65490", Offset = "0x1F64890", Length = "0x6B")]
	[Token(Token = "0x6002477")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F65430", Offset = "0x1F64830", Length = "0x59")]
	[Token(Token = "0x6002476")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F65500", Offset = "0x1F64900", Length = "0x7D")]
	[Token(Token = "0x6002465")]
	internal RuntimeType GetDeclaringTypeInternal() { }

	[Address(RVA = "0x1F65580", Offset = "0x1F64980", Length = "0x5")]
	[Token(Token = "0x6002478")]
	internal virtual int GetFieldOffset() { }

	[Address(RVA = "0x1F65590", Offset = "0x1F64990", Length = "0x157")]
	[Token(Token = "0x6002468")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F656F0", Offset = "0x1F64AF0", Length = "0x5")]
	[Token(Token = "0x6002471")]
	private Type GetParentType(bool declaring) { }

	[Address(RVA = "0x1F65700", Offset = "0x1F64B00", Length = "0x5")]
	[Token(Token = "0x600247E")]
	public virtual object GetRawConstantValue() { }

	[Address(RVA = "0x1F65710", Offset = "0x1F64B10", Length = "0x89")]
	[Token(Token = "0x6002467")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x1F657B0", Offset = "0x1F64BB0", Length = "0x1A6")]
	[Token(Token = "0x600247A")]
	public virtual object GetValue(object obj) { }

	[Address(RVA = "0x1F657A0", Offset = "0x1F64BA0", Length = "0x5")]
	[Token(Token = "0x6002479")]
	private object GetValueInternal(object obj) { }

	[Address(RVA = "0x1F65960", Offset = "0x1F64D60", Length = "0x6B")]
	[Token(Token = "0x6002475")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F659D0", Offset = "0x1F64DD0", Length = "0x5")]
	[Token(Token = "0x600246F")]
	private Type ResolveType() { }

	[Address(RVA = "0x1F65B80", Offset = "0x1F64F80", Length = "0x2DA")]
	[Token(Token = "0x600247D")]
	public virtual void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[Address(RVA = "0x1F659E0", Offset = "0x1F64DE0", Length = "0x181")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600246C")]
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	[Address(RVA = "0x1F65B70", Offset = "0x1F64F70", Length = "0x5")]
	[Token(Token = "0x600247C")]
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	[Address(RVA = "0x1F65E60", Offset = "0x1F65260", Length = "0x56")]
	[Token(Token = "0x600247B")]
	public virtual string ToString() { }

	[Address(RVA = "0x1F657A0", Offset = "0x1F64BA0", Length = "0x5")]
	[Token(Token = "0x6002469")]
	internal virtual object UnsafeGetValue(object obj) { }

	[Address(RVA = "0x1F65EC0", Offset = "0x1F652C0", Length = "0x6B")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600246B")]
	internal virtual void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

