namespace System.ComponentModel;

[Token(Token = "0x20001B6")]
public sealed class TypeDescriptor
{
	[Token(Token = "0x20001B7")]
	private sealed class AttributeFilterCacheItem
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006CC")]
		private Attribute[] _filter; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006CD")]
		internal ICollection FilteredMembers; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000B28")]
		internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers) { }

		[Address(RVA = "0x26798A0", Offset = "0x2678CA0", Length = "0x6B")]
		[Token(Token = "0x6000B29")]
		internal bool IsValid(Attribute[] filter) { }

	}

	[Token(Token = "0x20001B8")]
	private sealed class FilterCacheItem
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006CE")]
		private ITypeDescriptorFilterService _filterService; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006CF")]
		internal ICollection FilteredMembers; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000B2A")]
		internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

		[Address(RVA = "0x217BC80", Offset = "0x217B080", Length = "0x8")]
		[Token(Token = "0x6000B2B")]
		internal bool IsValid(ITypeDescriptorFilterService filterService) { }

	}

	[Token(Token = "0x20001B9")]
	private interface IUnimplemented
	{

	}

	[Token(Token = "0x20001BA")]
	private sealed class MemberDescriptorComparer : IComparer
	{
		[Token(Token = "0x40006D0")]
		public static readonly MemberDescriptorComparer Instance; //Field offset: 0x0

		[Address(RVA = "0x26852B0", Offset = "0x26846B0", Length = "0x67")]
		[Token(Token = "0x6000B2E")]
		private static MemberDescriptorComparer() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B2D")]
		public MemberDescriptorComparer() { }

		[Address(RVA = "0x2685170", Offset = "0x2684570", Length = "0x13A")]
		[Token(Token = "0x6000B2C")]
		public override int Compare(object left, object right) { }

	}

	[Token(Token = "0x20001BB")]
	private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006D1")]
		private ICustomTypeDescriptor _primary; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006D2")]
		private ICustomTypeDescriptor _secondary; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000B2F")]
		internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

		[Address(RVA = "0x2685320", Offset = "0x2684720", Length = "0x63")]
		[Token(Token = "0x6000B30")]
		private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

		[Address(RVA = "0x2685390", Offset = "0x2684790", Length = "0x69")]
		[Token(Token = "0x6000B31")]
		private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

		[Address(RVA = "0x2685400", Offset = "0x2684800", Length = "0x69")]
		[Token(Token = "0x6000B32")]
		private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

		[Address(RVA = "0x2685470", Offset = "0x2684870", Length = "0x69")]
		[Token(Token = "0x6000B33")]
		private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

		[Address(RVA = "0x26854E0", Offset = "0x26848E0", Length = "0x69")]
		[Token(Token = "0x6000B34")]
		private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

		[Address(RVA = "0x2685550", Offset = "0x2684950", Length = "0x69")]
		[Token(Token = "0x6000B35")]
		private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

		[Address(RVA = "0x26855C0", Offset = "0x26849C0", Length = "0xEE")]
		[Token(Token = "0x6000B36")]
		private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

		[Address(RVA = "0x26856B0", Offset = "0x2684AB0", Length = "0x69")]
		[Token(Token = "0x6000B37")]
		private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

		[Address(RVA = "0x2685720", Offset = "0x2684B20", Length = "0x7B")]
		[Token(Token = "0x6000B38")]
		private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

		[Address(RVA = "0x2685820", Offset = "0x2684C20", Length = "0x69")]
		[Token(Token = "0x6000B39")]
		private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

		[Address(RVA = "0x26857A0", Offset = "0x2684BA0", Length = "0x7B")]
		[Token(Token = "0x6000B3A")]
		private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

		[Address(RVA = "0x2685890", Offset = "0x2684C90", Length = "0x7B")]
		[Token(Token = "0x6000B3B")]
		private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	}

	[Token(Token = "0x20001BC")]
	private sealed class TypeDescriptionNode : TypeDescriptionProvider
	{
		[Token(Token = "0x20001BD")]
		private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006D5")]
			private TypeDescriptionNode _node; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40006D6")]
			private object _instance; //Field offset: 0x8

			[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
			[Token(Token = "0x6000B43")]
			internal DefaultExtendedTypeDescriptor(TypeDescriptionNode node, object instance) { }

			[Address(RVA = "0x267ADD0", Offset = "0x267A1D0", Length = "0x311")]
			[Token(Token = "0x6000B44")]
			private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

			[Address(RVA = "0x267B0F0", Offset = "0x267A4F0", Length = "0x1F3")]
			[Token(Token = "0x6000B45")]
			private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

			[Address(RVA = "0x267B2F0", Offset = "0x267A6F0", Length = "0x1B9")]
			[Token(Token = "0x6000B46")]
			private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

			[Address(RVA = "0x267B4B0", Offset = "0x267A8B0", Length = "0x2DA")]
			[Token(Token = "0x6000B47")]
			private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

			[Address(RVA = "0x267B790", Offset = "0x267AB90", Length = "0x1B9")]
			[Token(Token = "0x6000B48")]
			private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

			[Address(RVA = "0x267B950", Offset = "0x267AD50", Length = "0x1B9")]
			[Token(Token = "0x6000B49")]
			private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

			[Address(RVA = "0x267BB10", Offset = "0x267AF10", Length = "0x245")]
			[Token(Token = "0x6000B4A")]
			private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

			[Address(RVA = "0x267BD60", Offset = "0x267B160", Length = "0x314")]
			[Token(Token = "0x6000B4B")]
			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

			[Address(RVA = "0x267C080", Offset = "0x267B480", Length = "0x313")]
			[Token(Token = "0x6000B4C")]
			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

			[Address(RVA = "0x267C680", Offset = "0x267BA80", Length = "0x2DA")]
			[Token(Token = "0x6000B4D")]
			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

			[Address(RVA = "0x267C3A0", Offset = "0x267B7A0", Length = "0x2D2")]
			[Token(Token = "0x6000B4E")]
			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

			[Address(RVA = "0x267C960", Offset = "0x267BD60", Length = "0x1D0")]
			[Token(Token = "0x6000B4F")]
			private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

		}

		[Token(Token = "0x20001BE")]
		private struct DefaultTypeDescriptor : ICustomTypeDescriptor
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40006D7")]
			private TypeDescriptionNode _node; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40006D8")]
			private Type _objectType; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40006D9")]
			private object _instance; //Field offset: 0x10

			[Address(RVA = "0x13115B0", Offset = "0x13109B0", Length = "0x4F")]
			[Token(Token = "0x6000B50")]
			internal DefaultTypeDescriptor(TypeDescriptionNode node, Type objectType, object instance) { }

			[Address(RVA = "0x267CB40", Offset = "0x267BF40", Length = "0x2CE")]
			[Token(Token = "0x6000B51")]
			private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

			[Address(RVA = "0x267CE10", Offset = "0x267C210", Length = "0x1EE")]
			[Token(Token = "0x6000B52")]
			private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

			[Address(RVA = "0x267D000", Offset = "0x267C400", Length = "0x1BE")]
			[Token(Token = "0x6000B53")]
			private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

			[Address(RVA = "0x267D1C0", Offset = "0x267C5C0", Length = "0x2D1")]
			[Token(Token = "0x6000B54")]
			private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

			[Address(RVA = "0x267D4A0", Offset = "0x267C8A0", Length = "0x1BE")]
			[Token(Token = "0x6000B55")]
			private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

			[Address(RVA = "0x267D660", Offset = "0x267CA60", Length = "0x1BE")]
			[Token(Token = "0x6000B56")]
			private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

			[Address(RVA = "0x267D820", Offset = "0x267CC20", Length = "0x250")]
			[Token(Token = "0x6000B57")]
			private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

			[Address(RVA = "0x267DD60", Offset = "0x267D160", Length = "0x2D1")]
			[Token(Token = "0x6000B58")]
			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

			[Address(RVA = "0x267DA80", Offset = "0x267CE80", Length = "0x2D6")]
			[Token(Token = "0x6000B59")]
			private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

			[Address(RVA = "0x267E320", Offset = "0x267D720", Length = "0x2D1")]
			[Token(Token = "0x6000B5A")]
			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

			[Address(RVA = "0x267E040", Offset = "0x267D440", Length = "0x2D6")]
			[Token(Token = "0x6000B5B")]
			private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

			[Address(RVA = "0x267E600", Offset = "0x267DA00", Length = "0x1E3")]
			[Token(Token = "0x6000B5C")]
			private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

		}

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006D3")]
		internal TypeDescriptionNode Next; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006D4")]
		internal TypeDescriptionProvider Provider; //Field offset: 0x28

		[Address(RVA = "0x268FE20", Offset = "0x268F220", Length = "0x31")]
		[Token(Token = "0x6000B3C")]
		internal TypeDescriptionNode(TypeDescriptionProvider provider) { }

		[Address(RVA = "0x268F830", Offset = "0x268EC30", Length = "0x19D")]
		[Token(Token = "0x6000B3D")]
		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

		[Address(RVA = "0x268F9D0", Offset = "0x268EDD0", Length = "0x81")]
		[Token(Token = "0x6000B3E")]
		public virtual IDictionary GetCache(object instance) { }

		[Address(RVA = "0x268FA60", Offset = "0x268EE60", Length = "0xCD")]
		[Token(Token = "0x6000B3F")]
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

		[Address(RVA = "0x268FB30", Offset = "0x268EF30", Length = "0x81")]
		[Token(Token = "0x6000B40")]
		protected private virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

		[Address(RVA = "0x268FBC0", Offset = "0x268EFC0", Length = "0xBE")]
		[Token(Token = "0x6000B41")]
		public virtual Type GetReflectionType(Type objectType, object instance) { }

		[Address(RVA = "0x268FC80", Offset = "0x268F080", Length = "0x19A")]
		[Token(Token = "0x6000B42")]
		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	}

	[Token(Token = "0x20001BF")]
	[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private sealed class TypeDescriptorComObject
	{

	}

	[Token(Token = "0x20001C0")]
	private sealed class TypeDescriptorInterface
	{

	}

	[Token(Token = "0x40006BF")]
	private static WeakHashtable _providerTable; //Field offset: 0x0
	[Token(Token = "0x40006C0")]
	private static Hashtable _providerTypeTable; //Field offset: 0x8
	[Token(Token = "0x40006C1")]
	private static Hashtable _defaultProviders; //Field offset: 0x10
	[Token(Token = "0x40006C2")]
	private static WeakHashtable _associationTable; //Field offset: 0x18
	[Token(Token = "0x40006C3")]
	private static int _metadataVersion; //Field offset: 0x20
	[Token(Token = "0x40006C4")]
	private static int _collisionIndex; //Field offset: 0x24
	[Token(Token = "0x40006C5")]
	private static BooleanSwitch TraceDescriptor; //Field offset: 0x28
	[Token(Token = "0x40006C6")]
	private static readonly Guid[] _pipelineInitializeKeys; //Field offset: 0x30
	[Token(Token = "0x40006C7")]
	private static readonly Guid[] _pipelineMergeKeys; //Field offset: 0x38
	[Token(Token = "0x40006C8")]
	private static readonly Guid[] _pipelineFilterKeys; //Field offset: 0x40
	[Token(Token = "0x40006C9")]
	private static readonly Guid[] _pipelineAttributeFilterKeys; //Field offset: 0x48
	[Token(Token = "0x40006CA")]
	private static object _internalSyncObject; //Field offset: 0x50
	[CompilerGenerated]
	[Token(Token = "0x40006CB")]
	private static RefreshEventHandler Refreshed; //Field offset: 0x58

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x17000217")]
	public static Type ComObjectType
	{
		[Address(RVA = "0x26963D0", Offset = "0x26957D0", Length = "0x4D")]
		[Token(Token = "0x6000AFE")]
		 get { } //Length: 77
	}

	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x17000218")]
	public static Type InterfaceType
	{
		[Address(RVA = "0x2696420", Offset = "0x2695820", Length = "0x4D")]
		[Token(Token = "0x6000AFF")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000219")]
	internal static int MetadataVersion
	{
		[Address(RVA = "0x2696470", Offset = "0x2695870", Length = "0x4E")]
		[Token(Token = "0x6000B00")]
		internal get { } //Length: 78
	}

	[Address(RVA = "0x2695F10", Offset = "0x2695310", Length = "0x4B4")]
	[Token(Token = "0x6000B27")]
	private static TypeDescriptor() { }

	[Address(RVA = "0x268FE60", Offset = "0x268F260", Length = "0x2B2")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000B01")]
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	[Address(RVA = "0x2690120", Offset = "0x268F520", Length = "0x69F")]
	[Token(Token = "0x6000B02")]
	private static void CheckDefaultProvider(Type type) { }

	[Address(RVA = "0x26907C0", Offset = "0x268FBC0", Length = "0x2C1")]
	[Token(Token = "0x6000B03")]
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	[Address(RVA = "0x2690A90", Offset = "0x268FE90", Length = "0x247")]
	[Token(Token = "0x6000B04")]
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[Address(RVA = "0x26963D0", Offset = "0x26957D0", Length = "0x4D")]
	[Token(Token = "0x6000AFE")]
	public static Type get_ComObjectType() { }

	[Address(RVA = "0x2696420", Offset = "0x2695820", Length = "0x4D")]
	[Token(Token = "0x6000AFF")]
	public static Type get_InterfaceType() { }

	[Address(RVA = "0x2696470", Offset = "0x2695870", Length = "0x4E")]
	[Token(Token = "0x6000B00")]
	internal static int get_MetadataVersion() { }

	[Address(RVA = "0x2690CE0", Offset = "0x26900E0", Length = "0x4C9")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000B05")]
	public static object GetAssociation(Type type, object primary) { }

	[Address(RVA = "0x2691500", Offset = "0x2690900", Length = "0xDB")]
	[Token(Token = "0x6000B06")]
	public static AttributeCollection GetAttributes(Type componentType) { }

	[Address(RVA = "0x26914B0", Offset = "0x26908B0", Length = "0x4C")]
	[Token(Token = "0x6000B07")]
	public static AttributeCollection GetAttributes(object component) { }

	[Address(RVA = "0x26911B0", Offset = "0x26905B0", Length = "0x2F1")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000B08")]
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	[Address(RVA = "0x26915E0", Offset = "0x26909E0", Length = "0xA1")]
	[Token(Token = "0x6000B09")]
	internal static IDictionary GetCache(object instance) { }

	[Address(RVA = "0x2691690", Offset = "0x2690A90", Length = "0x87")]
	[Token(Token = "0x6000B0A")]
	public static TypeConverter GetConverter(Type type) { }

	[Address(RVA = "0x2691990", Offset = "0x2690D90", Length = "0x104")]
	[Token(Token = "0x6000B0B")]
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	[Address(RVA = "0x2691720", Offset = "0x2690B20", Length = "0x268")]
	[Token(Token = "0x6000B0C")]
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	[Address(RVA = "0x2691E10", Offset = "0x2691210", Length = "0xE1")]
	[Token(Token = "0x6000B0E")]
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	[Address(RVA = "0x2691F00", Offset = "0x2691300", Length = "0x4F")]
	[Token(Token = "0x6000B0F")]
	public static EventDescriptorCollection GetEvents(object component) { }

	[Address(RVA = "0x2691AA0", Offset = "0x2690EA0", Length = "0x365")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000B10")]
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	[Address(RVA = "0x2691F50", Offset = "0x2691350", Length = "0xEF")]
	[Token(Token = "0x6000B0D")]
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	[Address(RVA = "0x2692040", Offset = "0x2691440", Length = "0x229")]
	[Token(Token = "0x6000B11")]
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	[Address(RVA = "0x2692270", Offset = "0x2691670", Length = "0x153")]
	[Token(Token = "0x6000B12")]
	private static Type GetNodeForBaseType(Type searchType) { }

	[Address(RVA = "0x2692A40", Offset = "0x2691E40", Length = "0x8A")]
	[Token(Token = "0x6000B14")]
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[Address(RVA = "0x26927C0", Offset = "0x2691BC0", Length = "0xE1")]
	[Token(Token = "0x6000B13")]
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	[Address(RVA = "0x26929C0", Offset = "0x2691DC0", Length = "0x75")]
	[Token(Token = "0x6000B17")]
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	[Address(RVA = "0x26928B0", Offset = "0x2691CB0", Length = "0x66")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000B15")]
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	[Address(RVA = "0x2692920", Offset = "0x2691D20", Length = "0x97")]
	[Token(Token = "0x6000B16")]
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	[Address(RVA = "0x26923D0", Offset = "0x26917D0", Length = "0x3E9")]
	[Token(Token = "0x6000B18")]
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	[Address(RVA = "0x2692AD0", Offset = "0x2691ED0", Length = "0x4C")]
	[Token(Token = "0x6000B19")]
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[Address(RVA = "0x2692B20", Offset = "0x2691F20", Length = "0x104")]
	[EditorBrowsable(EditorBrowsableState::Advanced (2))]
	[Token(Token = "0x6000B1A")]
	public static Type GetReflectionType(Type type) { }

	[Address(RVA = "0x2692E90", Offset = "0x2692290", Length = "0x4C")]
	[Token(Token = "0x6000B1B")]
	private static TypeDescriptionNode NodeFor(Type type) { }

	[Address(RVA = "0x2692EE0", Offset = "0x26922E0", Length = "0x589")]
	[Token(Token = "0x6000B1C")]
	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	[Address(RVA = "0x2692C30", Offset = "0x2692030", Length = "0x209")]
	[Token(Token = "0x6000B1E")]
	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	[Address(RVA = "0x2692E40", Offset = "0x2692240", Length = "0x4C")]
	[Token(Token = "0x6000B1D")]
	private static TypeDescriptionNode NodeFor(object instance) { }

	[Address(RVA = "0x2693470", Offset = "0x2692870", Length = "0x487")]
	[Token(Token = "0x6000B1F")]
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	[Address(RVA = "0x2693900", Offset = "0x2692D00", Length = "0x10A2")]
	[Token(Token = "0x6000B20")]
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	[Address(RVA = "0x26949B0", Offset = "0x2693DB0", Length = "0x3C2")]
	[Token(Token = "0x6000B21")]
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	[Address(RVA = "0x2694D80", Offset = "0x2694180", Length = "0xA07")]
	[Token(Token = "0x6000B22")]
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	[Address(RVA = "0x2695790", Offset = "0x2694B90", Length = "0xAD")]
	[Token(Token = "0x6000B23")]
	private static void RaiseRefresh(Type type) { }

	[Address(RVA = "0x2695840", Offset = "0x2694C40", Length = "0x536")]
	[Token(Token = "0x6000B24")]
	public static void Refresh(Type type) { }

	[Address(RVA = "0x2695D80", Offset = "0x2695180", Length = "0xBB")]
	[Token(Token = "0x6000B25")]
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	[Address(RVA = "0x2695E40", Offset = "0x2695240", Length = "0xCF")]
	[Token(Token = "0x6000B26")]
	public static void SortDescriptorArray(IList infos) { }

}

