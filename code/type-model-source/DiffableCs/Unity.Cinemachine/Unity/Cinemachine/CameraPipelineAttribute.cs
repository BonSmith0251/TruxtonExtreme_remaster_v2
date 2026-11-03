namespace Unity.Cinemachine;

[Token(Token = "0x20000AA")]
public sealed class CameraPipelineAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000290")]
	private Stage <Stage>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000B2")]
	public private Stage Stage
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000334")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000335")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000336")]
	public CameraPipelineAttribute(Stage stage) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000334")]
	public Stage get_Stage() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000335")]
	private void set_Stage(Stage value) { }

}

