namespace Unity.Cinemachine;

[Token(Token = "0x20000A1")]
public sealed class EnabledPropertyAttribute : FoldoutWithEnabledButtonAttribute
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400028A")]
	public string ToggleDisabledText; //Field offset: 0x20

	[Address(RVA = "0x2844990", Offset = "0x2843D90", Length = "0x4E")]
	[Token(Token = "0x600032B")]
	public EnabledPropertyAttribute(string enabledProperty = "Enabled", string toggleText = "") { }

}

