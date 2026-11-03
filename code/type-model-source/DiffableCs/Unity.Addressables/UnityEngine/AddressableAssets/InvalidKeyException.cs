namespace UnityEngine.AddressableAssets;

[Token(Token = "0x200000A")]
public class InvalidKeyException : Exception
{
	[Token(Token = "0x200000B")]
	public enum Format : int
	{
		StandardMessage = 0,
		NoMergeMode = 1,
		MultipleTypesRequested = 2,
		NoLocation = 3,
		TypeMismatch = 4,
		MultipleTypeMismatch = 5,
		MergeModeBase = 6,
		UnionAvailableForKeys = 7,
		UnionAvailableForKeysWithoutOther = 8,
		IntersectionAvailable = 9,
		KeyAvailableAsType = 10,
	}

	[Token(Token = "0x4000016")]
	internal const string BaseInvalidKeyMessageFormat = "{0}, Key={1}, Type={2}"; //Field offset: 0x0
	[Token(Token = "0x4000017")]
	internal const string NoLocationMessageFormat = "{0} No Location found for Key={1}"; //Field offset: 0x0
	[Token(Token = "0x4000018")]
	internal const string MultipleTypeMismatchMessageFormat = "{0} No Asset found for Key={1} with Type={2}. Key exists as multiple Types={3}, which is not assignable from the requested Type={2}"; //Field offset: 0x0
	[Token(Token = "0x4000019")]
	internal const string TypeMismatchMessageFormat = "{0} No Asset found for Key={1} with Type={2}. Key exists as Type={3}, which is not assignable from the requested Type={2}"; //Field offset: 0x0
	[Token(Token = "0x400001A")]
	internal const string MultipleTypesMessageFormat = "{0} Enumerable key contains multiple Types. {1}, all Keys are expected to be strings"; //Field offset: 0x0
	[Token(Token = "0x400001B")]
	internal const string MergeModeNoLocationMessageFormat = "
No Location found for Key={0}"; //Field offset: 0x0
	[Token(Token = "0x400001C")]
	internal const string NoMergeModeMessageFormat = "{0} No MergeMode is set to merge the multiple keys requested. {1}, Type={2}"; //Field offset: 0x0
	[Token(Token = "0x400001D")]
	internal const string MergeModeBaseMessageFormat = "{0} No {1} of Assets between {2} with Type={3}"; //Field offset: 0x0
	[Token(Token = "0x400001E")]
	internal const string UnionAvailableForKeysMessageFormat = "
Union of Type={0} found with {1}"; //Field offset: 0x0
	[Token(Token = "0x400001F")]
	internal const string UnionAvailableForKeysWithoutOtherMessageFormat = "
Union of Type={0} found with {1}. Without {2}"; //Field offset: 0x0
	[Token(Token = "0x4000020")]
	internal const string IntersectionAvailableMessageFormat = "
An Intersection exists for Type={0}"; //Field offset: 0x0
	[Token(Token = "0x4000021")]
	internal const string KeyAvailableAsTypeMessageFormat = "
Type={0} exists for {1}"; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000012")]
	private object <Key>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000013")]
	private Type <Type>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000014")]
	private readonly Nullable<MergeMode> <MergeMode>k__BackingField; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000015")]
	private AddressablesImpl m_Addressables; //Field offset: 0xA8

	[Token(Token = "0x17000009")]
	public private object Key
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000021")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000022")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700000B")]
	public Nullable<MergeMode> MergeMode
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000025")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public virtual string Message
	{
		[Address(RVA = "0x27AEE70", Offset = "0x27AE270", Length = "0x514")]
		[Token(Token = "0x6000031")]
		 get { } //Length: 1300
	}

	[Token(Token = "0x1700000A")]
	public private Type Type
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000023")]
		 get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000024")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x27AE900", Offset = "0x27ADD00", Length = "0x69")]
	[Token(Token = "0x600002D")]
	public InvalidKeyException(string message, Exception innerException) { }

	[Address(RVA = "0x27AE970", Offset = "0x27ADD70", Length = "0xB5")]
	[Token(Token = "0x6000026")]
	public InvalidKeyException(object key) { }

	[Address(RVA = "0x27AECC0", Offset = "0x27AE0C0", Length = "0x8E")]
	[Token(Token = "0x6000027")]
	public InvalidKeyException(object key, Type type) { }

	[Address(RVA = "0x27AED50", Offset = "0x27AE150", Length = "0xB1")]
	[Token(Token = "0x6000028")]
	internal InvalidKeyException(object key, Type type, AddressablesImpl addr) { }

	[Address(RVA = "0x27AEBA0", Offset = "0x27ADFA0", Length = "0xD0")]
	[Token(Token = "0x6000029")]
	public InvalidKeyException(object key, Type type, MergeMode mergeMode) { }

	[Address(RVA = "0x27AEAB0", Offset = "0x27ADEB0", Length = "0xE8")]
	[Token(Token = "0x600002A")]
	internal InvalidKeyException(object key, Type type, MergeMode mergeMode, AddressablesImpl addr) { }

	[Address(RVA = "0x27AEC70", Offset = "0x27AE070", Length = "0x49")]
	[Token(Token = "0x600002B")]
	public InvalidKeyException() { }

	[Address(RVA = "0x27AEE10", Offset = "0x27AE210", Length = "0x59")]
	[Token(Token = "0x600002C")]
	public InvalidKeyException(string message) { }

	[Address(RVA = "0x27AEA30", Offset = "0x27ADE30", Length = "0x74")]
	[Token(Token = "0x600002E")]
	protected InvalidKeyException(SerializationInfo message, StreamingContext context) { }

	[Address(RVA = "0x27AC2E0", Offset = "0x27AB6E0", Length = "0x448")]
	[Token(Token = "0x6000030")]
	internal string FormatMergeModeMessage(Format format, string keysAvailable = null, string keysUnavailable = null, string typeString = null) { }

	[Address(RVA = "0x27AC750", Offset = "0x27ABB50", Length = "0x730")]
	[Token(Token = "0x600002F")]
	internal string FormatMessage(Format format, string foundWithTypeString = null) { }

	[Address(RVA = "0x27ACEA0", Offset = "0x27AC2A0", Length = "0x1F7")]
	[Token(Token = "0x6000035")]
	private string FormatMultipleAssignableTypesMessage(string keyString, HashSet<Type> typesAvailableForKey) { }

	[Address(RVA = "0x27AD0A0", Offset = "0x27AC4A0", Length = "0x10")]
	[Token(Token = "0x6000033")]
	private string FormatNotFoundMessage(string keyString) { }

	[Address(RVA = "0x27AD0B0", Offset = "0x27AC4B0", Length = "0x19D")]
	[Token(Token = "0x6000034")]
	private string FormatTypeNotAssignableMessage(string keyString, HashSet<Type> typesAvailableForKey) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000021")]
	public object get_Key() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000025")]
	public Nullable<MergeMode> get_MergeMode() { }

	[Address(RVA = "0x27AEE70", Offset = "0x27AE270", Length = "0x514")]
	[Token(Token = "0x6000031")]
	public virtual string get_Message() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000023")]
	public Type get_Type() { }

	[Address(RVA = "0x27AD250", Offset = "0x27AC650", Length = "0x2BC")]
	[Token(Token = "0x600003A")]
	internal static string GetCSVString(IEnumerable enumerator, string prefixSingle, string prefixPlural) { }

	[Address(RVA = "0x27AD510", Offset = "0x27AC910", Length = "0xEA")]
	[Token(Token = "0x6000039")]
	internal string GetKeyString() { }

	[Address(RVA = "0x27AD6A0", Offset = "0x27ACAA0", Length = "0xC4F")]
	[Token(Token = "0x6000036")]
	private string GetMessageforMergeKeys(List<String> keys) { }

	[Address(RVA = "0x27AD600", Offset = "0x27ACA00", Length = "0x91")]
	[Token(Token = "0x6000032")]
	private string GetMessageForSingleKey(string keyString) { }

	[Address(RVA = "0x27AE530", Offset = "0x27AD930", Length = "0x3C4")]
	[Token(Token = "0x6000037")]
	private HashSet<Type> GetTypesForKey(string keyString) { }

	[Address(RVA = "0x27AE2F0", Offset = "0x27AD6F0", Length = "0x23E")]
	[Token(Token = "0x6000038")]
	private bool GetTypeToKeys(string key, Dictionary<Type, List`1<String>> typeToKeys) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000022")]
	private void set_Key(object value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000024")]
	private void set_Type(Type value) { }

}

