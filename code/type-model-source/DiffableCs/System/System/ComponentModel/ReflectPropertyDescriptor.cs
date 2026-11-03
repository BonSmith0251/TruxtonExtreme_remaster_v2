namespace System.ComponentModel;

[Token(Token = "0x20001B0")]
internal sealed class ReflectPropertyDescriptor : PropertyDescriptor
{
	[Token(Token = "0x4000687")]
	private static readonly Type[] argsNone; //Field offset: 0x0
	[Token(Token = "0x4000688")]
	private static readonly object noValue; //Field offset: 0x8
	[Token(Token = "0x4000689")]
	private static TraceSwitch PropDescCreateSwitch; //Field offset: 0x10
	[Token(Token = "0x400068A")]
	private static TraceSwitch PropDescUsageSwitch; //Field offset: 0x18
	[Token(Token = "0x400068B")]
	private static readonly int BitDefaultValueQueried; //Field offset: 0x20
	[Token(Token = "0x400068C")]
	private static readonly int BitGetQueried; //Field offset: 0x24
	[Token(Token = "0x400068D")]
	private static readonly int BitSetQueried; //Field offset: 0x28
	[Token(Token = "0x400068E")]
	private static readonly int BitShouldSerializeQueried; //Field offset: 0x2C
	[Token(Token = "0x400068F")]
	private static readonly int BitResetQueried; //Field offset: 0x30
	[Token(Token = "0x4000690")]
	private static readonly int BitChangedQueried; //Field offset: 0x34
	[Token(Token = "0x4000691")]
	private static readonly int BitIPropChangedQueried; //Field offset: 0x38
	[Token(Token = "0x4000692")]
	private static readonly int BitReadOnlyChecked; //Field offset: 0x3C
	[Token(Token = "0x4000693")]
	private static readonly int BitAmbientValueQueried; //Field offset: 0x40
	[Token(Token = "0x4000694")]
	private static readonly int BitSetOnDemand; //Field offset: 0x44
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000695")]
	private BitVector32 state; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000696")]
	private Type componentClass; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000697")]
	private Type type; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000698")]
	private object defaultValue; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000699")]
	private object ambientValue; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400069A")]
	private PropertyInfo propInfo; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400069B")]
	private MethodInfo getMethod; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400069C")]
	private MethodInfo setMethod; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400069D")]
	private MethodInfo shouldSerializeMethod; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400069E")]
	private MethodInfo resetMethod; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400069F")]
	private EventDescriptor realChangedEvent; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40006A0")]
	private Type receiverType; //Field offset: 0xE0

	[Token(Token = "0x17000202")]
	private object AmbientValue
	{
		[Address(RVA = "0x266E750", Offset = "0x266DB50", Length = "0x1B1")]
		[Token(Token = "0x6000A73")]
		private get { } //Length: 433
	}

