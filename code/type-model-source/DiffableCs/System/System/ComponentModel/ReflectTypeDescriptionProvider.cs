namespace System.ComponentModel;

[Token(Token = "0x20001B1")]
internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
{
	[Token(Token = "0x20001B2")]
	private class ReflectedTypeData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006B1")]
		private Type _type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006B2")]
		private AttributeCollection _attributes; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006B3")]
		private EventDescriptorCollection _events; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006B4")]
		private PropertyDescriptorCollection _properties; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006B5")]
		private TypeConverter _converter; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006B6")]
		private Object[] _editors; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40006B7")]
		private Type[] _editorTypes; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40006B8")]
		private int _editorCount; //Field offset: 0x48

		[Token(Token = "0x1700020D")]
		internal bool IsPopulated
		{
			[Address(RVA = "0x2677D60", Offset = "0x2677160", Length = "0x23")]
			[Token(Token = "0x6000AB7")]
			internal get { } //Length: 35
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000AB6")]
		internal ReflectedTypeData(Type type) { }

		[Address(RVA = "0x2677D60", Offset = "0x2677160", Length = "0x23")]
		[Token(Token = "0x6000AB7")]
		internal bool get_IsPopulated() { }

		[Address(RVA = "0x2675CE0", Offset = "0x26750E0", Length = "0x55C")]
		[Token(Token = "0x6000AB8")]
		internal AttributeCollection GetAttributes() { }

		[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
		[Token(Token = "0x6000AB9")]
		internal string GetClassName(object instance) { }

		[Address(RVA = "0x2676240", Offset = "0x2675640", Length = "0xB5")]
		[Token(Token = "0x6000ABA")]
		internal string GetComponentName(object instance) { }

		[Address(RVA = "0x2676300", Offset = "0x2675700", Length = "0x563")]
		[Token(Token = "0x6000ABB")]
		internal TypeConverter GetConverter(object instance) { }

		[Address(RVA = "0x2676870", Offset = "0x2675C70", Length = "0x18D")]
		[Token(Token = "0x6000ABC")]
		internal EventDescriptor GetDefaultEvent(object instance) { }

		[Address(RVA = "0x2676A00", Offset = "0x2675E00", Length = "0x18D")]
		[Token(Token = "0x6000ABD")]
		internal PropertyDescriptor GetDefaultProperty(object instance) { }

		[Address(RVA = "0x2676DE0", Offset = "0x26761E0", Length = "0x647")]
		[Token(Token = "0x6000ABE")]
		internal object GetEditor(object instance, Type editorBaseType) { }

		[Address(RVA = "0x2676B90", Offset = "0x2675F90", Length = "0x24A")]
		[Token(Token = "0x6000ABF")]
		private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

		[Address(RVA = "0x2677430", Offset = "0x2676830", Length = "0x357")]
		[Token(Token = "0x6000AC0")]
		internal EventDescriptorCollection GetEvents() { }

		[Address(RVA = "0x2677790", Offset = "0x2676B90", Length = "0x3A0")]
		[Token(Token = "0x6000AC1")]
		internal PropertyDescriptorCollection GetProperties() { }

		[Address(RVA = "0x2677B40", Offset = "0x2676F40", Length = "0x19F")]
		[Token(Token = "0x6000AC2")]
		private Type GetTypeFromName(string typeName) { }

		[Address(RVA = "0x2677CE0", Offset = "0x26770E0", Length = "0x77")]
		[Token(Token = "0x6000AC3")]
		internal void Refresh() { }

	}

	[Token(Token = "0x40006A2")]
	private static Type[] _typeConstructor; //Field offset: 0x0
	[Token(Token = "0x40006A3")]
	private static Hashtable _editorTables; //Field offset: 0x8
	[Token(Token = "0x40006A4")]
	private static Hashtable _intrinsicTypeConverters; //Field offset: 0x10
	[Token(Token = "0x40006A5")]
	private static object _intrinsicReferenceKey; //Field offset: 0x18
	[Token(Token = "0x40006A6")]
	private static object _intrinsicNullableKey; //Field offset: 0x20
	[Token(Token = "0x40006A7")]
	private static object _dictionaryKey; //Field offset: 0x28
	[Token(Token = "0x40006A8")]
	private static Hashtable _propertyCache; //Field offset: 0x30
	[Token(Token = "0x40006A9")]
	private static Hashtable _eventCache; //Field offset: 0x38
	[Token(Token = "0x40006AA")]
	private static Hashtable _attributeCache; //Field offset: 0x40
	[Token(Token = "0x40006AB")]
	private static Hashtable _extendedPropertyCache; //Field offset: 0x48
	[Token(Token = "0x40006AC")]
	private static readonly Guid _extenderProviderKey; //Field offset: 0x50
	[Token(Token = "0x40006AD")]
	private static readonly Guid _extenderPropertiesKey; //Field offset: 0x60
	[Token(Token = "0x40006AE")]
	private static readonly Guid _extenderProviderPropertiesKey; //Field offset: 0x70
	[Token(Token = "0x40006AF")]
	private static readonly Type[] _skipInterfaceAttributeList; //Field offset: 0x80
	[Token(Token = "0x40006B0")]
	private static object _internalSyncObject; //Field offset: 0x88
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006A1")]
	private Hashtable _typeData; //Field offset: 0x20

	[Token(Token = "0x1700020C")]
	private static Hashtable IntrinsicTypeConverters
	{
		[Address(RVA = "0x26753D0", Offset = "0x26747D0", Length = "0x90F")]
		[Token(Token = "0x6000A8D")]
		private get { } //Length: 2319
	}

	[Address(RVA = "0x2674FD0", Offset = "0x26743D0", Length = "0x3F9")]
	[Token(Token = "0x6000AB5")]
	private static ReflectTypeDescriptionProvider() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000A8C")]
	internal ReflectTypeDescriptionProvider() { }

	[Address(RVA = "0x266FED0", Offset = "0x266F2D0", Length = "0x1F5")]
	[Token(Token = "0x6000A8E")]
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	[Address(RVA = "0x266FDC0", Offset = "0x266F1C0", Length = "0x10C")]
	[Token(Token = "0x6000A8F")]
	private static object CreateInstance(Type objectType, Type callingType) { }

	[Address(RVA = "0x26753D0", Offset = "0x26747D0", Length = "0x90F")]
	[Token(Token = "0x6000A8D")]
	private static Hashtable get_IntrinsicTypeConverters() { }

	[Address(RVA = "0x26700D0", Offset = "0x266F4D0", Length = "0x27")]
	[Token(Token = "0x6000A90")]
	internal AttributeCollection GetAttributes(Type type) { }

	[Address(RVA = "0x2670100", Offset = "0x266F500", Length = "0x1E9")]
	[Token(Token = "0x6000A91")]
	public virtual IDictionary GetCache(object instance) { }

	[Address(RVA = "0x26702F0", Offset = "0x266F6F0", Length = "0x3A")]
	[Token(Token = "0x6000A92")]
	internal string GetClassName(Type type) { }

	[Address(RVA = "0x2670330", Offset = "0x266F730", Length = "0xCE")]
	[Token(Token = "0x6000A93")]
	internal string GetComponentName(Type type, object instance) { }

	[Address(RVA = "0x2670400", Offset = "0x266F800", Length = "0x31")]
	[Token(Token = "0x6000A94")]
	internal TypeConverter GetConverter(Type type, object instance) { }

	[Address(RVA = "0x2670440", Offset = "0x266F840", Length = "0x31")]
	[Token(Token = "0x6000A95")]
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	[Address(RVA = "0x2670480", Offset = "0x266F880", Length = "0x31")]
	[Token(Token = "0x6000A96")]
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	[Address(RVA = "0x26709B0", Offset = "0x266FDB0", Length = "0x40")]
	[Token(Token = "0x6000A97")]
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	[Address(RVA = "0x26704C0", Offset = "0x266F8C0", Length = "0x4EE")]
	[Token(Token = "0x6000A98")]
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	[Address(RVA = "0x2670A00", Offset = "0x266FE00", Length = "0x27")]
	[Token(Token = "0x6000A99")]
	internal EventDescriptorCollection GetEvents(Type type) { }

	[Address(RVA = "0x2670A30", Offset = "0x266FE30", Length = "0x4E")]
	[Token(Token = "0x6000A9A")]
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	[Address(RVA = "0x2670A80", Offset = "0x266FE80", Length = "0x58")]
	[Token(Token = "0x6000A9B")]
	internal string GetExtendedClassName(object instance) { }

	[Address(RVA = "0x2670AE0", Offset = "0x266FEE0", Length = "0xFD")]
	[Token(Token = "0x6000A9C")]
	internal string GetExtendedComponentName(object instance) { }

	[Address(RVA = "0x2670BE0", Offset = "0x266FFE0", Length = "0x52")]
	[Token(Token = "0x6000A9D")]
	internal TypeConverter GetExtendedConverter(object instance) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000A9E")]
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000A9F")]
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	[Address(RVA = "0x2670C40", Offset = "0x2670040", Length = "0x62")]
	[Token(Token = "0x6000AA0")]
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	[Address(RVA = "0x2670CB0", Offset = "0x26700B0", Length = "0x4E")]
	[Token(Token = "0x6000AA1")]
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	[Address(RVA = "0x2670D00", Offset = "0x2670100", Length = "0x4F7")]
	[Token(Token = "0x6000AA2")]
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	[Address(RVA = "0x2671200", Offset = "0x2670600", Length = "0x6E")]
	[Token(Token = "0x6000AA5")]
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AA6")]
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	[Address(RVA = "0x2671270", Offset = "0x2670670", Length = "0x2B5")]
	[Token(Token = "0x6000AA3")]
	protected private virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	[Address(RVA = "0x2671530", Offset = "0x2670930", Length = "0x910")]
	[Token(Token = "0x6000AA4")]
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	[Address(RVA = "0x2671E50", Offset = "0x2671250", Length = "0x27")]
	[Token(Token = "0x6000AA7")]
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	[Address(RVA = "0x2671E80", Offset = "0x2671280", Length = "0x59")]
	[Token(Token = "0x6000AA8")]
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x6000AA9")]
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	[Address(RVA = "0x2671EE0", Offset = "0x26712E0", Length = "0x2A7")]
	[Token(Token = "0x6000AAA")]
	private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AAB")]
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	[Address(RVA = "0x2672190", Offset = "0x2671590", Length = "0xE2")]
	[Token(Token = "0x6000AAC")]
	private static Type GetTypeFromName(string typeName) { }

	[Address(RVA = "0x2672280", Offset = "0x2671680", Length = "0x43")]
	[Token(Token = "0x6000AAD")]
	internal bool IsPopulated(Type type) { }

	[Address(RVA = "0x26722D0", Offset = "0x26716D0", Length = "0x4C7")]
	[Token(Token = "0x6000AAE")]
	private static Attribute[] ReflectGetAttributes(Type type) { }

	[Address(RVA = "0x26727A0", Offset = "0x2671BA0", Length = "0x4C7")]
	[Token(Token = "0x6000AAF")]
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	[Address(RVA = "0x2672C70", Offset = "0x2672070", Length = "0x707")]
	[Token(Token = "0x6000AB0")]
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	[Address(RVA = "0x2673380", Offset = "0x2672780", Length = "0xD3E")]
	[Token(Token = "0x6000AB1")]
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	[Address(RVA = "0x26740C0", Offset = "0x26734C0", Length = "0x697")]
	[Token(Token = "0x6000AB2")]
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	[Address(RVA = "0x2674760", Offset = "0x2673B60", Length = "0x88")]
	[Token(Token = "0x6000AB3")]
	internal void Refresh(Type type) { }

	[Address(RVA = "0x26747F0", Offset = "0x2673BF0", Length = "0x7DE")]
	[Token(Token = "0x6000AB4")]
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

}

