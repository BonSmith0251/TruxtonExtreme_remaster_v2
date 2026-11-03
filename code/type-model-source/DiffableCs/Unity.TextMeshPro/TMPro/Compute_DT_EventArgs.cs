namespace TMPro;

[Token(Token = "0x200001D")]
public class Compute_DT_EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B1")]
	public Compute_DistanceTransform_EventTypes EventType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000B2")]
	public float ProgressPercentage; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B3")]
	public Color[] Colors; //Field offset: 0x18

	[Address(RVA = "0x2EAE510", Offset = "0x2EAD910", Length = "0x36")]
	[Token(Token = "0x6000124")]
	public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress) { }

	[Address(RVA = "0xF53D70", Offset = "0xF53170", Length = "0x40")]
	[Token(Token = "0x6000125")]
	public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors) { }

}

