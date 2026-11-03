namespace UnityEngine.Rendering;

[Token(Token = "0x2000065")]
public class SerializableEnum
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000156")]
	private string m_EnumValueAsString; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000157")]
	private string m_EnumTypeAsString; //Field offset: 0x18

	[Token(Token = "0x17000047")]
	public Enum value
	{
		[Address(RVA = "0x2BE7260", Offset = "0x2BE6660", Length = "0x119")]
		[Token(Token = "0x600056B")]
		 get { } //Length: 281
		[Address(RVA = "0x2BE7380", Offset = "0x2BE6780", Length = "0x41")]
		[Token(Token = "0x600056C")]
		 set { } //Length: 65
	}

	[Address(RVA = "0x2BE71C0", Offset = "0x2BE65C0", Length = "0x92")]
	[Token(Token = "0x600056D")]
	public SerializableEnum(Type enumType) { }

	[Address(RVA = "0x2BE7260", Offset = "0x2BE6660", Length = "0x119")]
	[Token(Token = "0x600056B")]
	public Enum get_value() { }

	[Address(RVA = "0x2BE7380", Offset = "0x2BE6780", Length = "0x41")]
	[Token(Token = "0x600056C")]
	public void set_value(Enum value) { }

}

