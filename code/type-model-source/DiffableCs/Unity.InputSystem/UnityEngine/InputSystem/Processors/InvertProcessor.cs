namespace UnityEngine.InputSystem.Processors;

[Token(Token = "0x20001F0")]
public class InvertProcessor : InputProcessor<Single>
{

	[Address(RVA = "0x2A118F0", Offset = "0x2A10CF0", Length = "0x39")]
	[Token(Token = "0x6001264")]
	public InvertProcessor() { }

	[Address(RVA = "0x2A118B0", Offset = "0x2A10CB0", Length = "0xC")]
	[Token(Token = "0x6001262")]
	public virtual float Process(float value, InputControl control) { }

	[Address(RVA = "0x2A118C0", Offset = "0x2A10CC0", Length = "0x2C")]
	[Token(Token = "0x6001263")]
	public virtual string ToString() { }

}

