namespace System.Reflection;

[Token(Token = "0x2000522")]
internal class RuntimePropertyInfo : PropertyInfo, ISerializable
{
	[Token(Token = "0x2000524")]
	private sealed class Getter : MulticastDelegate
	{

		[Address(RVA = "0x1C3F6A0", Offset = "0x1C3EAA0", Length = "0x111")]
		[Token(Token = "0x6002520")]
		public Getter`2(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6002521")]
		public override R Invoke(T _this) { }

	}

	[Token(Token = "0x2000523")]
	private sealed class GetterAdapter : MulticastDelegate
	{

		[Address(RVA = "0x1BB1770", Offset = "0x1BB0B70", Length = "0x124")]
		[Token(Token = "0x600251E")]
		public GetterAdapter(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600251F")]
		public override object Invoke(object _this) { }

	}

	[Token(Token = "0x2000525")]
	private sealed class StaticGetter : MulticastDelegate
	{

		[Address(RVA = "0xFCF070", Offset = "0xFCE470", Length = "0xA9")]
		[Token(Token = "0x6002522")]
		public StaticGetter`1(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6002523")]
		public override R Invoke() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001496")]
	internal IntPtr klass; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001497")]
	internal IntPtr prop; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001498")]
	private MonoPropertyInfo info; //Field offset: 0x20
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001499")]
	private PInfo cached; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400149A")]
	private GetterAdapter cached_getter; //Field offset: 0x58

	[Token(Token = "0x170004F1")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60024FE")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004F4")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x1F6AE10", Offset = "0x1F6A210", Length = "0x30")]
		[Token(Token = "0x6002508")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170004F5")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1F6AE40", Offset = "0x1F6A240", Length = "0x30")]
		[Token(Token = "0x6002509")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170004F8")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1F6AE70", Offset = "0x1F6A270", Length = "0x36")]
		[Token(Token = "0x600250C")]
		 get { } //Length: 54
	}

	[Token(Token = "0x170004FA")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
		[Token(Token = "0x6002519")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004F2")]
	public virtual Module Module
	{
		[Address(RVA = "0x1F6A8A0", Offset = "0x1F69CA0", Length = "0x89")]
		[Token(Token = "0x60024FF")]
		 get { } //Length: 137
	}

	[Token(Token = "0x170004F9")]
	public virtual string Name
	{
		[Address(RVA = "0x1F6AEB0", Offset = "0x1F6A2B0", Length = "0x36")]
		[Token(Token = "0x600250D")]
		 get { } //Length: 54
	}

	[Token(Token = "0x170004F6")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0x1F6AEF0", Offset = "0x1F6A2F0", Length = "0xAA")]
		[Token(Token = "0x600250A")]
		 get { } //Length: 170
	}

	[Token(Token = "0x170004F7")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1F6B020", Offset = "0x1F6A420", Length = "0x36")]
		[Token(Token = "0x600250B")]
		 get { } //Length: 54
	}

	[Token(Token = "0x170004F3")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x1F6AFA0", Offset = "0x1F6A3A0", Length = "0x7D")]
		[Token(Token = "0x6002501")]
		private get { } //Length: 125
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600251D")]
	public RuntimePropertyInfo() { }

	[Address(RVA = "0x1F69E20", Offset = "0x1F69220", Length = "0x32")]
	[Token(Token = "0x6002507")]
	private void CachePropertyInfo(PInfo flags) { }

	[Address(RVA = "0x1F69E60", Offset = "0x1F69260", Length = "0x2E0")]
	[Token(Token = "0x6002504")]
	private string FormatNameAndSig(bool serialization) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60024FE")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x1F6AE10", Offset = "0x1F6A210", Length = "0x30")]
	[Token(Token = "0x6002508")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x1F6AE40", Offset = "0x1F6A240", Length = "0x30")]
	[Token(Token = "0x6002509")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1F6AE70", Offset = "0x1F6A270", Length = "0x36")]
	[Token(Token = "0x600250C")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x600251A")]
	internal static int get_metadata_token(RuntimePropertyInfo monoProperty) { }

	[Address(RVA = "0x1F64930", Offset = "0x1F63D30", Length = "0x5")]
	[Token(Token = "0x6002519")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x1F6A8A0", Offset = "0x1F69CA0", Length = "0x89")]
	[Token(Token = "0x60024FF")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x1F6AEB0", Offset = "0x1F6A2B0", Length = "0x36")]
	[Token(Token = "0x600250D")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F6B060", Offset = "0x1F6A460", Length = "0x5")]
	[Token(Token = "0x60024FD")]
	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info) { }

	[Address(RVA = "0x1F6AEF0", Offset = "0x1F6A2F0", Length = "0xAA")]
	[Token(Token = "0x600250A")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x1F6B020", Offset = "0x1F6A420", Length = "0x36")]
	[Token(Token = "0x600250B")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1F6AFA0", Offset = "0x1F6A3A0", Length = "0x7D")]
	[Token(Token = "0x6002501")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x1F6A1A0", Offset = "0x1F695A0", Length = "0x5C")]
	[Token(Token = "0x6002513")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F6A150", Offset = "0x1F69550", Length = "0x4C")]
	[Token(Token = "0x6002512")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F6A200", Offset = "0x1F69600", Length = "0x7D")]
	[Token(Token = "0x6002500")]
	internal RuntimeType GetDeclaringTypeInternal() { }

	[Address(RVA = "0x1F6A280", Offset = "0x1F69680", Length = "0x6F")]
	[Token(Token = "0x600250E")]
	public virtual MethodInfo GetGetMethod(bool nonPublic) { }

	[Address(RVA = "0x1F6A2F0", Offset = "0x1F696F0", Length = "0x385")]
	[Token(Token = "0x600250F")]
	public virtual ParameterInfo[] GetIndexParameters() { }

	[Address(RVA = "0x1F6A680", Offset = "0x1F69A80", Length = "0x16D")]
	[Token(Token = "0x6002505")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F6A7F0", Offset = "0x1F69BF0", Length = "0xAC")]
	[Token(Token = "0x600251C")]
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	[Address(RVA = "0x1F6A8A0", Offset = "0x1F69CA0", Length = "0x89")]
	[Token(Token = "0x6002502")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x1F6A930", Offset = "0x1F69D30", Length = "0x6F")]
	[Token(Token = "0x6002510")]
	public virtual MethodInfo GetSetMethod(bool nonPublic) { }

	[Address(RVA = "0x8EF9E0", Offset = "0x8EEDE0", Length = "0x12E")]
	[Token(Token = "0x6002514")]
	private static object GetterAdapterFrame(Getter<T, R> getter, object obj) { }

	[Address(RVA = "0x1F62E80", Offset = "0x1F62280", Length = "0x36")]
	[Token(Token = "0x6002516")]
	public virtual object GetValue(object obj, Object[] index) { }

	[Address(RVA = "0x1F6A9A0", Offset = "0x1F69DA0", Length = "0x1A4")]
	[Token(Token = "0x6002517")]
	public virtual object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[Address(RVA = "0x1F6B070", Offset = "0x1F6A470", Length = "0x5")]
	[Token(Token = "0x600251B")]
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	[Address(RVA = "0x1F6AB50", Offset = "0x1F69F50", Length = "0x5C")]
	[Token(Token = "0x6002511")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F6ABB0", Offset = "0x1F69FB0", Length = "0xA")]
	[Token(Token = "0x6002506")]
	internal string SerializationToString() { }

	[Address(RVA = "0x1F6ABC0", Offset = "0x1F69FC0", Length = "0x239")]
	[Token(Token = "0x6002518")]
	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[Address(RVA = "0x8EFB10", Offset = "0x8EEF10", Length = "0xAD")]
	[Token(Token = "0x6002515")]
	private static object StaticGetterAdapterFrame(StaticGetter<R> getter, object obj) { }

	[Address(RVA = "0x1F6AE00", Offset = "0x1F6A200", Length = "0xA")]
	[Token(Token = "0x6002503")]
	public virtual string ToString() { }

}

