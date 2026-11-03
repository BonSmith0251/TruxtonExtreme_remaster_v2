namespace Unity.XGamingRuntime;

[Token(Token = "0x20000E7")]
public class GdkEditionAsset : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000148")]
	[Tooltip("The GDK Edition number used for API compatibility checks")]
	private int m_EditionNumber; //Field offset: 0x18

	[Token(Token = "0x1700000A")]
	public int EditionNumber
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600056E")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000570")]
	public GdkEditionAsset() { }

	[Address(RVA = "0x2B6E500", Offset = "0x2B6D900", Length = "0x43")]
	[Token(Token = "0x600056F")]
	public static GdkEditionAsset CreateInstance(int editionNumber) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600056E")]
	public int get_EditionNumber() { }

}

