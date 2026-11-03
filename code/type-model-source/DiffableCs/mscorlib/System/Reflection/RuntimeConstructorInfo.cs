namespace System.Reflection;

[Token(Token = "0x200051D")]
internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400147E")]
	internal IntPtr mhandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400147F")]
	private string name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001480")]
	private Type reftype; //Field offset: 0x20

	[Token(Token = "0x170004E5")]
	public virtual MethodAttributes Attributes
	{
		[Address(RVA = "0x1F64880", Offset = "0x1F63C80", Length = "0x9")]
		[Token(Token = "0x60024D5")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170004E2")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60024C6")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004E6")]
	public virtual CallingConventions CallingConvention
	{
		[Address(RVA = "0x1F64890", Offset = "0x1F63C90", Length = "0x28")]
		[Token(Token = "0x60024D6")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170004E7")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x1F648C0", Offset = "0x1F63CC0", Length = "0x3C")]
		[Token(Token = "0x60024D7")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170004E9")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F64900", Offset = "0x1F63D00", Length = "0x29")]
		[Token(Token = "0x60024D9")]
		 get { } //Length: 41
	}

	[Token(Token = "0x170004EB")]
	public virtual bool IsSecurityCritical
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60024E0")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170004EC")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
		[Token(Token = "0x60024E1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004E4")]
	public virtual RuntimeMethodHandle MethodHandle
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60024D4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004E1")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F642C0", Offset = "0x1F636C0", Length = "0x8F")]
		[Token(Token = "0x60024C4")]
		 get { } //Length: 143
	}

	[Token(Token = "0x170004EA")]
	public virtual string Name
	{
		[Address(RVA = "0x1F64940", Offset = "0x1F63D40", Length = "0x10")]
		[Token(Token = "0x60024DA")]
		 get { } //Length: 16
	}

	[Token(Token = "0x170004E8")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60024D8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004E3")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x1F64950", Offset = "0x1F63D50", Length = "0x7D")]
		[Token(Token = "0x60024C7")]
		private get { } //Length: 125
	}

	[Address(RVA = "0x1F64830", Offset = "0x1F63C30", Length = "0x49")]
	[Token(Token = "0x60024E3")]
	public RuntimeConstructorInfo() { }

	[Address(RVA = "0x1F63DC0", Offset = "0x1F631C0", Length = "0x239")]
	[Token(Token = "0x60024D1")]
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F64880", Offset = "0x1F63C80", Length = "0x9")]
	[Token(Token = "0x60024D5")]
	public virtual MethodAttributes get_Attributes() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60024C6")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x1F64890", Offset = "0x1F63C90", Length = "0x28")]
	[Token(Token = "0x60024D6")]
	public virtual CallingConventions get_CallingConvention() { }

	[Address(RVA = "0x1F648C0", Offset = "0x1F63CC0", Length = "0x3C")]
	[Token(Token = "0x60024D7")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60024DF")]
	private static int get_core_clr_security_level() { }

	[Address(RVA = "0x1F64900", Offset = "0x1F63D00", Length = "0x29")]
	[Token(Token = "0x60024D9")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60024E0")]
	public virtual bool get_IsSecurityCritical() { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x60024E2")]
	internal static int get_metadata_token(RuntimeConstructorInfo method) { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x60024E1")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60024D4")]
	public virtual RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x1F642C0", Offset = "0x1F636C0", Length = "0x8F")]
	[Token(Token = "0x60024C4")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x1F64940", Offset = "0x1F63D40", Length = "0x10")]
	[Token(Token = "0x60024DA")]
	public virtual string get_Name() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60024D8")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F64950", Offset = "0x1F63D50", Length = "0x7D")]
	[Token(Token = "0x60024C7")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x1F64060", Offset = "0x1F63460", Length = "0x6B")]
	[Token(Token = "0x60024DD")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F64000", Offset = "0x1F63400", Length = "0x59")]
	[Token(Token = "0x60024DC")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F640D0", Offset = "0x1F634D0", Length = "0x2D")]
	[Token(Token = "0x60024CB")]
	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	[Address(RVA = "0x1F64100", Offset = "0x1F63500", Length = "0x179")]
	[Token(Token = "0x60024C8")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F642B0", Offset = "0x1F636B0", Length = "0xC")]
	[Token(Token = "0x60024CC")]
	public virtual ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x1F64280", Offset = "0x1F63680", Length = "0x22")]
	[Token(Token = "0x60024CE")]
	internal virtual int GetParametersCount() { }

	[Address(RVA = "0x1F642B0", Offset = "0x1F636B0", Length = "0xC")]
	[Token(Token = "0x60024CD")]
	internal virtual ParameterInfo[] GetParametersInternal() { }

	[Address(RVA = "0x1F642C0", Offset = "0x1F636C0", Length = "0x8F")]
	[Token(Token = "0x60024C5")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x1F64350", Offset = "0x1F63750", Length = "0x5")]
	[Token(Token = "0x60024CF")]
	internal object InternalInvoke(object obj, Object[] parameters, out Exception exc) { }

	[Address(RVA = "0x1F64360", Offset = "0x1F63760", Length = "0xE4")]
	[Token(Token = "0x60024D2")]
	public object InternalInvoke(object obj, Object[] parameters, bool wrapExceptions) { }

	[Address(RVA = "0x1F64480", Offset = "0x1F63880", Length = "0x141")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60024D0")]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F64450", Offset = "0x1F63850", Length = "0x2E")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60024D3")]
	public virtual object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x1F645D0", Offset = "0x1F639D0", Length = "0x6B")]
	[Token(Token = "0x60024DB")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F64640", Offset = "0x1F63A40", Length = "0x16A")]
	[Token(Token = "0x60024CA")]
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F647B0", Offset = "0x1F63BB0", Length = "0x16")]
	[Token(Token = "0x60024C9")]
	internal string SerializationToString() { }

	[Address(RVA = "0x1F647D0", Offset = "0x1F63BD0", Length = "0x54")]
	[Token(Token = "0x60024DE")]
	public virtual string ToString() { }

}

