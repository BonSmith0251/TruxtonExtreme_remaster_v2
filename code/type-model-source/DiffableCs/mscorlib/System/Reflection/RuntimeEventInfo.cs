namespace System.Reflection;

[Token(Token = "0x2000518")]
internal sealed class RuntimeEventInfo : EventInfo, ISerializable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400146F")]
	private IntPtr klass; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001470")]
	private IntPtr handle; //Field offset: 0x20

	[Token(Token = "0x170004C1")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x1F64A50", Offset = "0x1F63E50", Length = "0x152")]
		[Token(Token = "0x600244C")]
		internal get { } //Length: 338
	}

	[Token(Token = "0x170004C3")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F650B0", Offset = "0x1F644B0", Length = "0x2F")]
		[Token(Token = "0x6002455")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170004C6")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
		[Token(Token = "0x600245C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C0")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F64F70", Offset = "0x1F64370", Length = "0x23")]
		[Token(Token = "0x600244B")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170004C5")]
	public virtual string Name
	{
		[Address(RVA = "0x1F650E0", Offset = "0x1F644E0", Length = "0x2F")]
		[Token(Token = "0x6002457")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170004C4")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F65190", Offset = "0x1F64590", Length = "0x2F")]
		[Token(Token = "0x6002456")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170004C2")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x1F65110", Offset = "0x1F64510", Length = "0x7D")]
		[Token(Token = "0x600244E")]
		private get { } //Length: 125
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x600245E")]
	public RuntimeEventInfo() { }

	[Address(RVA = "0x1F64A50", Offset = "0x1F63E50", Length = "0x152")]
	[Token(Token = "0x600244C")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x1F650B0", Offset = "0x1F644B0", Length = "0x2F")]
	[Token(Token = "0x6002455")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F651C0", Offset = "0x1F645C0", Length = "0x5")]
	[Token(Token = "0x6002449")]
	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x600245D")]
	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x600245C")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x1F64F70", Offset = "0x1F64370", Length = "0x23")]
	[Token(Token = "0x600244B")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x1F650E0", Offset = "0x1F644E0", Length = "0x2F")]
	[Token(Token = "0x6002457")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F65190", Offset = "0x1F64590", Length = "0x2F")]
	[Token(Token = "0x6002456")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F65110", Offset = "0x1F64510", Length = "0x7D")]
	[Token(Token = "0x600244E")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x1F649D0", Offset = "0x1F63DD0", Length = "0x74")]
	[Token(Token = "0x6002452")]
	public virtual MethodInfo GetAddMethod(bool nonPublic) { }

	[Address(RVA = "0x1F64A50", Offset = "0x1F63E50", Length = "0x152")]
	[Token(Token = "0x6002451")]
	internal BindingFlags GetBindingFlags() { }

	[Address(RVA = "0x1F64BB0", Offset = "0x1F63FB0", Length = "0x6B")]
	[Token(Token = "0x600245B")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F64C20", Offset = "0x1F64020", Length = "0x59")]
	[Token(Token = "0x600245A")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F64C80", Offset = "0x1F64080", Length = "0x7D")]
	[Token(Token = "0x600244D")]
	internal RuntimeType GetDeclaringTypeInternal() { }

	[Address(RVA = "0x1F64D00", Offset = "0x1F64100", Length = "0x32")]
	[Token(Token = "0x600244A")]
	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	[Address(RVA = "0x1F64D40", Offset = "0x1F64140", Length = "0x12C")]
	[Token(Token = "0x6002450")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F64E70", Offset = "0x1F64270", Length = "0x74")]
	[Token(Token = "0x6002453")]
	public virtual MethodInfo GetRaiseMethod(bool nonPublic) { }

	[Address(RVA = "0x1F64EF0", Offset = "0x1F642F0", Length = "0x74")]
	[Token(Token = "0x6002454")]
	public virtual MethodInfo GetRemoveMethod(bool nonPublic) { }

	[Address(RVA = "0x1F64F70", Offset = "0x1F64370", Length = "0x23")]
	[Token(Token = "0x600244F")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x1F64FA0", Offset = "0x1F643A0", Length = "0x6B")]
	[Token(Token = "0x6002459")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F65010", Offset = "0x1F64410", Length = "0x97")]
	[Token(Token = "0x6002458")]
	public virtual string ToString() { }

}

