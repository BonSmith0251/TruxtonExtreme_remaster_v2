namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[Token(Token = "0x200008E")]
public struct SortingLayer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013C")]
	private int m_Id; //Field offset: 0x0

	[Token(Token = "0x17000047")]
	public int id
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6000236")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004A")]
	public static SortingLayer[] layers
	{
		[Address(RVA = "0x2FEA4D0", Offset = "0x2FE98D0", Length = "0x8D")]
		[Token(Token = "0x6000239")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000048")]
	public string name
	{
		[Address(RVA = "0x2FEA560", Offset = "0x2FE9960", Length = "0xB")]
		[Token(Token = "0x6000237")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000049")]
	public int value
	{
		[Address(RVA = "0x2FEA570", Offset = "0x2FE9970", Length = "0x31")]
		[Token(Token = "0x6000238")]
		 get { } //Length: 49
	}

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6000236")]
	public int get_id() { }

	[Address(RVA = "0x2FEA4D0", Offset = "0x2FE98D0", Length = "0x8D")]
	[Token(Token = "0x6000239")]
	public static SortingLayer[] get_layers() { }

	[Address(RVA = "0x2FEA560", Offset = "0x2FE9960", Length = "0xB")]
	[Token(Token = "0x6000237")]
	public string get_name() { }

	[Address(RVA = "0x2FEA570", Offset = "0x2FE9970", Length = "0x31")]
	[Token(Token = "0x6000238")]
	public int get_value() { }

	[Address(RVA = "0x2FEA090", Offset = "0x2FE9490", Length = "0x31")]
	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	[Token(Token = "0x600023B")]
	public static int GetLayerValueFromID(int id) { }

	[Address(RVA = "0x2FEA110", Offset = "0x2FE9510", Length = "0xB3")]
	[FreeFunction("GetTagManager().GetSortingLayerIDs")]
	[Token(Token = "0x600023A")]
	private static Int32[] GetSortingLayerIDsInternal() { }

	[Address(RVA = "0x2FEA0D0", Offset = "0x2FE94D0", Length = "0x33")]
	[Token(Token = "0x600023F")]
	private static void GetSortingLayerIDsInternal_Injected(out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x2FEA210", Offset = "0x2FE9610", Length = "0xAA")]
	[FreeFunction("GetTagManager().GetSortingLayerNameFromUniqueID")]
	[Token(Token = "0x600023D")]
	public static string IDToName(int id) { }

	[Address(RVA = "0x2FEA1D0", Offset = "0x2FE95D0", Length = "0x40")]
	[Token(Token = "0x6000241")]
	private static void IDToName_Injected(int id, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FEA2C0", Offset = "0x2FE96C0", Length = "0x31")]
	[FreeFunction("GetTagManager().IsSortingLayerUniqueIDValid")]
	[Token(Token = "0x600023E")]
	public static bool IsValid(int id) { }

	[Address(RVA = "0x2FEA340", Offset = "0x2FE9740", Length = "0x18C")]
	[FreeFunction("GetTagManager().GetSortingLayerUniqueIDFromName")]
	[Token(Token = "0x600023C")]
	public static int NameToID(string name) { }

	[Address(RVA = "0x2FEA300", Offset = "0x2FE9700", Length = "0x33")]
	[Token(Token = "0x6000240")]
	private static int NameToID_Injected(ref ManagedSpanWrapper name) { }

}

