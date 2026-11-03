namespace InGame.Kernel.Effect;

[Token(Token = "0x2000239")]
public class InGameEffectStopper : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013B6")]
	private bool _isStopped; //Field offset: 0x20

	[Token(Token = "0x17000230")]
	public bool IsStopped
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60010F9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60010FA")]
	public InGameEffectStopper() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60010F9")]
	public bool get_IsStopped() { }

	[Address(RVA = "0x1D15400", Offset = "0x1D14800", Length = "0x5")]
	[Token(Token = "0x60010F8")]
	private void OnParticleSystemStopped() { }

	[Address(RVA = "0x1D15410", Offset = "0x1D14810", Length = "0x5")]
	[Token(Token = "0x60010F7")]
	public void StartEffect() { }

}

