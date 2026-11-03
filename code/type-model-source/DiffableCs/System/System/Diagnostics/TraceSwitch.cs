namespace System.Diagnostics;

[SwitchLevel(typeof(TraceLevel))]
[Token(Token = "0x2000105")]
public class TraceSwitch : Switch
{

	[Address(RVA = "0x2640260", Offset = "0x263F660", Length = "0x93")]
	[Token(Token = "0x600065A")]
	public TraceSwitch(string displayName, string description) { }

}

