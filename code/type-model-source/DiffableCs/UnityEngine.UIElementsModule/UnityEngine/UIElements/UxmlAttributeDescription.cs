namespace UnityEngine.UIElements;

[Token(Token = "0x20004EB")]
public abstract class UxmlAttributeDescription
{
	[Token(Token = "0x20004EC")]
	internal enum Use : int
	{
		None = 0,
		Optional = 1,
		Prohibited = 2,
		Required = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400107E")]
	private string <name>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400107F")]
	private String[] m_ObsoleteNames; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001080")]
	private string <type>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001081")]
	private string <typeNamespace>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001082")]
	private Use <use>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001083")]
	private UxmlTypeRestriction <restriction>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170009C6")]
	public string name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002525")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002526")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170009C7")]
	public IEnumerable<String> obsoleteNames
	{
		[Address(RVA = "0x32C3590", Offset = "0x32C2990", Length = "0x78")]
		[Token(Token = "0x6002527")]
		 set { } //Length: 120
	}

	[Token(Token = "0x170009CB")]
	public UxmlTypeRestriction restriction
	{
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600252B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170009C8")]
	protected private string type
	{
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002528")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170009C9")]
	protected string typeNamespace
	{
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002529")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170009CA")]
	public Use use
	{
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600252A")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x32C3560", Offset = "0x32C2960", Length = "0x2F")]
	[Token(Token = "0x6002524")]
	protected UxmlAttributeDescription() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002525")]
	public string get_name() { }

	[Address(RVA = "0x9E2FD0", Offset = "0x9E23D0", Length = "0x114")]
	[Token(Token = "0x6002532")]
	protected T GetValueFromBag(IUxmlAttributes bag, CreationContext cc, Func<String, T, T> converterFunc, T defaultValue) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002526")]
	public void set_name(string value) { }

	[Address(RVA = "0x32C3590", Offset = "0x32C2990", Length = "0x78")]
	[Token(Token = "0x6002527")]
	public void set_obsoleteNames(IEnumerable<String> value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600252B")]
	public void set_restriction(UxmlTypeRestriction value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002528")]
	protected private void set_type(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002529")]
	protected void set_typeNamespace(string value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600252A")]
	public void set_use(Use value) { }

	[Address(RVA = "0x32C2B10", Offset = "0x32C1F10", Length = "0x359")]
	[Token(Token = "0x600252C")]
	internal bool TryFindValueInAttributeOverrides(string elementName, CreationContext cc, List<AttributeOverride> attributeOverrides, out string value) { }

	[Address(RVA = "0x32C2E70", Offset = "0x32C2270", Length = "0x2E6")]
	[Token(Token = "0x600252E")]
	internal bool TryGetAttributeOverrideValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value, out VisualTreeAsset sourceAsset) { }

	[Address(RVA = "0x9E3B20", Offset = "0x9E2F20", Length = "0xD2")]
	[Token(Token = "0x6002531")]
	protected bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, Func<String, T, T> converterFunc, T defaultValue, ref T value) { }

	[Address(RVA = "0x32C3490", Offset = "0x32C2890", Length = "0x4E")]
	[Token(Token = "0x600252D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value) { }

	[Address(RVA = "0x32C3160", Offset = "0x32C2560", Length = "0x32C")]
	[Token(Token = "0x6002530")]
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value, out VisualTreeAsset sourceAsset) { }

	[Address(RVA = "0x32C34E0", Offset = "0x32C28E0", Length = "0x7C")]
	[Token(Token = "0x600252F")]
	internal bool ValidateName() { }

}

