namespace UnityEngine.UIElements;

[HelpURL("ui-systems/custom-filters")]
[Token(Token = "0x2000250")]
public sealed class FilterFunctionDefinition : ScriptableObject
{
	[DontCreateProperty]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000900")]
	private string m_FilterName; //Field offset: 0x18
	[DontCreateProperty]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000901")]
	private FilterParameterDeclaration[] m_Parameters; //Field offset: 0x20
	[DontCreateProperty]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000902")]
	private PostProcessingPass[] m_Passes; //Field offset: 0x28

	[CreateProperty]
	[Token(Token = "0x170002E4")]
	public string filterName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000FE4")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000FE5")]
		 set { } //Length: 13
	}

	[CreateProperty]
	[Token(Token = "0x170002E5")]
	public FilterParameterDeclaration[] parameters
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000FE6")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000FE7")]
		 set { } //Length: 13
	}

	[CreateProperty]
	[Token(Token = "0x170002E6")]
	public PostProcessingPass[] passes
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000FE8")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000FE9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000FEA")]
	public FilterFunctionDefinition() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000FE4")]
	public string get_filterName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000FE6")]
	public FilterParameterDeclaration[] get_parameters() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000FE8")]
	public PostProcessingPass[] get_passes() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000FE5")]
	public void set_filterName(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000FE7")]
	public void set_parameters(FilterParameterDeclaration[] value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000FE9")]
	public void set_passes(PostProcessingPass[] value) { }

}

