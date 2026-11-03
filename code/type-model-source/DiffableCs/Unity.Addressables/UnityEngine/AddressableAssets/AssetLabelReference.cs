namespace UnityEngine.AddressableAssets;

[Token(Token = "0x200002E")]
public class AssetLabelReference : IKeyEvaluator
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_labelString")]
	[SerializeField]
	[Token(Token = "0x40000AE")]
	private string m_LabelString; //Field offset: 0x10

	[Token(Token = "0x1700002A")]
	public string labelString
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000159")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002B")]
	public override object RuntimeKey
	{
		[Address(RVA = "0x27A4B30", Offset = "0x27A3F30", Length = "0x42")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 66
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600015D")]
	public AssetLabelReference() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000158")]
	public string get_labelString() { }

	[Address(RVA = "0x27A4B30", Offset = "0x27A3F30", Length = "0x42")]
	[Token(Token = "0x600015A")]
	public override object get_RuntimeKey() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x600015C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x27A4AC0", Offset = "0x27A3EC0", Length = "0x61")]
	[Token(Token = "0x600015B")]
	public override bool RuntimeKeyIsValid() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000159")]
	public void set_labelString(string value) { }

}

