namespace Unity.Cinemachine;

[Token(Token = "0x20000A0")]
public class FoldoutWithEnabledButtonAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000289")]
	public string EnabledPropertyName; //Field offset: 0x18

	[Address(RVA = "0x1DD97C0", Offset = "0x1DD8BC0", Length = "0x31")]
	[Token(Token = "0x600032A")]
	public FoldoutWithEnabledButtonAttribute(string enabledProperty = "Enabled") { }

}

