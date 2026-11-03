namespace UnityEngine.UIElements;

[Token(Token = "0x200052D")]
public struct CreationContext : IEquatable<CreationContext>
{
	[Token(Token = "0x200052E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct AttributeOverrideRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001120")]
		internal readonly VisualTreeAsset sourceAsset; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001121")]
		internal readonly List<AttributeOverride> attributeOverrides; //Field offset: 0x8

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x600267F")]
		public AttributeOverrideRange(VisualTreeAsset sourceAsset, List<AttributeOverride> attributeOverrides) { }

	}

	[Token(Token = "0x200052F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct SerializedDataOverrideRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001122")]
		internal readonly VisualTreeAsset sourceAsset; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001123")]
		internal readonly int templateId; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001124")]
		internal readonly List<UxmlSerializedDataOverride> attributeOverrides; //Field offset: 0x10

	}

	[Token(Token = "0x4001117")]
	public static readonly CreationContext Default; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001118")]
	private VisualElement <target>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001119")]
	private List<Int32> <veaIdsPath>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400111A")]
	private TemplateAsset <templateAsset>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400111B")]
	private VisualTreeAsset <visualTreeAsset>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400111C")]
	private Dictionary<String, VisualElement> <slotInsertionPoints>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400111D")]
	private List<AttributeOverrideRange> <attributeOverrides>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400111E")]
	private List<SerializedDataOverrideRange> <serializedDataOverrides>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400111F")]
	private List<String> <namesPath>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x17000A08")]
	internal List<AttributeOverrideRange> attributeOverrides
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600266F")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002670")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000A0B")]
	internal bool hasOverrides
	{
		[Address(RVA = "0x32B9360", Offset = "0x32B8760", Length = "0x98")]
		[Token(Token = "0x6002675")]
		internal get { } //Length: 152
	}

	[Token(Token = "0x17000A0A")]
	internal List<String> namesPath
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6002673")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002674")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000A09")]
	internal List<SerializedDataOverrideRange> serializedDataOverrides
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6002671")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002672")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000A07")]
	public private Dictionary<String, VisualElement> slotInsertionPoints
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600266D")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600266E")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000A03")]
	public private VisualElement target
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6002665")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002666")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000A05")]
	internal TemplateAsset templateAsset
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6002669")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600266A")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000A04")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<Int32> veaIdsPath
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6002667")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002668")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000A06")]
	public private VisualTreeAsset visualTreeAsset
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600266B")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600266C")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x32B8FD0", Offset = "0x32B83D0", Length = "0x45")]
	[Token(Token = "0x600267E")]
	private static CreationContext() { }

	[Address(RVA = "0x32B9270", Offset = "0x32B8670", Length = "0xED")]
	[Token(Token = "0x600267A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides, List<SerializedDataOverrideRange> serializedDataOverrides, VisualTreeAsset vta, VisualElement target, List<Int32> veaIdsPath, List<String> namesPath, TemplateAsset ta) { }

	[Address(RVA = "0x32B9140", Offset = "0x32B8540", Length = "0x9F")]
	[Token(Token = "0x6002679")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	[Address(RVA = "0x32B91E0", Offset = "0x32B85E0", Length = "0x85")]
	[Token(Token = "0x6002678")]
	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	[Address(RVA = "0x32B9020", Offset = "0x32B8420", Length = "0x76")]
	[Token(Token = "0x6002677")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CreationContext(Dictionary<String, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides) { }

	[Address(RVA = "0x32B90A0", Offset = "0x32B84A0", Length = "0x99")]
	[Token(Token = "0x6002676")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CreationContext(VisualTreeAsset vta) { }

	[Address(RVA = "0x32B8C80", Offset = "0x32B8080", Length = "0x15F")]
	[Token(Token = "0x600267C")]
	public override bool Equals(CreationContext other) { }

	[Address(RVA = "0x32B8DE0", Offset = "0x32B81E0", Length = "0xC7")]
	[Token(Token = "0x600267B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600266F")]
	internal List<AttributeOverrideRange> get_attributeOverrides() { }

	[Address(RVA = "0x32B9360", Offset = "0x32B8760", Length = "0x98")]
	[Token(Token = "0x6002675")]
	internal bool get_hasOverrides() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6002673")]
	internal List<String> get_namesPath() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6002671")]
	internal List<SerializedDataOverrideRange> get_serializedDataOverrides() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600266D")]
	public Dictionary<String, VisualElement> get_slotInsertionPoints() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6002665")]
	public VisualElement get_target() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6002669")]
	internal TemplateAsset get_templateAsset() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6002667")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<Int32> get_veaIdsPath() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600266B")]
	public VisualTreeAsset get_visualTreeAsset() { }

	[Address(RVA = "0x32B8EB0", Offset = "0x32B82B0", Length = "0x11F")]
	[Token(Token = "0x600267D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002670")]
	private void set_attributeOverrides(List<AttributeOverrideRange> value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002674")]
	private void set_namesPath(List<String> value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002672")]
	private void set_serializedDataOverrides(List<SerializedDataOverrideRange> value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600266E")]
	private void set_slotInsertionPoints(Dictionary<String, VisualElement> value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002666")]
	private void set_target(VisualElement value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600266A")]
	private void set_templateAsset(TemplateAsset value) { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002668")]
	private void set_veaIdsPath(List<Int32> value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600266C")]
	private void set_visualTreeAsset(VisualTreeAsset value) { }

}

