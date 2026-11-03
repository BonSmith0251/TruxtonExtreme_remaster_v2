namespace UnityEngine.Rendering.Universal;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x2000170")]
public class DisallowMultipleRendererFeature : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000857")]
	private string <customTitle>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001DD")]
	public private string customTitle
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007FA")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007F9")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60007FB")]
	public DisallowMultipleRendererFeature(string customTitle = null) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007FA")]
	public string get_customTitle() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007F9")]
	private void set_customTitle(string value) { }

}