	[Token(Token = "0x17000203")]
	public virtual Type ComponentType
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000A74")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000204")]
	private object DefaultValue
	{
		[Address(RVA = "0x266E910", Offset = "0x266DD10", Length = "0x306")]
		[Token(Token = "0x6000A75")]
		private get { } //Length: 774
	}

	[Token(Token = "0x17000205")]
	private MethodInfo GetMethodValue
	{
		[Address(RVA = "0x266EC20", Offset = "0x266E020", Length = "0x535")]
		[Token(Token = "0x6000A76")]
		private get { } //Length: 1333
	}

	[Token(Token = "0x17000206")]
	private bool IsExtender
	{
		[Address(RVA = "0x266F160", Offset = "0x266E560", Length = "0x34")]
		[Token(Token = "0x6000A77")]
		private get { } //Length: 52
	}

	[Token(Token = "0x17000207")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x266F1A0", Offset = "0x266E5A0", Length = "0xFA")]
		[Token(Token = "0x6000A78")]
		 get { } //Length: 250
	}

	[Token(Token = "0x17000208")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x6000A79")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000209")]
	private MethodInfo ResetMethodValue
	{
		[Address(RVA = "0x266F2A0", Offset = "0x266E6A0", Length = "0x249")]
		[Token(Token = "0x6000A7A")]
		private get { } //Length: 585
	}

	[Token(Token = "0x1700020A")]
	private MethodInfo SetMethodValue
	{
		[Address(RVA = "0x266F4F0", Offset = "0x266E8F0", Length = "0x67F")]
		[Token(Token = "0x6000A7B")]
		private get { } //Length: 1663
	}

	[Token(Token = "0x1700020B")]
	private MethodInfo ShouldSerializeMethodValue
	{
		[Address(RVA = "0x266FB70", Offset = "0x266EF70", Length = "0x249")]
		[Token(Token = "0x6000A7C")]
		private get { } //Length: 585
	}

	[Address(RVA = "0x266DF70", Offset = "0x266D370", Length = "0x327")]
	[Token(Token = "0x6000A8B")]
	private static ReflectPropertyDescriptor() { }

	[Address(RVA = "0x266E4E0", Offset = "0x266D8E0", Length = "0xFA")]
	[Token(Token = "0x6000A72")]
	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	[Address(RVA = "0x266E2A0", Offset = "0x266D6A0", Length = "0x234")]
	[Token(Token = "0x6000A70")]
	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	[Address(RVA = "0x266E5E0", Offset = "0x266D9E0", Length = "0x161")]
	[Token(Token = "0x6000A71")]
	public ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	[Address(RVA = "0x266B680", Offset = "0x266AA80", Length = "0x246")]
	[Token(Token = "0x6000A84")]
	public virtual bool CanResetValue(object component) { }

	[Address(RVA = "0x266B8D0", Offset = "0x266ACD0", Length = "0x229")]
	[Token(Token = "0x6000A7D")]
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x6000A7E")]
	internal Type ExtenderGetReceiverType() { }

	[Address(RVA = "0x1F60FF0", Offset = "0x1F603F0", Length = "0x14")]
	[Token(Token = "0x6000A7F")]
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	[Address(RVA = "0x266BB00", Offset = "0x266AF00", Length = "0x15D")]
	[Token(Token = "0x6000A80")]
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	[Address(RVA = "0x266BC60", Offset = "0x266B060", Length = "0x3CC")]
	[Token(Token = "0x6000A81")]
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	[Address(RVA = "0x266C030", Offset = "0x266B430", Length = "0x356")]
	[Token(Token = "0x6000A82")]
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	[Address(RVA = "0x266C390", Offset = "0x266B790", Length = "0x396")]
	[Token(Token = "0x6000A83")]
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	[Address(RVA = "0x266C730", Offset = "0x266BB30", Length = "0xA0E")]
	[Token(Token = "0x6000A85")]
	protected virtual void FillAttributes(IList attributes) { }

	[Address(RVA = "0x266E750", Offset = "0x266DB50", Length = "0x1B1")]
	[Token(Token = "0x6000A73")]
	private object get_AmbientValue() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000A74")]
	public virtual Type get_ComponentType() { }

	[Address(RVA = "0x266E910", Offset = "0x266DD10", Length = "0x306")]
	[Token(Token = "0x6000A75")]
	private object get_DefaultValue() { }

	[Address(RVA = "0x266EC20", Offset = "0x266E020", Length = "0x535")]
	[Token(Token = "0x6000A76")]
	private MethodInfo get_GetMethodValue() { }

	[Address(RVA = "0x266F160", Offset = "0x266E560", Length = "0x34")]
	[Token(Token = "0x6000A77")]
	private bool get_IsExtender() { }

	[Address(RVA = "0x266F1A0", Offset = "0x266E5A0", Length = "0xFA")]
	[Token(Token = "0x6000A78")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x6000A79")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x266F2A0", Offset = "0x266E6A0", Length = "0x249")]
	[Token(Token = "0x6000A7A")]
	private MethodInfo get_ResetMethodValue() { }

	[Address(RVA = "0x266F4F0", Offset = "0x266E8F0", Length = "0x67F")]
	[Token(Token = "0x6000A7B")]
	private MethodInfo get_SetMethodValue() { }

	[Address(RVA = "0x266FB70", Offset = "0x266EF70", Length = "0x249")]
	[Token(Token = "0x6000A7C")]
	private MethodInfo get_ShouldSerializeMethodValue() { }

	[Address(RVA = "0x266D140", Offset = "0x266C540", Length = "0x2FB")]
	[Token(Token = "0x6000A86")]
	public virtual object GetValue(object component) { }

	[Address(RVA = "0x266D440", Offset = "0x266C840", Length = "0x100")]
	[Token(Token = "0x6000A87")]
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	[Address(RVA = "0x266D550", Offset = "0x266C950", Length = "0x2F9")]
	[Token(Token = "0x6000A88")]
	public virtual void ResetValue(object component) { }

	[Address(RVA = "0x266D850", Offset = "0x266CC50", Length = "0x49B")]
	[Token(Token = "0x6000A89")]
	public virtual void SetValue(object component, object value) { }

	[Address(RVA = "0x266DCF0", Offset = "0x266D0F0", Length = "0x27E")]
	[Token(Token = "0x6000A8A")]
	public virtual bool ShouldSerializeValue(object component) { }

}

