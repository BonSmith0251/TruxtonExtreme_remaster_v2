namespace UnityEngine.UIElements;

[Token(Token = "0x200051A")]
public abstract class UxmlSerializedData
{
	[Flags]
	[Token(Token = "0x200051B")]
	internal enum UxmlAttributeFlags : byte
	{
		Ignore = 0,
		OverriddenInUxml = 1,
		DefaultValue = 2,
	}

	[Token(Token = "0x40010BE")]
	internal const string AttributeFlagSuffix = "_UxmlAttributeFlags"; //Field offset: 0x0
	[Token(Token = "0x40010BF")]
	private const UxmlAttributeFlags k_DefaultFlags = 1; //Field offset: 0x0
	[Token(Token = "0x40010C1")]
	private static UxmlAttributeFlags s_CurrentDeserializeFlags; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40010C0")]
	[UxmlIgnore]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int uxmlAssetId; //Field offset: 0x10

	[Address(RVA = "0x32C5F50", Offset = "0x32C5350", Length = "0x36")]
	[Token(Token = "0x60025D1")]
	private static UxmlSerializedData() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60025D0")]
	protected UxmlSerializedData() { }

	[Token(Token = "0x60025CE")]
	public abstract object CreateInstance() { }

	[Token(Token = "0x60025CF")]
	public abstract void Deserialize(object obj) { }

}

